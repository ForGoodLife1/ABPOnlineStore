using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ABPOnlineStore.Data;

/* This is used if database provider does't define
 * IABPOnlineStoreDbSchemaMigrator implementation.
 */
public class NullABPOnlineStoreDbSchemaMigrator : IABPOnlineStoreDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
