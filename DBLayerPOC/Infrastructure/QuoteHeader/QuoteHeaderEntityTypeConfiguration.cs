using DBLayerPOC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBLayerPOC.Infrastructure
{
    internal class QuoteHeaderEntityTypeConfiguration : IEntityTypeConfiguration<QuoteHeader>
    {
        public void Configure(EntityTypeBuilder<QuoteHeader> builder)
        {
            builder.ToTable("QuoteHeader");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(x => x.Header).HasColumnName("Header").HasMaxLength(50).IsRequired();
            builder.Property(x => x.CustomerId).HasColumnName("CustomerId").IsRequired();
            builder.Property(x => x.CurrencyCode).HasColumnName("CurrencyCode").HasMaxLength(10);
            builder.Property(x => x.CurrencyExchangeRate).HasColumnName("CurrencyExchangeRate").HasDefaultValue(1);
                

            builder.Metadata.FindNavigation(nameof(QuoteHeader.QuoteLines)).SetPropertyAccessMode(PropertyAccessMode.Field);
            builder.HasMany(x => x.QuoteLines).WithOne(b => b.QuoteHeader).HasForeignKey(b => b.QuoteHeaderId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
