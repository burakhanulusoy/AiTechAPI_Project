using AiTech.DataAccess.Context;
using AiTech.DataAccess.Repositories.GenericRepositories;
using AiTech.Entity.Entities;

namespace AiTech.DataAccess.Repositories.OurTeamRepositories
{
    public class OurTeamRepository : GenericRepository<OurTeam>, IOurTeamRepository
    {
        public OurTeamRepository(AppDbContext context) : base(context)
        {
        }
    }
}
