using AiTech.DataAccess.Context;
using AiTech.DataAccess.Repositories.GenericRepositories;
using AiTech.Entity.Entities;

namespace AiTech.DataAccess.Repositories.WhyChoiseRepositories
{
    public class WhyChoiseRepository : GenericRepository<WhyChoise>, IWhyChoiseRepository
    {
        public WhyChoiseRepository(AppDbContext context) : base(context)
        {
        }
    }
}
