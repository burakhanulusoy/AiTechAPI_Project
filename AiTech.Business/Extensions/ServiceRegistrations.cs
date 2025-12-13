using AiTech.Business.Services.CategoryServices;
using AiTech.Business.Services.ProjectServices;
using Microsoft.Extensions.DependencyInjection;

namespace AiTech.Business.Extensions
{
    public static class ServiceRegistrations
    {

        public static void AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProjectService, ProjectService>();




        }




    }
}
