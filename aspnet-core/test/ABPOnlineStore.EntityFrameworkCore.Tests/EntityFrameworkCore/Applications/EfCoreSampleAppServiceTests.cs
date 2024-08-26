using ABPOnlineStore.Samples;
using Xunit;

namespace ABPOnlineStore.EntityFrameworkCore.Applications;

[Collection(ABPOnlineStoreTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ABPOnlineStoreEntityFrameworkCoreTestModule>
{

}
