using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBLayerPOC.Infrastructure.Vehicle
{
    public class VehicleEntityTypeConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.ToTable("Vehicle");
            builder.HasKey("Id");

            builder.Property(x => x.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(x => x.MaxWeight).HasColumnName("MaxWeight").HasDefaultValue(0);
            builder.Property(x => x.RegistrationNumber).HasColumnName("RegistrationNumber").HasMaxLength(50).IsRequired();
            builder.Property(x => x.ChassisNumber).HasColumnName("ChassisNumber").HasMaxLength(50).IsRequired();
            builder.Property(x => x.FuelType).HasColumnName("FuelType").HasMaxLength(50).IsRequired();
            builder.Property(x => x.VechicleType).HasColumnName("VechicleType").HasMaxLength(50).IsRequired();
            builder.Property(x => x.IsInactive).HasColumnName("IsInactive").HasDefaultValue(false);

            builder.Metadata.FindNavigation(nameof(Vehicle.SalesInvoiceHeaders)).SetPropertyAccessMode(PropertyAccessMode.Field);
            builder.HasMany(x => x.SalesInvoiceHeaders).WithOne(b => b.Vehicle).HasForeignKey(b => b.VehicleId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
