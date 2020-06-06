using Volo.Abp.Modularity;

namespace DisableAuditingTest
{
    [DependsOn(
        typeof(DisableAuditingTestApplicationModule),
        typeof(DisableAuditingTestDomainTestModule)
        )]
    public class DisableAuditingTestApplicationTestModule : AbpModule
    {

    }
}