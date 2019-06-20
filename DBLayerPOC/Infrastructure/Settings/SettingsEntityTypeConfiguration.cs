using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBLayerPOC.Infrastructure.Settings
{
    public class SettingsEntityTypeConfiguration : IEntityTypeConfiguration<Settings>
    {
        public void Configure(EntityTypeBuilder<Settings> builder)
        {
            builder.ToTable("Settings");
            builder.HasKey("Id");

            builder.Property(x => x.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(x => x.ObjectName).HasColumnName("ObjectName").IsRequired();
            builder.Property(x => x.Prefix).HasColumnName("Prefix").IsRequired();
            builder.Property(x => x.Year).HasColumnName("Year").IsRequired();
            builder.Property(x => x.LastUsedNumber).HasColumnName("LastUsedNumber").IsRequired();
        }
    }
}
