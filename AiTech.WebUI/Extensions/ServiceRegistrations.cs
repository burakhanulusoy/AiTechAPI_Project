using AiTech.WebUI.Services.CategoryServices;

namespace AiTech.WebUI.Extensions
{
    public static class ServiceRegistrations
    {
        public static void AddWebUIService(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryService>();

        }





    }
}
