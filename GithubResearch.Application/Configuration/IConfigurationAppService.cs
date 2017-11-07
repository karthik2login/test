using System.Threading.Tasks;
using Abp.Application.Services;
using GithubResearch.Configuration.Dto;

namespace GithubResearch.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}