using System.Threading.Tasks;
using MyCore.BaseProject.Configuration.Dto;

namespace MyCore.BaseProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
