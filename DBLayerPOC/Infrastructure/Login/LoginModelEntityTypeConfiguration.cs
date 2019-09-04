using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBLayerPOC.Infrastructure.Login
{
    internal class LoginModelEntityTypeConfiguration : IEntityTypeConfiguration<LoginModel>
    {
        public void Configure(EntityTypeBuilder<LoginModel> builder)
        {
            builder.ToTable("User");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Username).HasColumnName("Username").HasMaxLength(50);
            builder.Property(x => x.Password).HasColumnName("Password").HasMaxLength(50);
        }
    }
}
