using MultiTenancyDemo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace MultiTenancyDemo.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MultiTenancyDemoEntityFrameworkCoreModule),
    typeof(MultiTenancyDemoApplicationContractsModule)
    )]
public class MultiTenancyDemoDbMigratorModule : AbpModule
{
}
