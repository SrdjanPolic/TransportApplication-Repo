using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBLayerPOC.Infrastructure.UploadDownload
{
    public class FileMetadataEntityTypeConfiguration : IEntityTypeConfiguration<FileMetadata>
    {
        public void Configure(EntityTypeBuilder<FileMetadata> builder)
        {
            builder.ToTable("UploadDownload");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(x => x.Discriminator).HasColumnName("Discriminator").IsRequired();
            builder.Property(x => x.Extension).HasColumnName("Extension").IsRequired();
            builder.Property(x => x.FileName).HasColumnName("Filename").IsRequired();
            builder.Property(x => x.FilePath).HasColumnName("FilePath").IsRequired();
            builder.Property(x => x.GeneratedFileName).HasColumnName("GeneratedFileName").IsRequired();
            builder.Property(x => x.DocumentId).HasColumnName("DocumentId").HasDefaultValue(null);
        }
    }
}
