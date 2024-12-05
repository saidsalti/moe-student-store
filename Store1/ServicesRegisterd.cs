using Store1.Data.Services;

namespace Store1
{
    public static class ServicesRegisterd
    {
        public static void AddRegistredService(this IServiceCollection services)
        {
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddScoped<IAppTempData, AppTempData>();
        }
    }
}
