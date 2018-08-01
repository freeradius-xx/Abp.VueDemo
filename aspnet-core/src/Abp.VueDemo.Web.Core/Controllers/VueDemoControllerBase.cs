using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Abp.VueDemo.Controllers
{
    public abstract class VueDemoControllerBase: AbpController
    {
        protected VueDemoControllerBase()
        {
            LocalizationSourceName = VueDemoConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
