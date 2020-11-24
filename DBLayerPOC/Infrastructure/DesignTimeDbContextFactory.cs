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
            var connectionString = "Data Source=mssql101.windows.loopia.com;Initial Catalog=E002271;Integrated Security=False;User ID=E002271a;Password=Axesys174500;Connect Timeout=15;Encrypt=False;Packet Size=4096";

            builder.UseSqlServer(connectionString);

            var dbContext = (AppDbContext)Activator.CreateInstance(typeof(AppDbContext), builder.Options);

            return dbContext;
            // return new QuoteHeaderDbContext(builder.Options);
        }
    }
}



