using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalChef.Data.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<IList<T>> GetAllAsync();
    }
}
