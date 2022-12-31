namespace WebApplication1
{
    public interface IPermissionExposer
    {
        IEnumerable<UserPermission> GetPermissions();
    }
}
