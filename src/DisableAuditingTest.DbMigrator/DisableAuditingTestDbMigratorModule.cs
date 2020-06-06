using DisableAuditingTest.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace DisableAuditingTest.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(DisableAuditingTestEntityFrameworkCoreDbMigrationsModule),
        typeof(DisableAuditingTestApplicationContractsModule)
        )]
    public class DisableAuditingTestDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
