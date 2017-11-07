using Abp.Application.Services;
using Abp.Application.Services.Dto;
using GithubResearch.MultiTenancy.Dto;

namespace GithubResearch.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
