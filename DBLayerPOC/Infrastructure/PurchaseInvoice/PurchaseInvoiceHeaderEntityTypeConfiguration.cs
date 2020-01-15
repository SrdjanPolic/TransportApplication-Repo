using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBLayerPOC.Infrastructure.PurchaseInvoice
{
    internal class PurchaseInvoiceHeaderEntityTypeConfiguration : IEntityTypeConfiguration<PurchaseInvoiceHeader>
    {
        public void Configure(EntityTypeBuilder<PurchaseInvoiceHeader> builder)
        {
            builder.ToTable("PurchaseInvoiceHeader");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(x => x.InvoiceNo).HasColumnName("InvoiceNo").HasMaxLength(50).IsRequired();
            builder.Property(x => x.SupplierInvoiceNo).HasColumnName("SupplierInvoiceNo").HasMaxLength(50).IsRequired();
            builder.Property(x => x.PostingDate).HasColumnName("PostingDate").HasDefaultValue(DateTime.Now);
            builder.Property(x => x.ExternalReferenceNo).HasColumnName("ExternalReferenceNo").HasMaxLength(50);
            builder.Property(x => x.DueDate).HasColumnName("DueDate").HasDefaultValue(DateTime.Now);
            builder.Property(x => x.TotalAmount).HasColumnName("TotalAmount").HasDefaultValue(0F);
            builder.Property(x => x.TotalAmountLocal).HasColumnName("TotalAmountLocal").HasDefaultValue(0F);
            builder.Property(x => x.Paid).HasColumnName("Paid").HasDefaultValue(0);
            builder.Property(x => x.Invoiced).HasColumnName("Invoiced").HasDefaultValue(0);
            builder.Property(x => x.CreditMemo).HasColumnName("CreditMemo").HasDefaultValue(0);
            builder.Property(x => x.PaymentDate).HasColumnName("PaymentDate").HasDefaultValue(DateTime.Now);
            builder.Property(x => x.PurchaseSupplierNumber).HasColumnName("PurchaseSupplierNumber").HasMaxLength(50);
            builder.Property(x => x.PartiallyPayed).HasColumnName("PartiallyPayed").HasDefaultValue(0);

            builder.Property(x => x.LastChangeDateTime).HasColumnName("LastChangeDateTime").HasDefaultValue(null);
            builder.Property(x => x.LastChangeUserId).HasColumnName("LastChangeUserId").HasDefaultValue(null);

            builder.Metadata.FindNavigation(nameof(PurchaseInvoiceHeader.Lines)).SetPropertyAccessMode(PropertyAccessMode.Field);
            builder.HasMany(x => x.Lines).WithOne(b => b.Header).HasForeignKey(b => b.PurchaseHeaderId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
