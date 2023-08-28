using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace MultiTenancyDemo;

[Dependency(ReplaceServices = true)]
public class MultiTenancyDemoBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "MultiTenancyDemo";
}
