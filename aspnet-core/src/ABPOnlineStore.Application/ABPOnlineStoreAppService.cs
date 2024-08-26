using System;
using System.Collections.Generic;
using System.Text;
using ABPOnlineStore.Localization;
using Volo.Abp.Application.Services;

namespace ABPOnlineStore;

/* Inherit your application services from this class.
 */
public abstract class ABPOnlineStoreAppService : ApplicationService
{
    protected ABPOnlineStoreAppService()
    {
        LocalizationResource = typeof(ABPOnlineStoreResource);
    }
}
