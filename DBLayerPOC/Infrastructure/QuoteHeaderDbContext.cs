using DBLayerPOC.Models;
using Microsoft.EntityFrameworkCore;


namespace DBLayerPOC.Infrastructure
{
    public class QuoteHeaderDbContext : DbContext
    {
        public QuoteHeaderDbContext(DbContextOptions<QuoteHeaderDbContext> options) : base(options)
        {
        }

        public virtual DbSet<QuoteHeader> TransportOffers { get; set; }
        public virtual DbSet<QuoteLine> TransportRoutes { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("TransportDb");
            modelBuilder.ApplyConfiguration(new QuoteHeaderEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new QuoteLineEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerEntityTypeConfiguration());
        }
    }
}
