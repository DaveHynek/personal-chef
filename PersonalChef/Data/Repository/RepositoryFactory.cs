using Microsoft.EntityFrameworkCore;

namespace PersonalChef.Data.Repository
{
    public class RepositoryFactory<TContext, TEntity> : IRepositoryFactory<TContext, TEntity> 
                                                        where TContext : DbContext
                                                        where TEntity : class
    {
        private readonly TContext _context;

        public RepositoryFactory(TContext context)
        {
            _context = context;
        }

        public IRepository<TEntity> CreateRepository()
        {
            return new Repository<TEntity>(_context);
        }
    }
}