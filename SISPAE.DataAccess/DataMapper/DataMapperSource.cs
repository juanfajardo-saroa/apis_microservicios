/// <Derechos_Reservados>
/// Aplicacion		:SISPAE 
/// Autor			:TiGlobal SAS y SoftManagement
/// Generacion		:Este archivo es generado automaticamente mediante generador GeneraApp.
/// Ano			    :2022
/// Arquitectura	:Patron MVC Repository Microservicios Net Core ,Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS,
/// Capa			:DataAccess (DataAccess Entity Layer) - Capa Model Partial(Source: MVC7_DAL_DataMapperSource.CS)  Partial Interface 
/// </Derechos_Reservados>
using Azure.Extensions.AspNetCore.Configuration.Secrets;
using Azure.Security.KeyVault.Secrets;
using Azure.Identity;
using Microsoft.Extensions.Configuration;
using System.IO;
using SISPAE.Common;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Configuration;

namespace SISPAE.DataAccess.DataMapper
{
    public class DataMapperSource
    {
        public string cadena { get; set; }
        public static IConfigurationRoot Configuration;

        public DataMapperSource()
        {
            var kvUrl = Environment.GetEnvironmentVariable("KeyVaultUrl").ToStringBase64();
            var tenanId = Environment.GetEnvironmentVariable("TenantId").ToStringBase64();
            var clientId = Environment.GetEnvironmentVariable("ClientId").ToStringBase64();
            var clientSecret = Environment.GetEnvironmentVariable("ClientSecret").ToStringBase64();
            var credential = new ClientSecretCredential(tenanId, clientId, clientSecret);
            var client = new SecretClient(new Uri(kvUrl), credential);
            var secret = client.GetSecret("SIPAE-Database-ConnectionString");
            //var secret = client.GetSecret("DefaultConnection");
            cadena = secret.Value.Value;

            //var builder = new ConfigurationBuilder()
            //   .SetBasePath(Directory.GetCurrentDirectory())
            //   .AddJsonFile("appsettings.json")
            //   .AddJsonFile("secrets/appsettings.secrets.json", optional: true, reloadOnChange: true);

            //Configuration = builder.Build();
            //cadena = Configuration["ConnectionStrings:DefaultConnection"];

        }
    }
}