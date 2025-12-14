using AiTech.DataAccess.Context;
using AiTech.DataAccess.Repositories.GenericRepositories;
using AiTech.Entity.Entities;

namespace AiTech.DataAccess.Repositories.BannerRepositories
{
    public class BannerRepository : GenericRepository<Banner>, IBannerRepository
    {
        public BannerRepository(AppDbContext context) : base(context)
        {
        }

        public async Task MakeActiveAsync(Banner banner)
        {
            banner.IsActive = true;


        }

        public async Task MakePassiveAsync(Banner banner)
        {
            banner.IsActive = false;
        }
    }
}
