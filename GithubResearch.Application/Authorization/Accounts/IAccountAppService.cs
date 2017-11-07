using System.Threading.Tasks;
using Abp.Application.Services;
using GithubResearch.Authorization.Accounts.Dto;

namespace GithubResearch.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
