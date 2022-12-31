using WebApplication1.Controllers;

namespace WebApplication1.MinmialApi
{
    public static class RegisterControllers
    {
        public static void InjectControllerApis(this IServiceCollection services)
        {
            services.AddSingleton<IPermissionExposer, HomeController>();
        }

        //public static void RegisterMinimalApi(this WebApplication application)
        //{
        //    foreach (var item in application.Services.GetServices<IMinimalApiPermissionExposer>())
        //    {
        //        application.MapMethods(item.Path, new[] { item.Method.ToString() }, item.Handler);
        //    }
        //}
    }
}
