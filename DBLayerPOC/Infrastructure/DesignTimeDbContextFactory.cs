using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


namespace DBLayerPOC.Infrastructure
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<TransportDbContext>
    {
        TransportDbContext IDesignTimeDbContextFactory<TransportDbContext>.CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<TransportDbContext>();

            //var connectionString = Configuration.GetConnectionString("ConnectionString");
            var connectionString = "server=(localdb)\\MSSQLLocalDB;Database=TransportDb;Integrated Security=true;MultipleActiveResultSets=true;";

            builder.UseSqlServer(connectionString);

            return new TransportDbContext(builder.Options);
        }
    }
}
