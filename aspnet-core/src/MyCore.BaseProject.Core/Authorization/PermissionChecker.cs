using Abp.Authorization;
using MyCore.BaseProject.Authorization.Roles;
using MyCore.BaseProject.Authorization.Users;

namespace MyCore.BaseProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
