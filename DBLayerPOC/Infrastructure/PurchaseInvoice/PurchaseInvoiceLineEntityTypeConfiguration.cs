using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBLayerPOC.Infrastructure.PurchaseInvoice
{
    public class PurchaseInvoiceLineEntityTypeConfiguration : IEntityTypeConfiguration<PurchaseInvoiceLine>
    {
        public void Configure(EntityTypeBuilder<PurchaseInvoiceLine> builder)
        {
            builder.ToTable("PurchaseInvoiceLine");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(x => x.Quantity).HasColumnName("Quantity").HasDefaultValue(0);
            builder.Property(x => x.UnitPrice).HasColumnName("UnitPrice").HasDefaultValue(0);
            builder.Property(x => x.DiscountPercent).HasColumnName("DiscountPercent").HasDefaultValue(0);
            builder.Property(x => x.LineAmount).HasColumnName("LineAmount").HasDefaultValue(0);
            builder.Property(x => x.Remark).HasColumnName("Remark").HasMaxLength(250).IsRequired(false);
            builder.Property(x => x.Description).HasColumnName("Description").HasMaxLength(250).IsRequired(true);
            builder.Property(x => x.VatPercent).HasColumnName("VatPercent").IsRequired(true).HasDefaultValue(0);
            builder.Property(x => x.VehicleId).HasColumnName("VehicleId").IsRequired(false);

            builder.Property(x => x.LastChangeDateTime).HasColumnName("LastChangeDateTime").HasDefaultValue(null);
            builder.Property(x => x.LastChangeUserId).HasColumnName("LastChangeUserId").HasDefaultValue(null);
        }
    }
}
