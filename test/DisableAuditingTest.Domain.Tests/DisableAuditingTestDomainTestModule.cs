using DisableAuditingTest.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace DisableAuditingTest
{
    [DependsOn(
        typeof(DisableAuditingTestEntityFrameworkCoreTestModule)
        )]
    public class DisableAuditingTestDomainTestModule : AbpModule
    {

    }
}