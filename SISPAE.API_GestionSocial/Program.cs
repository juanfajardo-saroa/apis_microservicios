using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Extensions.AspNetCore.Configuration.Secrets;
using Azure.Security.KeyVault.Secrets;
using Azure.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SISPAE.Common;

namespace SISPAE_API_GestionSocial.WebAPI
    {
    public class Program
        {
        public static void Main(string[] args)
            {
            CreateHostBuilder(args).Build().Run();
            }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
               .ConfigureAppConfiguration((context, config) =>
               {
                  var kvUrl = Environment.GetEnvironmentVariable("KeyVaultUrl").ToStringBase64();
                 var tenanId = Environment.GetEnvironmentVariable("TenantId").ToStringBase64();
                 var clientId = Environment.GetEnvironmentVariable("ClientId").ToStringBase64();
                 var clientSecret = Environment.GetEnvironmentVariable("ClientSecret").ToStringBase64();
                 var credential = new ClientSecretCredential(tenanId, clientId, clientSecret);
                 var client = new SecretClient(new Uri(kvUrl), credential);
                 config.AddAzureKeyVault(client, new AzureKeyVaultConfigurationOptions());

                 config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                  config.AddJsonFile("secrets/appsettings.secrets.json", optional: true, reloadOnChange: true);
                  config.AddEnvironmentVariables();
               })
               .ConfigureWebHostDefaults(webBuilder =>
               {
                  webBuilder.UseStartup<Startup>();
               });
   }
    }
