using System;
using System.Collections.Generic;
using System.Text;
using DisableAuditingTest.Localization;
using Volo.Abp.Application.Services;

namespace DisableAuditingTest
{
    /* Inherit your application services from this class.
     */
    public abstract class DisableAuditingTestAppService : ApplicationService
    {
        protected DisableAuditingTestAppService()
        {
            LocalizationResource = typeof(DisableAuditingTestResource);
        }
    }
}
