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
    public class StoryConfiguration : IEntityTypeConfiguration<Story>
    {
        public void Configure(EntityTypeBuilder<Story> builder)
        {
            builder.ToTable("Stories");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.Description).HasColumnType("text");
            builder.Property(x => x.Status).HasDefaultValue(0);
            builder.Property(x => x.Author).IsRequired();
            builder.Property(x => x.Views).HasDefaultValue(0);
            builder.Property(x => x.Follows).HasDefaultValue(0);
            builder.Property(x => x.Likes).HasDefaultValue(0);
            builder.Property(x => x.CreatedAt).HasColumnType("datetime");
            builder.Property(x => x.UpdatedAt).HasColumnType("datetime");
            builder.Property(x => x.CreatedBy).HasMaxLength(256);
            builder.Property(x => x.UpdatedBy).HasMaxLength(256);
            builder.Property(x => x.DeletedFlag).HasDefaultValue(false);
        }
    }
}
