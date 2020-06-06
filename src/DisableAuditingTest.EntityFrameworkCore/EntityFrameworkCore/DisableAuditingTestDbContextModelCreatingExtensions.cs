using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace DisableAuditingTest.EntityFrameworkCore
{
    public static class DisableAuditingTestDbContextModelCreatingExtensions
    {
        public static void ConfigureDisableAuditingTest(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(DisableAuditingTestConsts.DbTablePrefix + "YourEntities", DisableAuditingTestConsts.DbSchema);

            //    //...
            //});
        }
    }
}