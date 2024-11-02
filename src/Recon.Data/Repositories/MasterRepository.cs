using Microsoft.EntityFrameworkCore;
using Recon.Data.Context;

namespace Recon.Data.Repositories
{
    public class MasterRepository<T> : IMasterRepository<T> where T : class
    {
        private readonly ReconDbContext _reconDbContext;
        private readonly DbSet<T> _dbSet;

        public MasterRepository(ReconDbContext dbContext) 
        { 
            _reconDbContext = dbContext;
            _dbSet = _reconDbContext.Set<T>();
        }

        public async Task<ICollection<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T?> GetByIdAsync(long id)
        {
            return await _dbSet.FindAsync(id);
        }
    }
}
