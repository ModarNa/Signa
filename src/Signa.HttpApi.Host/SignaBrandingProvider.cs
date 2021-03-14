using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Signa
{
    [Dependency(ReplaceServices = true)]
    public class SignaBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Signa";
    }
}
