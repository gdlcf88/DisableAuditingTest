using Volo.Abp.Settings;

namespace DisableAuditingTest.Settings
{
    public class DisableAuditingTestSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(DisableAuditingTestSettings.MySetting1));
        }
    }
}
