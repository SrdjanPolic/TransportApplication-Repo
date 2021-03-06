﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBLayerPOC.Infrastructure.SalesInvoice
{
    public class SalesInvoiceHeaderEntityTypeConfiguration : IEntityTypeConfiguration<SalesInvoiceHeader>
    {
        public void Configure(EntityTypeBuilder<SalesInvoiceHeader> builder)
        {
            builder.ToTable("SalesInvoiceHeader");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(x => x.InvoiceNo).HasColumnName("InvoiceNo").HasMaxLength(50).IsRequired();
            builder.Property(x => x.PostingDate).HasColumnName("PostingDate").HasDefaultValue(DateTime.Now);
            builder.Property(x => x.ExternalReferenceNo).HasColumnName("ExternalReferenceNo").HasMaxLength(50);
            builder.Property(x => x.DueDate).HasColumnName("DueDate").HasDefaultValue(DateTime.Now);
            builder.Property(x => x.OrderDate).HasColumnName("OrderDate").HasDefaultValue(DateTime.Now);
            builder.Property(x => x.TotalAmount).HasColumnName("TotalAmount").HasDefaultValue(0F);
            builder.Property(x => x.TotalAmountLocal).HasColumnName("TotalAmountLocal").HasDefaultValue(0F);
            builder.Property(x => x.CalculatonExchangeRate).HasColumnName("CalculatonExchangeRate").HasDefaultValue(0F);
            builder.Property(x => x.Paid).HasColumnName("Paid").HasDefaultValue(0);
            builder.Property(x => x.Invoiced).HasColumnName("Invoiced").HasDefaultValue(0);
            builder.Property(x => x.CreditMemo).HasColumnName("CreditMemo").HasDefaultValue(0);
            builder.Property(x => x.PaymentDate).HasColumnName("PaymentDate").HasDefaultValue(DateTime.Now);
            builder.Property(x => x.SalesPerson).HasColumnName("SalesPerson").HasMaxLength(250);
            builder.Property(x => x.CommodityType).HasColumnName("CommodityType").HasMaxLength(250);
            builder.Property(x => x.NumberOfPallets).HasColumnName("NumberOfPallets").HasDefaultValue(0D);
            builder.Property(x => x.NumberOfPalletsPlaces).HasColumnName("NumberOfPalletsPlaces").HasDefaultValue(0D);
            builder.Property(x => x.BruttoWeight).HasColumnName("BruttoWeight").HasDefaultValue(0F);
            builder.Property(x => x.AdrNeeded).HasColumnName("AdrNeeded").HasDefaultValue(0);
            builder.Property(x => x.Remarks).HasColumnName("Remarks").HasMaxLength(50);
            builder.Property(x => x.RouteDistance).HasColumnName("RouteDistance").HasDefaultValue(0F);
            builder.Property(x => x.LoadRepresentative).HasColumnName("LoadRepresentative").HasMaxLength(250);
            builder.Property(x => x.PricePerKm).HasColumnName("PricePerKm").HasDefaultValue(0F);
            builder.Property(x => x.CrmNumber).HasColumnName("CrmNumber").HasMaxLength(50);
            builder.Property(x => x.PartiallyPayed).HasColumnName("PartiallyPayed").HasDefaultValue(0F);
            //builder.Property(x => x.DriverId).HasColumnName("DriverId");
            //builder.Property(x => x.VehicleId).HasColumnName("VehicleId");
            builder.Property(x => x.DriverName).HasColumnName("DriverName");
            builder.Property(x => x.VechicleRegistration).HasColumnName("VechicleRegistration");
            builder.Property(x => x.LoadDate).HasColumnName("LoadDate").HasDefaultValue(DateTime.Now).IsRequired(false);
            builder.Property(x => x.UnloadDate).HasColumnName("UnloadDate").HasDefaultValue(DateTime.Now).IsRequired(false);
            builder.Property(x => x.LoadAddress).HasColumnName("LoadAddress").HasMaxLength(250);
            builder.Property(x => x.UnloadAddress).HasColumnName("UnloadAddress").HasMaxLength(250);

            builder.Property(x => x.TaxLawText).HasColumnName("TaxLawText").HasMaxLength(5000);
            builder.Property(x => x.OwnTransport).HasColumnName("OwnTransport").HasDefaultValue(0);

            builder.Property(x => x.CheckIssueDate).HasColumnName("CheckIssueDate").HasDefaultValue(DateTime.Now);
            builder.Property(x => x.ClienReceiptDocDate).HasColumnName("ClienReceiptDocDate").HasDefaultValue(DateTime.Now);

            builder.Property(x => x.TravelOrder).HasColumnName("TravelOrder").HasMaxLength(250);

            builder.Property(x => x.LastChangeDateTime).HasColumnName("LastChangeDateTime").HasDefaultValue(null);
            builder.Property(x => x.LastChangeUserId).HasColumnName("LastChangeUserId").HasDefaultValue(null);

            builder.Metadata.FindNavigation(nameof(SalesInvoiceHeader.Lines)).SetPropertyAccessMode(PropertyAccessMode.Field);
            builder.HasMany(x => x.Lines).WithOne(b => b.Header).HasForeignKey(b => b.SalesHeaderId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
