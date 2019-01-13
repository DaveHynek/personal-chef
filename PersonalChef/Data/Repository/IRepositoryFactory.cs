using Microsoft.EntityFrameworkCore;

namespace PersonalChef.Data.Repository
{
    public interface IRepositoryFactory<TContext, TEntity> where TContext : DbContext
                                                           where TEntity : class
    {
        IRepository<TEntity> CreateRepository();
    }
}