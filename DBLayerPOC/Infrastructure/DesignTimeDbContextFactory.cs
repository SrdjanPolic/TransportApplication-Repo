using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DBLayerPOC.Infrastructure
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppDbContext> 
    {
        protected readonly IConfiguration Configuration;

        public DesignTimeDbContextFactory()
        {

        }
        public DesignTimeDbContextFactory(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public AppDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("config.json")
           .Build();

            var builder = new DbContextOptionsBuilder<AppDbContext>();

            //var connectionString = Configuration.GetConnectionString("ConnectionString");
            //var connectionString = configuration.GetConnectionString("ConnectionString");
             var connectionString = "server=localhost; port=3306; database=TransportDbNew; user=atomic; password=Jasammalislon1234!; Persist Security Info=False; Connect Timeout=300";

            //var connectionString = "server=localhost; database=test;Integrated Security=true;MultipleActiveResultSets=true;";
            var serverVersion = ServerVersion.FromString("8.0.27");
            builder.UseMySql(connectionString, serverVersion);

            var dbContext = (AppDbContext)Activator.CreateInstance(typeof(AppDbContext), new object[1] { configuration });

            return dbContext;
        }
    }
}
