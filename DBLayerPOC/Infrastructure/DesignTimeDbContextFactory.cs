using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


namespace DBLayerPOC.Infrastructure
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<QuoteHeaderDbContext>
    {
        QuoteHeaderDbContext IDesignTimeDbContextFactory<QuoteHeaderDbContext>.CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<QuoteHeaderDbContext>();

            //var connectionString = Configuration.GetConnectionString("ConnectionString");
            var connectionString = "server=(localdb)\\MSSQLLocalDB;Database=TransportDb;Integrated Security=true;MultipleActiveResultSets=true;";

            builder.UseSqlServer(connectionString);

            return new QuoteHeaderDbContext(builder.Options);
        }
    }
}
