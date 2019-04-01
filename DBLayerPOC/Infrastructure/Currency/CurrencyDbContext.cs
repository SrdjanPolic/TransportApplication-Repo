using DBLayerPOC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBLayerPOC.Infrastructure
{
    public class CurrencyDbContext : DbContext
    {
        public CurrencyDbContext(DbContextOptions<CurrencyDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<CurrencyExchangeRate> CurrencyExchangeRates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("TransportDb");

            modelBuilder.ApplyConfiguration(new CurrencyEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CurrencyExchangeRateEntityTypeConfiguration());
        }
    }
}
