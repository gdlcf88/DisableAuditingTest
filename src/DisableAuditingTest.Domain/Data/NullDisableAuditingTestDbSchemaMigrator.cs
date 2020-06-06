using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace DisableAuditingTest.Data
{
    /* This is used if database provider does't define
     * IDisableAuditingTestDbSchemaMigrator implementation.
     */
    public class NullDisableAuditingTestDbSchemaMigrator : IDisableAuditingTestDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}