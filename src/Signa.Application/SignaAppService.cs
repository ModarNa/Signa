using System;
using System.Collections.Generic;
using System.Text;
using Signa.Localization;
using Volo.Abp.Application.Services;

namespace Signa
{
    /* Inherit your application services from this class.
     */
    public abstract class SignaAppService : ApplicationService
    {
        protected SignaAppService()
        {
            LocalizationResource = typeof(SignaResource);
        }
    }
}
