using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DisableAuditingTest.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class DisableAuditingTestMigrationsDbContextFactory : IDesignTimeDbContextFactory<DisableAuditingTestMigrationsDbContext>
    {
        public DisableAuditingTestMigrationsDbContext CreateDbContext(string[] args)
        {
            DisableAuditingTestEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<DisableAuditingTestMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new DisableAuditingTestMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
