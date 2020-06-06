using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DisableAuditingTest.Data;
using Volo.Abp.DependencyInjection;

namespace DisableAuditingTest.EntityFrameworkCore
{
    public class EntityFrameworkCoreDisableAuditingTestDbSchemaMigrator
        : IDisableAuditingTestDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreDisableAuditingTestDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the DisableAuditingTestMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<DisableAuditingTestMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}