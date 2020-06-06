using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace DisableAuditingTest.Web
{
    [Dependency(ReplaceServices = true)]
    public class DisableAuditingTestBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "DisableAuditingTest";
    }
}
