﻿using DBLayerPOC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

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
            builder.Property(x => x.PersonalIdNumber).HasColumnName("PersonalIdNumber").HasMaxLength(50).HasDefaultValue(null);
            builder.Property(x => x.Country).HasColumnName("Country").HasMaxLength(50).IsRequired();
            builder.Property(x => x.PhoneNo).HasColumnName("PhoneNo").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Email).HasColumnName("Email").HasMaxLength(50).IsRequired();
            builder.Property(x => x.PaymentCurrency).HasColumnName("PaymentCurrency").IsRequired();
            builder.Property(x => x.VatNumber).HasColumnName("VatNumber");
            builder.Property(x => x.IsInactive).HasColumnName("IsInactive").HasDefaultValue(false);
            builder.Property(x => x.Note).HasColumnName("Note").HasMaxLength(500).HasDefaultValue(null);

            builder.Property(x => x.LastChangeDateTime).HasColumnName("LastChangeDateTime").HasDefaultValue(null);
            builder.Property(x => x.LastChangeUserId).HasColumnName("LastChangeUserId").HasDefaultValue(null);

            builder.Metadata.FindNavigation(nameof(Customer.SalesInvoiceHeaders)).SetPropertyAccessMode(PropertyAccessMode.Field);
            builder.HasMany(x => x.SalesInvoiceHeaders).WithOne(b => b.Customer).HasForeignKey(b => b.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
