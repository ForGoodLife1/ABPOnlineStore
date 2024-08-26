using ABPOnlineStore.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ABPOnlineStore.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ABPOnlineStoreEntityFrameworkCoreModule),
    typeof(ABPOnlineStoreApplicationContractsModule)
    )]
public class ABPOnlineStoreDbMigratorModule : AbpModule
{
}
