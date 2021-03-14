using Volo.Abp.Settings;

namespace Signa.Settings
{
    public class SignaSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(SignaSettings.MySetting1));
        }
    }
}
