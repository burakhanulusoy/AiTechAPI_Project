using AiTech.DataAccess.Context;
using AiTech.DataAccess.Repositories.AboutRepositories;
using AiTech.DataAccess.Repositories.BannerRepositories;
using AiTech.DataAccess.Repositories.CategoryRepositories;
using AiTech.DataAccess.Repositories.OurTeamRepositories;
using AiTech.DataAccess.Repositories.ProjectRepositories;
using AiTech.DataAccess.Repositories.TestimonialRepositories;
using AiTech.DataAccess.Repositories.WhyChoiseRepositories;
using AiTech.DataAccess.UnitOfWorks;
using AiTech.Entity.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace AiTech.DataAccess.Extensions
{
    public static class ServiceRegistrations
    {

        public static void AddDataAccessServices(this IServiceCollection services)
        {

            services.AddScoped<ICategoryRepository,CategoryRepository>();
            services.AddScoped<IProjectRepository,ProjectRepository>();
            services.AddScoped<IBannerRepository,BannerRepository>();
            services.AddScoped<IAboutRepository,AboutRepository>();
            services.AddScoped<IWhyChoiseRepository,WhyChoiseRepository>();
            services.AddScoped<IOurTeamRepository,OurTeamRepository>();
            services.AddScoped<ITestimonialRepository,TestimonialRepository>();
            
            
            
            services.AddScoped<IUnitOfWork,UnitOfWork>();


            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<AppDbContext>();


        }





    }

}
