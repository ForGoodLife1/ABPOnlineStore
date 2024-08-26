using Volo.Abp.Modularity;

namespace ABPOnlineStore;

[DependsOn(
    typeof(ABPOnlineStoreApplicationModule),
    typeof(ABPOnlineStoreDomainTestModule)
)]
public class ABPOnlineStoreApplicationTestModule : AbpModule
{

}
