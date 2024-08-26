using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ABPOnlineStore.Data;
using Volo.Abp.DependencyInjection;

namespace ABPOnlineStore.EntityFrameworkCore;

public class EntityFrameworkCoreABPOnlineStoreDbSchemaMigrator
    : IABPOnlineStoreDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreABPOnlineStoreDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the ABPOnlineStoreDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ABPOnlineStoreDbContext>()
            .Database
            .MigrateAsync();
    }
}
