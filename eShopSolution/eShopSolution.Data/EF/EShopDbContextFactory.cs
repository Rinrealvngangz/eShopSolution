using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace eShopSolution.Data.EF
{
    public class EShopDbContextFactory : IDesignTimeDbContextFactory<EShopDbContext>
    {
        public EShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                                               .SetBasePath(Directory.GetCurrentDirectory())
                                               .AddJsonFile("appsettings.json").Build();
            var connectionString = configuration.GetConnectionString("eShopSolutionDb");
            var optionsBuider = new DbContextOptionsBuilder<EShopDbContext>();
            optionsBuider.UseSqlServer(connectionString);
            return new EShopDbContext(optionsBuider.Options);
        }
    }
}
