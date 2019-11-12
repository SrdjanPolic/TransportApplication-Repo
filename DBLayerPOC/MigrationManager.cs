using DBLayerPOC.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DBLayerPOC
{
    public static class MigrationManager
    {
        public static IWebHost MigrateDatabase(this IWebHost webHost)
        {
            using (var scope = webHost.Services.CreateScope())
            {
                using (var appContext = scope.ServiceProvider.GetRequiredService<AppDbContext>())
                {
                    //try
                    //{
                    //    appContext.Database.Migrate();
                    //}
                    //catch (Exception ex)
                    //{
                    //    //Log errors or do anything you think it's needed
                    //    throw;
                    //}
                }
            }

            return webHost;
        }
    }
}
