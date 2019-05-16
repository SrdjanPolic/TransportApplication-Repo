using DBLayerPOC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DBLayerPOC.Infrastructure.Vendor
{
    public class VendorEntityTypeConfiguration : IEntityTypeConfiguration<Vendor>
    {
        public void Configure(EntityTypeBuilder<Vendor> builder)
        {
            builder.ToTable("Vendor");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(x => x.Name).HasColumnName("Name").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Address).HasColumnName("Address").HasMaxLength(50).IsRequired();
            builder.Property(x => x.City).HasColumnName("City").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Country).HasColumnName("Country").HasMaxLength(50).IsRequired();
            builder.Property(x => x.PhoneNo).HasColumnName("PhoneNo").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Email).HasColumnName("Email").HasMaxLength(50).IsRequired();
            builder.Property(x => x.PaymentTermsCode).HasColumnName("PaymentTermsCode").HasMaxLength(50).IsRequired();
            builder.Property(x => x.VatGroup).HasColumnName("VatGroup").IsRequired();
            builder.Property(x => x.VatNumber).HasColumnName("VatNumber");
            builder.Property(x => x.IsInactive).HasColumnName("IsInactive").HasDefaultValue(false);
            builder.Property(x => x.LastChangeDate).HasColumnName("LastChangeDate").HasDefaultValue(DateTime.Now);
        }
    }
}
