using AnhNH.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnhNH.Data.Configurations
{
    public class ContentConfiguration : IEntityTypeConfiguration<Content>
    {
        public void Configure(EntityTypeBuilder<Content> builder)
        {
            builder.ToTable("Contents");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).HasMaxLength(256).IsRequired();
            builder.Property(x => x.ChapterId).IsRequired();
            builder.Property(x => x.BaseImage).HasColumnType("text").IsRequired();
            builder.Property(x => x.CreatedAt).HasColumnType("datetime");
            builder.Property(x => x.UpdatedAt).HasColumnType("datetime");
            builder.Property(x => x.CreatedBy).HasMaxLength(256);
            builder.Property(x => x.UpdatedBy).HasMaxLength(256);
            builder.Property(x => x.DeletedFlag).HasDefaultValue(false);
            builder.HasOne(x => x.Chapter).WithMany(y => y.Contents).HasForeignKey(z => z.ChapterId);
        }
    }
}
