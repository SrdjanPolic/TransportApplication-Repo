using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace DBLayerPOC.Infrastructure
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("config.json")
           .Build();

            var builder = new DbContextOptionsBuilder<AppDbContext>();

            //var connectionString = Configuration.GetConnectionString("ConnectionString");
            //var connectionString = configuration.GetConnectionString("ConnectionString");
            var connectionString = "server=DENUE-AXD4094N1\\NAVDEMO;Database=TransportDbNew;Integrated Security=true;MultipleActiveResultSets=true;";

            builder.UseSqlServer(connectionString);

            var dbContext = (AppDbContext)Activator.CreateInstance(typeof(AppDbContext), builder.Options);

            return dbContext;
            // return new QuoteHeaderDbContext(builder.Options);
        }
    }
}



