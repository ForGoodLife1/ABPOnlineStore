using Volo.Abp.Settings;

namespace ABPOnlineStore.Settings;

public class ABPOnlineStoreSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ABPOnlineStoreSettings.MySetting1));
    }
}
