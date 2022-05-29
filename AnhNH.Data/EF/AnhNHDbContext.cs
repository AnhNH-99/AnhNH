using AnhNH.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnhNH.Data.EF
{
    public class AnhNHDbContext:DbContext
    {
        public AnhNHDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Story> Stories { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Content> Contents { get; set; }
    }
}
