using Volo.Abp.Modularity;

namespace ABPOnlineStore;

public abstract class ABPOnlineStoreApplicationTestBase<TStartupModule> : ABPOnlineStoreTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
