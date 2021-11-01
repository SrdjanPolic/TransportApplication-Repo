using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DBLayerPOC.Infrastructure
{
    public class DesignTimeDbContextFactoryBase<T> : IDesignTimeDbContextFactory<T> where T : DbContext
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
            var connectionString = "server=.\\SQLEXPRESS;Database=e001800;Integrated Security=true;MultipleActiveResultSets=true;";

            builder.UseSqlServer(connectionString);

            var dbContext = (T)Activator.CreateInstance(typeof(T), builder.Options);

            return dbContext;
        }
    }
}
