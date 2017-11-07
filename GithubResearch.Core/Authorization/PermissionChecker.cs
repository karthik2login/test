using Abp.Authorization;
using GithubResearch.Authorization.Roles;
using GithubResearch.Authorization.Users;

namespace GithubResearch.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
