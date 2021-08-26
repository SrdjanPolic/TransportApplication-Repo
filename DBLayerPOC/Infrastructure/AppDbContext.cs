using DBLayerPOC.Infrastructure.Driver;
using DBLayerPOC.Infrastructure.Login;
using DBLayerPOC.Infrastructure.PurchaseInvoice;
using DBLayerPOC.Infrastructure.SalesInvoice;
using DBLayerPOC.Infrastructure.Settings;
using DBLayerPOC.Infrastructure.UploadDownload;
using DBLayerPOC.Infrastructure.Vehicle;
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

        public virtual DbSet<Customer> Customers { get; set; }

        public virtual DbSet<Vendor.Vendor> Vendors { get; set; }

        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<CurrencyExchangeRate> CurrencyExchangeRates { get; set; }

        public virtual DbSet<PurchaseInvoiceHeader> PurchaseInvoiceHeaders { get; set; }
        public virtual DbSet<PurchaseInvoiceLine> PurchaseInvoiceLines { get; set; }

        public virtual DbSet<SalesInvoiceHeader> SalesInvoiceHeaders { get; set; }
        public virtual DbSet<SalesInvoiceLine> SalesInvoiceLines { get; set; }

        public virtual DbSet<Settings.Settings> SettingsTable { get; set; }

        public virtual DbSet<Driver.Driver> Drivers { get; set; }

        public virtual DbSet<Vehicle.Vehicle> Vehicles { get; set; }

        public virtual DbSet<LoginModel> Login { get; set; }

        public virtual DbSet<UploadDownload.FileMetadata> UploadsDownloads { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("TransportDbNew");

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

            //Sales Invoice
            modelBuilder.ApplyConfiguration(new SalesInvoiceHeaderEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new SalesInvoiceLineEntityTypeConfiguration());

            //Settings
            modelBuilder.ApplyConfiguration(new SettingsEntityTypeConfiguration());

            //Driver
            modelBuilder.ApplyConfiguration(new DriverEntityTypeConfiguration());

            //Vehicle
            modelBuilder.ApplyConfiguration(new VehicleEntityTypeConfiguration());

            //Login
            modelBuilder.ApplyConfiguration(new LoginModelEntityTypeConfiguration());

            //UploadDownload
            modelBuilder.ApplyConfiguration(new UploadDownloadEntityTypeConfiguration());
        }
    }
}
