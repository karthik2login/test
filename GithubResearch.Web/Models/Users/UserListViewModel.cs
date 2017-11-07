using System.Collections.Generic;
using GithubResearch.Roles.Dto;
using GithubResearch.Users.Dto;

namespace GithubResearch.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}