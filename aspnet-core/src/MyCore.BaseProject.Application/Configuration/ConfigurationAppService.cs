using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MyCore.BaseProject.Configuration.Dto;

namespace MyCore.BaseProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : BaseProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
