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
    [Migration("20190615220826_PurchaceInvoiceHeaderTotalAmountLocalAdded")]
    partial class PurchaceInvoiceHeaderTotalAmountLocalAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("TransportDbNew")
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .HasDefaultValue(new DateTime(2019, 6, 16, 0, 8, 25, 812, DateTimeKind.Local).AddTicks(6063));

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

                    b.Property<DateTime>("PaymentDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PaymentDate")
                        .HasDefaultValue(new DateTime(2019, 6, 16, 0, 8, 25, 813, DateTimeKind.Local).AddTicks(3338));

                    b.Property<DateTime>("PostingDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PostingDate")
                        .HasDefaultValue(new DateTime(2019, 6, 16, 0, 8, 25, 812, DateTimeKind.Local).AddTicks(5242));

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
                        .HasDefaultValue(new DateTime(2019, 6, 16, 0, 8, 25, 806, DateTimeKind.Local).AddTicks(7699));

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
                        .HasDefaultValue(new DateTime(2019, 6, 16, 0, 8, 25, 792, DateTimeKind.Local).AddTicks(1231));

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

            modelBuilder.Entity("DBLayerPOC.Models.QuoteHeader", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CurrencyCode")
                        .HasColumnName("CurrencyCode")
                        .HasMaxLength(10);

                    b.Property<float>("CurrencyExchangeRate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CurrencyExchangeRate")
                        .HasDefaultValue(1f);

                    b.Property<int>("CustomerId")
                        .HasColumnName("CustomerId");

                    b.Property<string>("Header")
                        .IsRequired()
                        .HasColumnName("Header")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("QuoteHeader");
                });

            modelBuilder.Entity("DBLayerPOC.Models.QuoteLine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("From")
                        .IsRequired()
                        .HasColumnName("From")
                        .HasMaxLength(256);

                    b.Property<int>("QuoteHeaderId");

                    b.Property<string>("To")
                        .IsRequired()
                        .HasColumnName("To")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("QuoteHeaderId");

                    b.ToTable("QuoteLine");
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

            modelBuilder.Entity("DBLayerPOC.Models.CurrencyExchangeRate", b =>
                {
                    b.HasOne("DBLayerPOC.Models.Currency", "Currency")
                        .WithMany("CurrencyExchangeRates")
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DBLayerPOC.Models.QuoteHeader", b =>
                {
                    b.HasOne("DBLayerPOC.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DBLayerPOC.Models.QuoteLine", b =>
                {
                    b.HasOne("DBLayerPOC.Models.QuoteHeader", "QuoteHeader")
                        .WithMany("QuoteLines")
                        .HasForeignKey("QuoteHeaderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
