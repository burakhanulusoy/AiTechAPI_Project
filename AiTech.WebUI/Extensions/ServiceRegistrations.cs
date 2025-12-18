using AiTech.WebUI.Services.AboutServices;
using AiTech.WebUI.Services.BannerServices;
using AiTech.WebUI.Services.CategoryServices;
using AiTech.WebUI.Services.GemineServices;
using AiTech.WebUI.Services.OurTeamServices;
using AiTech.WebUI.Services.ProjectServices;
using AiTech.WebUI.Services.TestimonialServices;
using AiTech.WebUI.Services.WhyChoiceServices;
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
            services.AddScoped<IGeminiService, GeminiService>();
            services.AddScoped<IAboutService, AboutService>();
            services.AddScoped<IWhyChoiceService, WhyChoiceService>();
            services.AddScoped<IOurTeamService, OurTeamService>();
            services.AddScoped<ITestimonailService, TestimonailService>();


            services.AddFluentValidationAutoValidation()
                    .AddFluentValidationClientsideAdapters()
                    .AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        }





    }
}
