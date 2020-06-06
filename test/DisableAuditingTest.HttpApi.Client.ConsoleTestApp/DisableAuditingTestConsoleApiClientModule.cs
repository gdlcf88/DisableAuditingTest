using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace DisableAuditingTest.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(DisableAuditingTestHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class DisableAuditingTestConsoleApiClientModule : AbpModule
    {
        
    }
}
