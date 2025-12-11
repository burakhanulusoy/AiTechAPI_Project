using AiTech.Entity.Entities.Common;

namespace AiTech.DataAccess.Repositories.GenericRepositories
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {

        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(int id);
        Task CreateAsync(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);












    }
}
