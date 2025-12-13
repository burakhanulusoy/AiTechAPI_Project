using AiTech.DataAccess.Context;
using AiTech.DataAccess.Repositories.GenericRepositories;
using AiTech.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace AiTech.DataAccess.Repositories.ProjectRepositories
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Project>> GetProjectsWithCategories()
        {
           
            return await _context.Set<Project>().AsNoTracking().Include(x=>x.Category).ToListAsync();
           // return await _context.Projects.AsNoTracking().Include(p => p.Category).ToListAsync();

        }
    }
}
