using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace DBLayerPOC.Infrastructure
{
    public class DesignTimeDbContextFactory<T> : IDesignTimeDbContextFactory<T> where T : DbContext
    {
        public T CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("config.json")
           .Build();

            var builder = new DbContextOptionsBuilder<T>();

            //var connectionString = Configuration.GetConnectionString("ConnectionString");
            //var connectionString = configuration.GetConnectionString("ConnectionString");
            var connectionString = "server=.\\SQLExpress;Database=TransportDb;Integrated Security=true;MultipleActiveResultSets=true;";

            builder.UseSqlServer(connectionString);

            var dbContext = (T)Activator.CreateInstance(typeof(T), builder.Options);

            return dbContext;
            // return new QuoteHeaderDbContext(builder.Options);
        }
    }
}



