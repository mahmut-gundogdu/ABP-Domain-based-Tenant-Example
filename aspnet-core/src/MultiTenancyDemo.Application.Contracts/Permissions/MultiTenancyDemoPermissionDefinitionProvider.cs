using MultiTenancyDemo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MultiTenancyDemo.Permissions;

public class MultiTenancyDemoPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(MultiTenancyDemoPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(MultiTenancyDemoPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MultiTenancyDemoResource>(name);
    }
}
