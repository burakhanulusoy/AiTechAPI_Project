using AiTech.DataAccess.Context;
using AiTech.DataAccess.Repositories.GenericRepositories;
using AiTech.Entity.Entities;

namespace AiTech.DataAccess.Repositories.AboutRepositories
{
    public class AboutRepository : GenericRepository<About>, IAboutRepository
    {
        public AboutRepository(AppDbContext context) : base(context)
        {
        }





    }
}
