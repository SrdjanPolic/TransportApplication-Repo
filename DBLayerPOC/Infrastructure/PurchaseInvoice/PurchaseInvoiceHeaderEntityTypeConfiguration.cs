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
            builder.Property(x => x.PostingDate).HasColumnName("PostingDate").HasDefaultValue(DateTime.Now);
            builder.Property(x => x.ExternalReferenceNo).HasColumnName("ExternalReferenceNo").HasMaxLength(50);
            builder.Property(x => x.DueDate).HasColumnName("DueDate").HasDefaultValue(DateTime.Now);
            builder.Property(x => x.TotalAmount).HasColumnName("TotalAmount").HasDefaultValue(0);
            builder.Property(x => x.Paid).HasColumnName("Paid").HasDefaultValue(false);
            builder.Property(x => x.Invoiced).HasColumnName("Invoiced").HasDefaultValue(false);
            builder.Property(x => x.CreditMemo).HasColumnName("CreditMemo").HasDefaultValue(false);
            builder.Property(x => x.PaymentDate).HasColumnName("PaymentDate").IsRequired(false);

            builder.Metadata.FindNavigation(nameof(PurchaseInvoiceHeader.Lines)).SetPropertyAccessMode(PropertyAccessMode.Field);
            builder.HasMany(x => x.Lines).WithOne(b => b.Header).HasForeignKey(b => b.PurchaseHeaderId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
