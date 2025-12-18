using AiTech.Business.Services.AboutServices;
using AiTech.Business.Services.BannerServices;
using AiTech.Business.Services.CategoryServices;
using AiTech.Business.Services.OurTeamServices;
using AiTech.Business.Services.ProjectServices;
using AiTech.Business.Services.TestimonailServices;
using AiTech.Business.Services.WhyChoiseServices;
using Microsoft.Extensions.DependencyInjection;

namespace AiTech.Business.Extensions
{
    public static class ServiceRegistrations
    {

        public static void AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<IBannerService, BannerService>();
            services.AddScoped<IAboutService, AboutService>();
            services.AddScoped<IWhyChoiseService, WhyChoiseService>();
            services.AddScoped<IOurTeamService, OurTeamService>();
            services.AddScoped<ITestimonailService, TestimonailService>();




        }




    }
}
