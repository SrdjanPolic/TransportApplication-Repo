﻿using DBLayerPOC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBLayerPOC.Infrastructure
{
    internal class TransportRouteEntityTypeConfiguration : IEntityTypeConfiguration<TransportRoute>
    {
        public void Configure(EntityTypeBuilder<TransportRoute> builder)
        {
            builder.ToTable("TransportRoutes");
            builder.HasKey("Id");

            builder.Property(x => x.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(x => x.From).HasColumnName("From").HasMaxLength(256).IsRequired();
            builder.Property(x => x.To).HasColumnName("To").HasMaxLength(256).IsRequired();
        }
    }
}
