namespace AiTech.DataAccess.UnitOfWorks
{
    public interface IUnitOfWork
    {
        Task<bool> SaveChangesAsync();






    }
}
