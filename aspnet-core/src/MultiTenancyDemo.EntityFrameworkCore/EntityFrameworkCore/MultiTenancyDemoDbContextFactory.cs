using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MultiTenancyDemo.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class MultiTenancyDemoDbContextFactory : IDesignTimeDbContextFactory<MultiTenancyDemoDbContext>
{
    public MultiTenancyDemoDbContext CreateDbContext(string[] args)
    {
        MultiTenancyDemoEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<MultiTenancyDemoDbContext>()
            .UseSqlite(configuration.GetConnectionString("Default"));

        return new MultiTenancyDemoDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../MultiTenancyDemo.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
