using Volo.Abp.Modularity;

namespace ABPOnlineStore;

[DependsOn(
    typeof(ABPOnlineStoreDomainModule),
    typeof(ABPOnlineStoreTestBaseModule)
)]
public class ABPOnlineStoreDomainTestModule : AbpModule
{

}
