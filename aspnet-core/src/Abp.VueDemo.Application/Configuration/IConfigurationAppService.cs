using System.Threading.Tasks;
using Abp.VueDemo.Configuration.Dto;

namespace Abp.VueDemo.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
