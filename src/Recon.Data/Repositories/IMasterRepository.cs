namespace Recon.Data.Repositories
{
    public interface IMasterRepository<T> where T : class
    {
        Task<ICollection<T>> GetAllAsync();
        Task<T?> GetByIdAsync(long id);
    }
}
