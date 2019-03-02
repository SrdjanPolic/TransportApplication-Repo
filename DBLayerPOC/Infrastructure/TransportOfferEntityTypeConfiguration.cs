using DBLayerPOC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBLayerPOC.Infrastructure
{
    internal class TransportOfferEntityTypeConfiguration : IEntityTypeConfiguration<TransportOffer>
    {
        public void Configure(EntityTypeBuilder<TransportOffer> builder)
        {
            builder.ToTable("TransportOffers");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(x => x.Header).HasColumnName("Header").HasMaxLength(50).IsRequired();

            builder.Metadata.FindNavigation(nameof(TransportOffer.TransportRoutes)).SetPropertyAccessMode(PropertyAccessMode.Field);
            builder.HasMany(x => x.TransportRoutes).WithOne(b => b.TransportOffer).HasForeignKey(b => b.TransportOfferId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
