using AiTech.DataAccess.Repositories.CategoryRepositories;
using AiTech.DataAccess.Repositories.ProjectRepositories;
using AiTech.DataAccess.UnitOfWorks;
using Microsoft.Extensions.DependencyInjection;

namespace AiTech.DataAccess.Extensions
{
    public static class ServiceRegistrations
    {

        public static void AddDataAccessServices(this IServiceCollection services)
        {

            services.AddScoped<ICategoryRepository,CategoryRepository>();
            services.AddScoped<IProjectRepository,ProjectRepository>();
            
            
            
            services.AddScoped<IUnitOfWork,UnitOfWork>();


        }





    }

}
