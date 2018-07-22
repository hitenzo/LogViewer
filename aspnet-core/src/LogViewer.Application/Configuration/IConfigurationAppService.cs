using System.Threading.Tasks;
using LogViewer.Configuration.Dto;

namespace LogViewer.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
