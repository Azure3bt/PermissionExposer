namespace WebApplication1.MinmialApi
{
    public static class RegisterMinimalApiHelper
    {
        public static void InjectMinimalApis(this IServiceCollection services)
        {
            services.AddSingleton<IPermissionExposer, HelloMinimalApi>();
        }

        public static void RegisterMinimalApi(this WebApplication application)
        {
            foreach (var item in application.Services.GetServices<IMinimalApiPermissionExposer>())
            {
                application.MapMethods(item.Path, new[] { item.Method.ToString() }, item.Handler);
            }
        }
    }
}
