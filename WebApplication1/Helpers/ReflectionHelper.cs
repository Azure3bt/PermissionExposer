using System.Reflection;

namespace WebApplication1.Helpers
{
    public static class ReflectionHelper
    {
        public static IEnumerable<UserPermission> GetPermissionsExposer(this IServiceProvider services)
        {
            var permissions = new List<UserPermission>();
            foreach(var permissionExposer in services.GetServices<IPermissionExposer>())
            {
                permissions.AddRange(permissionExposer.GetPermissions());
            }
            return permissions;
        }
    }
}
