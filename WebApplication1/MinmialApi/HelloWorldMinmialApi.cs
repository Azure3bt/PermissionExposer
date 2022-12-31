namespace WebApplication1.MinmialApi
{
    public class HelloMinimalApi : IMinimalApiPermissionExposer
    {
        public string Path => "/hello/world";

        public HttpMethod Method => HttpMethod.Get;

        public Delegate Handler => HelloWorld;

        public async Task<string> HelloWorld()
        {
            return await Task.FromResult("Hello, world");
        }

        public IEnumerable<UserPermission> GetPermissions()
        {
            yield return new UserPermission() { Controller = "Hello", Action = "World" };
        }
    }
}
