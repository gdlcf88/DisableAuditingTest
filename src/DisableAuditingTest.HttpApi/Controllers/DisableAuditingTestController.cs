using DisableAuditingTest.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace DisableAuditingTest.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class DisableAuditingTestController : AbpController
    {
        protected DisableAuditingTestController()
        {
            LocalizationResource = typeof(DisableAuditingTestResource);
        }
    }
}