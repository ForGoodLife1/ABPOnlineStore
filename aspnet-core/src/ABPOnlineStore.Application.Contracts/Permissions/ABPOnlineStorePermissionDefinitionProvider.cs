using ABPOnlineStore.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ABPOnlineStore.Permissions;

public class ABPOnlineStorePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ABPOnlineStorePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ABPOnlineStorePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ABPOnlineStoreResource>(name);
    }
}
