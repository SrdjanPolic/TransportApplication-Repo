﻿// <auto-generated />
using DBLayerPOC.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DBLayerPOC.Migrations
{
    [DbContext(typeof(QuoteHeaderDbContext))]
    [Migration("20190303220216_CustomerTableAdded")]
    partial class CustomerTableAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("TransportDb")
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("DBLayerPOC.Models.QuoteHeader", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<string>("To")
                        .IsRequired()
                        .HasColumnName("To")
                        .HasMaxLength(256);

                    b.Property<int>("TransportOfferId");

                    b.HasKey("Id");

                    b.HasIndex("TransportOfferId");

                    b.ToTable("QuoteLine");
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
                    b.HasOne("DBLayerPOC.Models.QuoteHeader", "TransportOffer")
                        .WithMany("TransportRoutes")
                        .HasForeignKey("TransportOfferId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
