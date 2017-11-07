using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using GithubResearch.Roles.Dto;
using GithubResearch.Users.Dto;

namespace GithubResearch.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}