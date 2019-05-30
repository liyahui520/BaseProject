using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MyCore.BaseProject.Controllers
{
    public abstract class BaseProjectControllerBase: AbpController
    {
        protected BaseProjectControllerBase()
        {
            LocalizationSourceName = BaseProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
