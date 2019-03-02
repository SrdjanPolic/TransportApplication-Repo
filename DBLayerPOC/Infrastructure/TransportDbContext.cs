using DBLayerPOC.Models;
using Microsoft.EntityFrameworkCore;


namespace DBLayerPOC.Infrastructure
{
    public class TransportDbContext : DbContext
    {
        public TransportDbContext(DbContextOptions<TransportDbContext> options) : base(options)
        {
        }

        public virtual DbSet<TransportOffer> TransportOffers { get; set; }
        public virtual DbSet<TransportRoute> TransportRoutes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("TransportDb");
            modelBuilder.ApplyConfiguration(new TransportOfferEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TransportRouteEntityTypeConfiguration());
        }
    }
}
