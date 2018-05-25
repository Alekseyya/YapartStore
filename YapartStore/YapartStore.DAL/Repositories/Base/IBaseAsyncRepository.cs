using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YapartStore.DAL.Repositories.Base
{
     public interface IBaseAsyncRepository<T> where T : class
    {
        Task<IQueryable<T>> GetAllAsync();
        Task<T> GetItemByIdAsync(int id);
        Task CreateAsync(T item);
        Task UpdateAsync(T item);
        Task DeleteAsync(int id);
    }
}
