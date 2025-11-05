using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Configuration;
using SISPAE.Business.custom;
using SISPAE.Model.Security;
using SISPAE_API_Alertas.WebAPI.OperationFilter;
using SISPAE.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Net.Http.Headers;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.OpenApi.Models;
using System;
using Microsoft.IdentityModel.Tokens;


using Microsoft.Extensions.FileProviders;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.OData;
using Azure.Storage.Blobs;
using ElmahCore.Mvc;
using SISPAE.Business.Services;
using SISPAE_API_Alertas.WebAPI.Data;
using SISPAE_API_Alertas.WebAPI.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ElmahCore.Sql;
using EmailService;
using Swashbuckle.AspNetCore.SwaggerGen;
using SISPAE.DataAccess.DataInterfaces;
using SISPAE.DataAccess.DataMapper;

namespace SISPAE_API_Alertas.WebAPI
{
    public class Startup
    {
        private readonly string CorsConfiguration = "_corsConfiguration";

        public Startup(IConfiguration configuration)
            {
            Configuration= configuration;
            }

        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services )   
            {

            //
            DateTime now = DateTime.Now;
            // services.AddElmah(); services.AddElmah<SqlErrorLog>(options => { options.ConnectionString = Configuration.GetConnectionString("ELMAH_Sqlserver"); }); services.AddScoped<JwtHandler>();
            services.AddElmah(); services.AddElmah<SqlErrorLog>(options => { options.ConnectionString = Configuration.GetConnectionString("DefaultConnection"); }); services.AddScoped<JwtHandler>();



            //Manejo del coreIdentity
            services.AddDbContext<DataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            //services.AddIdentity<User, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = false)
            //    .AddRoleManager<RoleManager<IdentityRole>>()
            //    .AddEntityFrameworkStores<DataContext>()
            //    .AddDefaultTokenProviders();//JCB Se incluye para permitir actualizar el password
            services.AddScoped<IAplicacion, AplicacionRepository>();
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<DataContext>().AddRoles<IdentityRole>()
                 .AddEntityFrameworkStores<DataContext>()
                    .AddDefaultTokenProviders()
            ;
            //establecemos la vida útil de este token en dos horas. para el proveedor de tokes en esta caso de MAIL
            services.Configure<DataProtectionTokenProviderOptions>(opt => opt.TokenLifespan = TimeSpan.FromHours(2));


            

            // ** JCB Creamos el singleton para el manejo de almacenamiento de archivos desde cualquier controlador
            FileStorage fileStorage = new FileStorage();
            Configuration.GetSection("FileStorage").Bind(fileStorage);

            ////JCB manejo de envio de mails
            var emailConfig = Configuration.GetSection("EmailConfiguration").Get<EmailConfiguration>();
            services.AddSingleton(emailConfig);
            services.AddScoped<IEmailSender, EmailSender>();

            services.AddSingleton<FileStorage>(fileStorage);
            //services.Configure<FileStorage>(Configuration.GetSection("FileStorage"));


            // Add the processing server as IHostedService
            //services.AddHangfire(x => x.UseSqlServerStorage("<ConnectionStrings DefaultConnection>"));
            
            services.AddScoped<IBlobStorageService, BlobStorageService>();

            services.AddControllers().AddNewtonsoftJson(); // Required in .NET Core 3 and later. Optional before

            services.AddScoped<IAuthenticationServices, AuthenticationServices>();

            //var jwtSection = Configuration.GetSection("jwt");
            //var jwtOptions = new JwtOptions();
            //jwtSection.Bind(jwtOptions);
            //services.Configure<JwtOptions>(jwtSection);
            //var secretKey = Environment.GetEnvironmentVariable("API_MANAGEMENT_JWT_KEY");
            //var key = Encoding.ASCII.GetBytes(secretKey);


            //https://stackoverflow.com/questions/52206742/asp-core-2-1-jwt-identity-usermanager-store-does-not-implement-iuserrolestore/52207398#52207398
            //Debido al orden en que se define(AddIdentitydespués de AddAuthentication), el valor predeterminado cambia de Jwt a Identity, de modo que cuando usa[Authorize], el proceso de autenticación ahora espera usar Identity en lugar de Jwt.
            //Para resolver esto, la opcion mas simple es cambiar el orden de AddIdentityy AddAuthentication, de modo que la llamada JwtBearer sea la ultima y, por lo tanto, "gane".Tambien debera ser mas explicito y establecer tanto DefaultAuthenticateSchemey DefaultChallengeScheme:

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;


            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                    {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = Configuration["Jwt:validIssuer"],
                    ValidAudience = Configuration["Jwt:validAudience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
                    };
            });

            //services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            //    .AddJwtBearer(options =>
            //    {
            //        options.TokenValidationParameters = new TokenValidationParameters
            //        {
            //            ValidateIssuer = false,
            //            ValidateAudience = false,
            //            ValidateLifetime = true,
            //            ValidateIssuerSigningKey = true,
            //            ValidIssuer = Configuration["Jwt:Issuer"],
            //            ValidAudience = Configuration["Jwt:Issuer"],
            //            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
            //        };
            //    });







            // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
            services.ConfigureSwaggerGen(options =>
            {
                // Set the comments path for the Swagger JSON and UI.

                var basePath = AppContext.BaseDirectory;
                var xmlPath = Path.Combine(basePath, "SISPAE.WebAPI.xml");
                //options.IncludeXmlComments(xmlPath);
                var assemblyName = System.Reflection.Assembly.GetEntryAssembly().GetName().Name;
                var fileName = System.IO.Path.GetFileName(assemblyName + ".xml");

                //Set the comments path for the swagger json and ui.

                options.IncludeXmlComments(System.IO.Path.Combine(basePath, fileName));

                //original 
                //options.IncludeXmlComments(Path.ChangeExtension(Assembly.GetEntryAssembly()?.Location, "xml"));
                //options.IncludeXmlComments($@"{System.AppDomain.CurrentDomain.BaseDirectory}\SISPAE.WebAPI.xml");
                //options.IncludeXmlComments(System.IO.Path.Combine(basePath, fileName));

                options.OperationFilter<AddApiParameters>();

            });
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                    {
                    Title = "SISPAE WebAPI",
                    Version = "v1",
                    Description = "Microservicios Api para recuperar información del sistema SISPAE - \n\n " + now.ToLongDateString() + " " + now.ToLongTimeString(),
                    TermsOfService = new Uri("https://www.alimentosparaaprender.gov.co/politicas/"),
                    Contact = new OpenApiContact
                        {
                        Name = "Unidad Administrativa Especial De Alimentación Escolar",
                        Email = "atencion@alimentosparaaprender.gov.co"
                        },
                    License = new OpenApiLicense
                        {
                        Name = ".Net Core 6.0",
                        Url = new Uri("https://www.alimentosparaaprender.gov.co/")
                        }
                    });
                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                    {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n 
                      Enter 'Bearer' [space] and then your token in the text input below.
                      \r\n\r\nExample: 'Bearer 12345abcdef'"
                    });
                c.EnableAnnotations();
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                        {
                            new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "Bearer"
                                }
                            },
                            new string[] {}

                        }
                });

                AddSwaggerDocumentation(c);
            });

            services.AddMvc().AddNewtonsoftJson();
            services.AddSwaggerGenNewtonsoftSupport();// aceptacion explicita: debe colocarse despues de AddSwaggerGen ()
            services.AddControllers(mvcOptions =>
                mvcOptions.EnableEndpointRouting = false);

            // Leer el valor de CorsOrigins del archivo appsettings.json
            var corsOrigins = Configuration.GetSection("CorsOrigins").Get<string[]>();
            services.AddCors(options =>
            {
                options.AddPolicy(name:CorsConfiguration,
                    builder =>
                    {
                         builder.WithOrigins(corsOrigins)
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                   });
            });
            //services.AddOData();
            services.AddControllers().AddOData(options => options.Select().Filter().OrderBy());
            /*services.AddMvcCore(options =>
            {
                foreach (var outputFormatter in options.OutputFormatters.OfType<ODataOutputFormatter>().Where(_ => _.SupportedMediaTypes.Count == 0))
                {
                    outputFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/prs.odatatestxx-odata"));
                }
                foreach (var inputFormatter in options.InputFormatters.OfType<ODataInputFormatter>().Where(_ => _.SupportedMediaTypes.Count == 0))
                {
                    inputFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/prs.odatatestxx-odata"));
                }

            });*/
            services.AddMvcCore().AddApiExplorer();
            services.AddMvc();
            }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
            {

            

            app.UseStaticFiles();


            if(env.IsDevelopment())
                {
                app.UseDeveloperExceptionPage();
                }
            else
                {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
                }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseCors(x => x
              .AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader());
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseSwagger(c =>
            {
                c.PreSerializeFilters.Add((swaggerDoc, httpRequest) =>
                {
                    if(!httpRequest.Headers.ContainsKey("X-Forwarded-Host")) return;
                    var basePath = "sispae-api-alertas";
                    var serverUrl = $"{httpRequest.Scheme}://{httpRequest.Headers["X-Forwarded-Host"]}/{basePath}";
                    swaggerDoc.Servers = new List<OpenApiServer> { new OpenApiServer { Url = serverUrl } };
                });
            });

            app.UseElmah(); app.UseSwagger(); ;
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("v1/swagger.json", "Multitenant API V1");
                //c.RoutePrefix = string.Empty;
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                
            });
            /*var builder = new ODataConventionModelBuilder(app.ApplicationServices);
            app.UseMvc(routeBuilder =>
            {
                routeBuilder.MapODataServiceRoute("ODataRoute", "odata", builder.GetEdmModel());
                routeBuilder.EnableDependencyInjection();
                routeBuilder.Expand().Select().OrderBy().Filter().MaxTop(null).Count();
            });*/
            }

        private static void AddSwaggerDocumentation(SwaggerGenOptions o)
            {
            var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            o.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
            }
        }
    }
