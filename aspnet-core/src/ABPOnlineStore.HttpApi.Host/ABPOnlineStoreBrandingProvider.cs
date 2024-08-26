using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ABPOnlineStore;

[Dependency(ReplaceServices = true)]
public class ABPOnlineStoreBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ABPOnlineStore";
}
