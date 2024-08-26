using Xunit;

namespace ABPOnlineStore.EntityFrameworkCore;

[CollectionDefinition(ABPOnlineStoreTestConsts.CollectionDefinitionName)]
public class ABPOnlineStoreEntityFrameworkCoreCollection : ICollectionFixture<ABPOnlineStoreEntityFrameworkCoreFixture>
{

}
