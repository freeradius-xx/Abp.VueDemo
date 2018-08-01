using Abp.Authorization;
using Abp.VueDemo.Authorization.Roles;
using Abp.VueDemo.Authorization.Users;

namespace Abp.VueDemo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
