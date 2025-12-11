
using AiTech.DataAccess.Context;

namespace AiTech.DataAccess.UnitOfWorks
{
    public class UnitOfWork(AppDbContext _context) : IUnitOfWork
    {
        public async Task<bool> SaveChangesAsync()
        {
           return await _context.SaveChangesAsync() > 0;


        }




    }
}
