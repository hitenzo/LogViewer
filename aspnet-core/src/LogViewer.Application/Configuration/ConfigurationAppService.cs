using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using LogViewer.Configuration.Dto;

namespace LogViewer.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : LogViewerAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
