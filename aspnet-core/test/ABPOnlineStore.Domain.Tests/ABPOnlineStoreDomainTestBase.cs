using Volo.Abp.Modularity;

namespace ABPOnlineStore;

/* Inherit from this class for your domain layer tests. */
public abstract class ABPOnlineStoreDomainTestBase<TStartupModule> : ABPOnlineStoreTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
