using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnhNH.Data.EF
{
    public class AnhNHDbContextFactory : IDesignTimeDbContextFactory<AnhNHDbContext>
    {
        public AnhNHDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("AnhNHDb");

            var optionsBuilder = new DbContextOptionsBuilder<AnhNHDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new AnhNHDbContext(optionsBuilder.Options);
        }
    }
}
