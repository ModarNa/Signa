using Signa.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Signa.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class SignaController : AbpController
    {
        protected SignaController()
        {
            LocalizationResource = typeof(SignaResource);
        }
    }
}