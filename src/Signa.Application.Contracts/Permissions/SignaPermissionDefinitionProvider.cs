using Signa.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Signa.Permissions
{
    public class SignaPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(SignaPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(SignaPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<SignaResource>(name);
        }
    }
}
