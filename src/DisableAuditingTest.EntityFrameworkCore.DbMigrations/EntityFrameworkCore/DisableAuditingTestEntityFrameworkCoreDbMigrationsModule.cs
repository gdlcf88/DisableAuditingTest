using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace DisableAuditingTest.EntityFrameworkCore
{
    [DependsOn(
        typeof(DisableAuditingTestEntityFrameworkCoreModule)
        )]
    public class DisableAuditingTestEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<DisableAuditingTestMigrationsDbContext>();
        }
    }
}
