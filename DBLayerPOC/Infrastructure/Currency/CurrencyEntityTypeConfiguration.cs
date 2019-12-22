using DBLayerPOC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBLayerPOC.Infrastructure
{
    public class CurrencyEntityTypeConfiguration : IEntityTypeConfiguration<Currency>
    {
        public void Configure(EntityTypeBuilder<Currency> builder)
        {
            builder.ToTable("Currency");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(x => x.Code).HasColumnName("Code").HasMaxLength(10).IsRequired();
            builder.Property(x => x.Name).HasColumnName("Name").HasMaxLength(50).IsRequired();

            builder.Property(x => x.LastChangeDateTime).HasColumnName("LastChangeDateTime").HasDefaultValue(null);
            builder.Property(x => x.LastChangeUserId).HasColumnName("LastChangeUserId").HasDefaultValue(null);

            builder.Metadata.FindNavigation(nameof(Currency.CurrencyExchangeRates))
                .SetPropertyAccessMode(PropertyAccessMode.Field);

            builder.HasMany(x => x.CurrencyExchangeRates).WithOne(c => c.Currency)
                .HasForeignKey(e => e.CurrencyId);
        }
    }
}
