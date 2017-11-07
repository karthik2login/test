using System.Threading.Tasks;
using Abp.Application.Services;
using GithubResearch.Sessions.Dto;

namespace GithubResearch.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
