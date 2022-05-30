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
    public class ChapterConfiguration : IEntityTypeConfiguration<Chapter>
    {
        public void Configure(EntityTypeBuilder<Chapter> builder)
        {
            builder.ToTable("Chapters");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.StroyId).IsRequired();
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Title);
            builder.Property(x => x.Description);
            builder.Property(x => x.Status);
            builder.Property(x => x.Views).HasDefaultValue(0);
            builder.Property(x => x.Likes).HasDefaultValue(0);
            builder.Property(x => x.CreatedAt).HasColumnType("datetime");
            builder.Property(x => x.UpdatedAt).HasColumnType("datetime");
            builder.Property(x => x.CreatedBy).HasMaxLength(256);
            builder.Property(x => x.UpdatedBy).HasMaxLength(256);
            builder.Property(x => x.DeletedFlag).HasDefaultValue(false);
            builder.HasOne(x => x.Story).WithMany(y => y.Chapters).HasForeignKey(z => z.StroyId);
        }
    }
}
