using DisableAuditingTest.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace DisableAuditingTest.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class DisableAuditingTestPageModel : AbpPageModel
    {
        protected DisableAuditingTestPageModel()
        {
            LocalizationResourceType = typeof(DisableAuditingTestResource);
        }
    }
}