using DBLayerPOC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBLayerPOC.Infrastructure
{
    public class CustomerEntityTypeConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(x => x.Name).HasColumnName("Name").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Address).HasColumnName("Address").HasMaxLength(50).IsRequired();
            builder.Property(x => x.City).HasColumnName("City").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Country).HasColumnName("Country").HasMaxLength(50).IsRequired();
            builder.Property(x => x.PhoneNo).HasColumnName("PhoneNo").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Email).HasColumnName("Email").HasMaxLength(50).IsRequired();
            builder.Property(x => x.VatGroup).HasColumnName("VatGroup").IsRequired();
        }
    }
}
