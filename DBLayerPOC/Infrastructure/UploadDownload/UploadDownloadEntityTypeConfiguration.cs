using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBLayerPOC.Infrastructure.UploadDownload
{
    public class UploadDownloadEntityTypeConfiguration : IEntityTypeConfiguration<FileMetadata>
    {
        public void Configure(EntityTypeBuilder<FileMetadata> builder)
        {
            builder.ToTable("UploadDownload");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(x => x.Discriminator).HasColumnName("Discriminator").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Extension).HasColumnName("Extension").HasMaxLength(50).IsRequired();
            builder.Property(x => x.FileName).HasColumnName("Filename").HasMaxLength(50).IsRequired();
            builder.Property(x => x.GeneratedFileName).HasColumnName("GeneratedFileName").HasMaxLength(50).IsRequired();
            builder.Property(x => x.DocumentId).HasColumnName("DocumentId").HasDefaultValue(null);
        }
    }
}
