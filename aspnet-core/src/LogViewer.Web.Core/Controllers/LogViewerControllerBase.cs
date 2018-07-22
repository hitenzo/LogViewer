using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace LogViewer.Controllers
{
    public abstract class LogViewerControllerBase: AbpController
    {
        protected LogViewerControllerBase()
        {
            LocalizationSourceName = LogViewerConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
