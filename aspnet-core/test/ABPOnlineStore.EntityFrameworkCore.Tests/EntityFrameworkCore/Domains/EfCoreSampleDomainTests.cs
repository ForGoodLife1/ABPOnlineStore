using ABPOnlineStore.Samples;
using Xunit;

namespace ABPOnlineStore.EntityFrameworkCore.Domains;

[Collection(ABPOnlineStoreTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ABPOnlineStoreEntityFrameworkCoreTestModule>
{

}
