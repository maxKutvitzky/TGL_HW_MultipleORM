using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MultipleORM.Dal.Data.EntityFramework
{
    internal class PuppyDbContextFactory : IDesignTimeDbContextFactory<PuppyDbContext>
    {
        private readonly IConfiguration _configuration = GetConfiguration();

        private static IConfiguration GetConfiguration()
        {
            return new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory() + @"\Data\EntityFramework\")
                .AddJsonFile("dbContextConfig.json")
                .Build();
        }
        public PuppyDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<PuppyDbContext> builder = new DbContextOptionsBuilder<PuppyDbContext>();
            string connectionString = _configuration.GetConnectionString("Default");
            builder.UseSqlServer(connectionString);
            return new PuppyDbContext(builder.Options);
        }
    }
}
