using Microsoft.AspNetCore.Mvc;
using Volo.Abp.Auditing;

namespace DisableAuditingTest.Controllers
{
    public class HomeController : DisableAuditingTestController
    {
        [HttpHead]
        [Route("")]
        [DisableAuditing]
        public void Head()
        {
        }
        
        [HttpPost]
        [Route("")]
        [DisableAuditing]
        public void Post()
        {
        }
    }
}