using System.Threading.Tasks;

namespace DisableAuditingTest.Data
{
    public interface IDisableAuditingTestDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
