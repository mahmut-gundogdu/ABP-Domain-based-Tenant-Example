using Volo.Abp.Modularity;

namespace MultiTenancyDemo;

[DependsOn(
    typeof(MultiTenancyDemoApplicationModule),
    typeof(MultiTenancyDemoDomainTestModule)
    )]
public class MultiTenancyDemoApplicationTestModule : AbpModule
{

}
