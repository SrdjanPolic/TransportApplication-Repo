using DBLayerPOC.Infrastructure.PurchaseInvoice;
using DBLayerPOC.Infrastructure.Vendor;
using DBLayerPOC.Models;
using Microsoft.EntityFrameworkCore;


namespace DBLayerPOC.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


        public virtual DbSet<QuoteHeader> QuoteHeaders { get; set; }
        public virtual DbSet<QuoteLine> QuoteLines { get; set; }

        public virtual DbSet<Customer> Customers { get; set; }

        public virtual DbSet<Vendor.Vendor> Vendors { get; set; }

        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<CurrencyExchangeRate> CurrencyExchangeRates { get; set; }

        public virtual DbSet<PurchaseInvoiceHeader> PurchaseInvoiceHeaders { get; set; }
        public virtual DbSet<PurchaseInvoiceLine> PurchaseInvoiceLines { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("TransportDbNew");
            //QuoteHeader and QuoteLine
            modelBuilder.ApplyConfiguration(new QuoteHeaderEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new QuoteLineEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerEntityTypeConfiguration());

            //Customer
            modelBuilder.ApplyConfiguration(new CustomerEntityTypeConfiguration());

            //Currency
            modelBuilder.ApplyConfiguration(new CurrencyEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CurrencyExchangeRateEntityTypeConfiguration());

            //Vendor
            modelBuilder.ApplyConfiguration(new VendorEntityTypeConfiguration());

            //Purchase Invoice
            modelBuilder.ApplyConfiguration(new PurchaseInvoiceHeaderEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PurchaseInvoiceLineEntityTypeConfiguration());
        }
    }
}
