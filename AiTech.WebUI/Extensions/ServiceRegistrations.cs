using AiTech.WebUI.Services.BannerServices;
using AiTech.WebUI.Services.CategoryServices;
using AiTech.WebUI.Services.ProjectServices;
using FluentValidation;
using FluentValidation.AspNetCore;
using System.Reflection;




namespace AiTech.WebUI.Extensions
{
    public static class ServiceRegistrations
    {
        public static void AddWebUIService(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<IBannerService, BannerService>();


            services.AddFluentValidationAutoValidation()
                    .AddFluentValidationClientsideAdapters()
                    .AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        }





    }
}
