﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBLayerPOC.Infrastructure.Driver
{
    public class DriverEntityTypeConfiguration : IEntityTypeConfiguration<Driver>
    {
        public void Configure(EntityTypeBuilder<Driver> builder)
        {
            builder.ToTable("Driver");
            builder.HasKey("Id");

            builder.Property(x => x.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(x => x.DriversLicenceNumber).HasColumnName("DriversLicenceNumber").HasMaxLength(50).IsRequired();
            builder.Property(x => x.DriversLicenceExpDate).HasColumnName("DriversLicenceExpDate").HasDefaultValue(DateTime.Now).IsRequired(true);
            builder.Property(x => x.Name).HasColumnName("Name").HasMaxLength(50).IsRequired();
            builder.Property(x => x.PersonalIdNummber).HasColumnName("PersonalIdNummber").HasMaxLength(50).IsRequired();
            builder.Property(x => x.PersonalIdExpDate).HasColumnName("PersonalIdExpDate").HasDefaultValue(DateTime.Now).IsRequired(true);
            builder.Property(x => x.PassNumber).HasColumnName("PassNumber").HasMaxLength(50).IsRequired();
            builder.Property(x => x.PassExpDate).HasColumnName("PassExpDate").HasDefaultValue(DateTime.Now).IsRequired(true);
            builder.Property(x => x.Address).HasColumnName("Address").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Remark).HasColumnName("Remark").HasMaxLength(250).IsRequired();
            builder.Property(x => x.IsInactive).HasColumnName("IsInactive").HasDefaultValue(false);

            builder.Property(x => x.LastChangeDateTime).HasColumnName("LastChangeDateTime").HasDefaultValue(null);
            builder.Property(x => x.LastChangeUserId).HasColumnName("LastChangeUserId").HasDefaultValue(null);

            //builder.Metadata.FindNavigation(nameof(Driver.SalesInvoiceHeaders)).SetPropertyAccessMode(PropertyAccessMode.Field);
            //builder.HasMany(x => x.SalesInvoiceHeaders).WithOne(b => b.Driver).HasForeignKey(b => b.DriverId)
            //    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
