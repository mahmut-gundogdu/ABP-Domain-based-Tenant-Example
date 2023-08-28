using Volo.Abp.Settings;

namespace MultiTenancyDemo.Settings;

public class MultiTenancyDemoSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(MultiTenancyDemoSettings.MySetting1));
    }
}
