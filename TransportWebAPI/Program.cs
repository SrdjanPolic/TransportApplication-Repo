using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Autofac.Extensions.DependencyInjection;
using DBLayerPOC;
using DBLayerPOC.Infrastructure;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using TransportWebAPI.Controllers.Upload;

namespace TransportWebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args)
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureWebHostDefaults(webHostBuilder =>
                {
                    webHostBuilder
                      .UseContentRoot(Directory.GetCurrentDirectory())
                      .UseIISIntegration();
                }).Build().MigrateDatabase();
            RunSeeding(host);
            RunCreateUploadFolderPathAandStoreToDatabase(host);

            host.Run();
        }

        private static void RunSeeding(IHost host)
        {
            var seeder = host.Services.GetService<Seeder>();
            seeder.Seed();
        }

        private static void RunCreateUploadFolderPathAandStoreToDatabase(IHost host)
        {
            var directoryCreator = host.Services.GetService<UploadDirectoryService>();
            directoryCreator.CreateSettingsDatabaseEntriesForUploadDownloadIfNotExists();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
         Host.CreateDefaultBuilder(args)
             .ConfigureWebHostDefaults(webBuilder =>
             {
                 webBuilder.UseStartup<Startup>();
             });


        private static void SetupConfiguration(WebHostBuilderContext ctx, IConfigurationBuilder builder)
        {
            //Remove default config options
            builder.Sources.Clear();

            builder.AddJsonFile("config.json", false, true);
        }
    }
}
