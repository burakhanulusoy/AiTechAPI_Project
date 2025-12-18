using AiTech.DataAccess.Context;
using AiTech.DataAccess.Repositories.GenericRepositories;
using AiTech.Entity.Entities;

namespace AiTech.DataAccess.Repositories.TestimonialRepositories
{
    public class TestimonialRepository : GenericRepository<Testimonial>, ITestimonialRepository
    {
        public TestimonialRepository(AppDbContext context) : base(context)
        {
        }
    }
}
