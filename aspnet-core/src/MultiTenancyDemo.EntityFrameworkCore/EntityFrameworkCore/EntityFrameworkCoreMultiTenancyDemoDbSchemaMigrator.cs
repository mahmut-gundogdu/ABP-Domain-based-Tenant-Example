using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MultiTenancyDemo.Data;
using Volo.Abp.DependencyInjection;

namespace MultiTenancyDemo.EntityFrameworkCore;

public class EntityFrameworkCoreMultiTenancyDemoDbSchemaMigrator
    : IMultiTenancyDemoDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreMultiTenancyDemoDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the MultiTenancyDemoDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<MultiTenancyDemoDbContext>()
            .Database
            .MigrateAsync();
    }
}
