﻿// <auto-generated />
using System;
using DBLayerPOC.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DBLayerPOC.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190709210213_DriverVehicleTablesAdded")]
    partial class DriverVehicleTablesAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("TransportDbNew")
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DBLayerPOC.Infrastructure.Driver.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnName("Address")
                        .HasMaxLength(50);

                    b.Property<DateTime>("DriversLicenceExpDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("DriversLicenceExpDate")
                        .HasDefaultValue(new DateTime(2019, 7, 9, 23, 2, 12, 946, DateTimeKind.Local).AddTicks(1399));

                    b.Property<string>("DriversLicenceNumber")
                        .IsRequired()
                        .HasColumnName("DriversLicenceNumber")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasMaxLength(50);

                    b.Property<DateTime>("PassExpDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PassExpDate")
                        .HasDefaultValue(new DateTime(2019, 7, 9, 23, 2, 12, 946, DateTimeKind.Local).AddTicks(3411));

                    b.Property<string>("PassNumber")
                        .IsRequired()
                        .HasColumnName("PassNumber")
                        .HasMaxLength(50);

                    b.Property<DateTime>("PersonalIdExpDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PersonalIdExpDate")
                        .HasDefaultValue(new DateTime(2019, 7, 9, 23, 2, 12, 946, DateTimeKind.Local).AddTicks(2680));

                    b.Property<string>("PersonalIdNummber")
                        .IsRequired()
                        .HasColumnName("PersonalIdNummber")
                        .HasMaxLength(50);

                    b.Property<string>("Remark")
                        .IsRequired()
                        .HasColumnName("Remark")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Driver");
                });

            modelBuilder.Entity("DBLayerPOC.Infrastructure.PurchaseInvoice.PurchaseInvoiceHeader", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("CreditMemo")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CreditMemo")
                        .HasDefaultValue(false);

                    b.Property<int>("CurrencyId");

                    b.Property<DateTime>("DueDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("DueDate")
                        .HasDefaultValue(new DateTime(2019, 7, 9, 23, 2, 12, 909, DateTimeKind.Local).AddTicks(1455));

                    b.Property<string>("ExternalReferenceNo")
                        .HasColumnName("ExternalReferenceNo")
                        .HasMaxLength(50);

                    b.Property<string>("InvoiceNo")
                        .IsRequired()
                        .HasColumnName("InvoiceNo")
                        .HasMaxLength(50);

                    b.Property<bool>("Invoiced")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Invoiced")
                        .HasDefaultValue(false);

                    b.Property<bool>("Paid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Paid")
                        .HasDefaultValue(false);

                    b.Property<bool>("PartiallyPayed")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PartiallyPayed")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("PaymentDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PaymentDate")
                        .HasDefaultValue(new DateTime(2019, 7, 9, 23, 2, 12, 909, DateTimeKind.Local).AddTicks(8405));

                    b.Property<DateTime>("PostingDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PostingDate")
                        .HasDefaultValue(new DateTime(2019, 7, 9, 23, 2, 12, 909, DateTimeKind.Local).AddTicks(535));

                    b.Property<string>("PurchaseSupplierNumber")
                        .HasColumnName("PurchaseSupplierNumber")
                        .HasMaxLength(50);

                    b.Property<float>("TotalAmount")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("TotalAmount")
                        .HasDefaultValue(0f);

                    b.Property<float>("TotalAmountLocal")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("TotalAmountLocal")
                        .HasDefaultValue(0f);

                    b.Property<int>("VendorId");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("VendorId");

                    b.ToTable("PurchaseInvoiceHeader");
                });

            modelBuilder.Entity("DBLayerPOC.Infrastructure.PurchaseInvoice.PurchaseInvoiceLine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("Description")
                        .HasMaxLength(250);

                    b.Property<float>("DiscountPercent")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("DiscountPercent")
                        .HasDefaultValue(0f);

                    b.Property<float>("LineAmount")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("LineAmount")
                        .HasDefaultValue(0f);

                    b.Property<int>("PurchaseHeaderId");

                    b.Property<int>("Quantity")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Quantity")
                        .HasDefaultValue(0);

                    b.Property<string>("Remark")
                        .HasColumnName("Remark")
                        .HasMaxLength(250);

                    b.Property<float>("UnitPrice")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UnitPrice")
                        .HasDefaultValue(0f);

                    b.Property<float>("VatPercent")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("VatPercent")
                        .HasDefaultValue(0f);

                    b.HasKey("Id");

                    b.HasIndex("PurchaseHeaderId");

                    b.ToTable("PurchaseInvoiceLine");
                });

            modelBuilder.Entity("DBLayerPOC.Infrastructure.SalesInvoice.SalesInvoiceHeader", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AdrNeeded")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AdrNeeded")
                        .HasDefaultValue(false);

                    b.Property<float>("BruttoWeight")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("BruttoWeight")
                        .HasDefaultValue(0f);

                    b.Property<string>("CommodityType")
                        .HasColumnName("CommodityType")
                        .HasMaxLength(250);

                    b.Property<bool>("CreditMemo")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CreditMemo")
                        .HasDefaultValue(false);

                    b.Property<string>("CrmNumber")
                        .HasColumnName("CrmNumber")
                        .HasMaxLength(50);

                    b.Property<int>("CurrencyId");

                    b.Property<int>("CustomerId");

                    b.Property<int?>("DriverId");

                    b.Property<DateTime>("DueDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("DueDate")
                        .HasDefaultValue(new DateTime(2019, 7, 9, 23, 2, 12, 927, DateTimeKind.Local).AddTicks(5097));

                    b.Property<string>("ExternalReferenceNo")
                        .HasColumnName("ExternalReferenceNo")
                        .HasMaxLength(50);

                    b.Property<string>("InvoiceNo")
                        .IsRequired()
                        .HasColumnName("InvoiceNo")
                        .HasMaxLength(50);

                    b.Property<bool>("Invoiced")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Invoiced")
                        .HasDefaultValue(false);

                    b.Property<string>("LoadRepresentative")
                        .HasColumnName("LoadRepresentative")
                        .HasMaxLength(250);

                    b.Property<double>("NumberOfPallets")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("NumberOfPallets")
                        .HasDefaultValue(0.0);

                    b.Property<double>("NumberOfPalletsPlaces")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("NumberOfPalletsPlaces")
                        .HasDefaultValue(0.0);

                    b.Property<DateTime>("OrderDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("OrderDate")
                        .HasDefaultValue(new DateTime(2019, 7, 9, 23, 2, 12, 927, DateTimeKind.Local).AddTicks(5643));

                    b.Property<bool>("Paid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Paid")
                        .HasDefaultValue(false);

                    b.Property<bool>("PartiallyPayed")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PartiallyPayed")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("PaymentDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PaymentDate")
                        .HasDefaultValue(new DateTime(2019, 7, 9, 23, 2, 12, 928, DateTimeKind.Local).AddTicks(3123));

                    b.Property<DateTime>("PostingDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PostingDate")
                        .HasDefaultValue(new DateTime(2019, 7, 9, 23, 2, 12, 927, DateTimeKind.Local).AddTicks(4161));

                    b.Property<float>("PricePerKm")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PricePerKm")
                        .HasDefaultValue(0f);

                    b.Property<string>("Remarks")
                        .HasColumnName("Remarks")
                        .HasMaxLength(50);

                    b.Property<float>("RouteDistance")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("RouteDistance")
                        .HasDefaultValue(0f);

                    b.Property<string>("SalesPerson")
                        .HasColumnName("SalesPerson")
                        .HasMaxLength(250);

                    b.Property<float>("TotalAmount")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("TotalAmount")
                        .HasDefaultValue(0f);

                    b.Property<float>("TotalAmountLocal")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("TotalAmountLocal")
                        .HasDefaultValue(0f);

                    b.Property<int?>("VehicleId");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("DriverId");

                    b.HasIndex("VehicleId");

                    b.ToTable("SalesInvoiceHeader");
                });

            modelBuilder.Entity("DBLayerPOC.Infrastructure.SalesInvoice.SalesInvoiceLine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("Description")
                        .HasMaxLength(250);

                    b.Property<float>("DiscountPercent")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("DiscountPercent")
                        .HasDefaultValue(0f);

                    b.Property<string>("ExportCustoms")
                        .HasColumnName("ExportCustoms")
                        .HasMaxLength(250);

                    b.Property<string>("ImportCustoms")
                        .HasColumnName("ImportCustoms")
                        .HasMaxLength(250);

                    b.Property<float>("LineAmount")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("LineAmount")
                        .HasDefaultValue(0f);

                    b.Property<string>("LoadAddress")
                        .HasColumnName("LoadAddress")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("LoadDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("LoadDate")
                        .HasDefaultValue(new DateTime(2019, 7, 9, 23, 2, 12, 937, DateTimeKind.Local).AddTicks(2914));

                    b.Property<int>("Quantity")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Quantity")
                        .HasDefaultValue(0);

                    b.Property<string>("Remark")
                        .HasColumnName("Remark")
                        .HasMaxLength(250);

                    b.Property<int>("SalesHeaderId");

                    b.Property<float>("UnitPrice")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UnitPrice")
                        .HasDefaultValue(0f);

                    b.Property<string>("UnloadAddress");

                    b.Property<DateTime?>("UnloadDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UnloadDate")
                        .HasDefaultValue(new DateTime(2019, 7, 9, 23, 2, 12, 937, DateTimeKind.Local).AddTicks(7709));

                    b.Property<float>("VatPercent")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("VatPercent")
                        .HasDefaultValue(0f);

                    b.HasKey("Id");

                    b.HasIndex("SalesHeaderId");

                    b.ToTable("SalesInvoiceLine");
                });

            modelBuilder.Entity("DBLayerPOC.Infrastructure.Settings.Settings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LastUsedNumber")
                        .HasColumnName("LastUsedNumber");

                    b.Property<string>("ObjectName")
                        .IsRequired()
                        .HasColumnName("ObjectName");

                    b.Property<string>("Prefix")
                        .IsRequired()
                        .HasColumnName("Prefix");

                    b.Property<int>("Year")
                        .HasColumnName("Year");

                    b.HasKey("Id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("DBLayerPOC.Infrastructure.Vehicle.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChassisNumber")
                        .IsRequired()
                        .HasColumnName("ChassisNumber")
                        .HasMaxLength(50);

                    b.Property<string>("FuelType")
                        .IsRequired()
                        .HasColumnName("FuelType")
                        .HasMaxLength(50);

                    b.Property<float>("MaxWeight")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("MaxWeight")
                        .HasDefaultValue(0f);

                    b.Property<string>("RegistrationNumber")
                        .IsRequired()
                        .HasColumnName("RegistrationNumber")
                        .HasMaxLength(50);

                    b.Property<string>("VechicleType")
                        .IsRequired()
                        .HasColumnName("VechicleType")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Vehicle");
                });

            modelBuilder.Entity("DBLayerPOC.Infrastructure.Vendor.Vendor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnName("Address")
                        .HasMaxLength(50);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnName("City")
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnName("Country")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("Email")
                        .HasMaxLength(50);

                    b.Property<bool?>("IsInactive")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IsInactive")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("LastChangeDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("LastChangeDate")
                        .HasDefaultValue(new DateTime(2019, 7, 9, 23, 2, 12, 902, DateTimeKind.Local).AddTicks(9592));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasMaxLength(50);

                    b.Property<string>("PaymentTermsCode")
                        .IsRequired()
                        .HasColumnName("PaymentTermsCode")
                        .HasMaxLength(50);

                    b.Property<string>("PhoneNo")
                        .IsRequired()
                        .HasColumnName("PhoneNo")
                        .HasMaxLength(50);

                    b.Property<int>("VatGroup")
                        .HasColumnName("VatGroup");

                    b.Property<string>("VatNumber")
                        .HasColumnName("VatNumber");

                    b.HasKey("Id");

                    b.ToTable("Vendor");
                });

            modelBuilder.Entity("DBLayerPOC.Models.Currency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnName("Code")
                        .HasMaxLength(10);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Currency");
                });

            modelBuilder.Entity("DBLayerPOC.Models.CurrencyExchangeRate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CurrencyId")
                        .HasColumnName("CurrencyId");

                    b.Property<float>("ExchangeRateAmount")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ExchangeRateAmount")
                        .HasDefaultValue(1f);

                    b.Property<DateTime>("StartingDate")
                        .HasColumnName("StartingDate");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyId");

                    b.ToTable("CurrencyExchangeRate");
                });

            modelBuilder.Entity("DBLayerPOC.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnName("Address")
                        .HasMaxLength(50);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnName("City")
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnName("Country")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("Email")
                        .HasMaxLength(50);

                    b.Property<bool>("IsInactive")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IsInactive")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("LastChangeDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("LastChangeDate")
                        .HasDefaultValue(new DateTime(2019, 7, 9, 23, 2, 12, 865, DateTimeKind.Local).AddTicks(5863));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasMaxLength(50);

                    b.Property<string>("PhoneNo")
                        .IsRequired()
                        .HasColumnName("PhoneNo")
                        .HasMaxLength(50);

                    b.Property<int>("VatGroup")
                        .HasColumnName("VatGroup");

                    b.Property<string>("VatNumber")
                        .HasColumnName("VatNumber");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("DBLayerPOC.Infrastructure.PurchaseInvoice.PurchaseInvoiceHeader", b =>
                {
                    b.HasOne("DBLayerPOC.Models.Currency", "Currency")
                        .WithMany("PurchaseInvoiceHeaders")
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DBLayerPOC.Infrastructure.Vendor.Vendor", "Vendor")
                        .WithMany("PurchaseInvoiceHeaders")
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DBLayerPOC.Infrastructure.PurchaseInvoice.PurchaseInvoiceLine", b =>
                {
                    b.HasOne("DBLayerPOC.Infrastructure.PurchaseInvoice.PurchaseInvoiceHeader", "Header")
                        .WithMany("Lines")
                        .HasForeignKey("PurchaseHeaderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DBLayerPOC.Infrastructure.SalesInvoice.SalesInvoiceHeader", b =>
                {
                    b.HasOne("DBLayerPOC.Models.Currency", "Currency")
                        .WithMany("SalesInvoiceHeaders")
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DBLayerPOC.Models.Customer", "Customer")
                        .WithMany("SalesInvoiceHeaders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DBLayerPOC.Infrastructure.Driver.Driver")
                        .WithMany("SalesInvoiceHeaders")
                        .HasForeignKey("DriverId");

                    b.HasOne("DBLayerPOC.Infrastructure.Vehicle.Vehicle")
                        .WithMany("SalesInvoiceHeaders")
                        .HasForeignKey("VehicleId");
                });

            modelBuilder.Entity("DBLayerPOC.Infrastructure.SalesInvoice.SalesInvoiceLine", b =>
                {
                    b.HasOne("DBLayerPOC.Infrastructure.SalesInvoice.SalesInvoiceHeader", "Header")
                        .WithMany("Lines")
                        .HasForeignKey("SalesHeaderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DBLayerPOC.Models.CurrencyExchangeRate", b =>
                {
                    b.HasOne("DBLayerPOC.Models.Currency", "Currency")
                        .WithMany("CurrencyExchangeRates")
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
