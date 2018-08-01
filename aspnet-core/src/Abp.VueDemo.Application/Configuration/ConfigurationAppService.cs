using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Abp.VueDemo.Configuration.Dto;

namespace Abp.VueDemo.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : VueDemoAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
