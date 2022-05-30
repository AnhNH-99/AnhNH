using AnhNH.Data.Configurations;
using AnhNH.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnhNH.Data.EF
{
    public class AnhNHDbContext:IdentityDbContext<AppUser, AppRole, Guid>
    {
        public AnhNHDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StoryConfiguration());
            modelBuilder.ApplyConfiguration(new ChapterConfiguration());
            modelBuilder.ApplyConfiguration(new ContentConfiguration());
        }
        public DbSet<Story> Stories { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Content> Contents { get; set; }
    }
}
