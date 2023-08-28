using MultiTenancyDemo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MultiTenancyDemo;

[DependsOn(
    typeof(MultiTenancyDemoEntityFrameworkCoreTestModule)
    )]
public class MultiTenancyDemoDomainTestModule : AbpModule
{

}
