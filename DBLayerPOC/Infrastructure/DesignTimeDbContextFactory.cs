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
            var connectionString = "server=.\\SQLEXPRESS;Database=TransportDbNew;Integrated Security=true;MultipleActiveResultSets=true;";
            //var connectionString = "Server=tcp:denue-sql.database.windows.net,1433;Initial Catalog=TransportDBNew;Persist Security Info=False;User ID=adragojevic;Password=Axesys1745;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            builder.UseSqlServer(connectionString);

            var dbContext = (AppDbContext)Activator.CreateInstance(typeof(AppDbContext), builder.Options);

            return dbContext;
            // return new QuoteHeaderDbContext(builder.Options);
        }
    }
}



