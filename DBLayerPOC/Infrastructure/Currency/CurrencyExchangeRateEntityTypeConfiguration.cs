using DBLayerPOC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBLayerPOC.Infrastructure
{
    public class CurrencyExchangeRateEntityTypeConfiguration : IEntityTypeConfiguration<CurrencyExchangeRate>
    {
        public void Configure(EntityTypeBuilder<CurrencyExchangeRate> builder)
        {
            builder.ToTable("CurrencyExchangeRate");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(x => x.CurrencyId).HasColumnName("CurrencyId").IsRequired();
            builder.Property(x => x.StartingDate).HasColumnName("StartingDate").IsRequired();
            builder.Property(x => x.ExchangeRateAmount).HasColumnName("ExchangeRateAmount").HasDefaultValue(1);
        }
    }
}
