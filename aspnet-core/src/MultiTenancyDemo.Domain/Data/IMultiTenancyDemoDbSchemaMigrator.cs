using System.Threading.Tasks;

namespace MultiTenancyDemo.Data;

public interface IMultiTenancyDemoDbSchemaMigrator
{
    Task MigrateAsync();
}
