using DisableAuditingTest.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace DisableAuditingTest.Permissions
{
    public class DisableAuditingTestPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(DisableAuditingTestPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(DisableAuditingTestPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<DisableAuditingTestResource>(name);
        }
    }
}
