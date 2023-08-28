﻿using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MultiTenancyDemo.Data;

/* This is used if database provider does't define
 * IMultiTenancyDemoDbSchemaMigrator implementation.
 */
public class NullMultiTenancyDemoDbSchemaMigrator : IMultiTenancyDemoDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
