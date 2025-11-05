using Azure.Extensions.AspNetCore.Configuration.Secrets;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SISPAE.Common;
using System;

namespace SISPAE_API_Acceso.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // 🔧 Configurar KeyVault
            var keyVaultName = Environment.GetEnvironmentVariable("KEY_VAULT_NAME");
            var tenantId = Environment.GetEnvironmentVariable("AZURE_TENANT_ID");
            var clientId = Environment.GetEnvironmentVariable("AZURE_CLIENT_ID");
            var clientSecret = Environment.GetEnvironmentVariable("AZURE_CLIENT_SECRET");

            if (!string.IsNullOrEmpty(keyVaultName) &&
                !string.IsNullOrEmpty(tenantId) &&
                !string.IsNullOrEmpty(clientId) &&
                !string.IsNullOrEmpty(clientSecret))
            {
                try
                {
                    var kvUri = $"https://{keyVaultName}.vault.azure.net/";
                    Console.WriteLine($"🔑 Usando KeyVault: {kvUri}");

                    var credential = new ClientSecretCredential(tenantId, clientId, clientSecret);
                    var client = new SecretClient(new Uri(kvUri), credential);

                    builder.Configuration.AddAzureKeyVault(client, new AzureKeyVaultConfigurationOptions());
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"⚠️ No se pudo conectar al KeyVault: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("⚠️ Variables de entorno para KeyVault no configuradas, se omite conexión a Azure KeyVault.");
            }

            // 🔧 Configuración adicional
            builder.Configuration.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            builder.Configuration.AddJsonFile("secrets/appsettings.secrets.json", optional: true, reloadOnChange: true);
            builder.Configuration.AddEnvironmentVariables();

            // 🚀 Agregar servicios
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // 🚀 Middleware
            if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}
