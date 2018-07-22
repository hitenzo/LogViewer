using Abp.Authorization;
using LogViewer.Authorization.Roles;
using LogViewer.Authorization.Users;

namespace LogViewer.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
