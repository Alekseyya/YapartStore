using System.Linq;
using System.Threading.Tasks;

namespace YapartStore.DAL.Repositories.Base
{
     public interface IBaseAsyncRepository<T> where T : class
    {
        Task<IQueryable<T>> GetAll();
        Task<T> GetItemById(int id);
        Task Create(T item);
        Task Update(T item);
        Task Delete(int id);
    }
}
