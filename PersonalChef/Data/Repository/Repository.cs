using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalChef.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private DbContext _context;

        public Repository(DbContext context)
        {
            _context = context;
        }

        public async Task<IList<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync().ConfigureAwait(false);
        }

    }
}
