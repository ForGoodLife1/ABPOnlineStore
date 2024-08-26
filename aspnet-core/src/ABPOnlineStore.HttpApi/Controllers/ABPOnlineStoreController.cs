using ABPOnlineStore.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ABPOnlineStore.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ABPOnlineStoreController : AbpControllerBase
{
    protected ABPOnlineStoreController()
    {
        LocalizationResource = typeof(ABPOnlineStoreResource);
    }
}
