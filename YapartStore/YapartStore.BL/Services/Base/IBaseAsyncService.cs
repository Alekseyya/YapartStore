using System.Collections.Generic;
using System.Threading.Tasks;

namespace YapartStore.BL.Services.Base
{
   public interface IBaseAsyncService<T> where T: class 
    {
        Task<List<T>>GetAllAsync();
        Task<T> GetItemByIdAsync(int id);
        Task AddItemAsync(T item);
        Task UpdateItemAsync(T item);
        Task DeleteItemAsync(T item);
    }
}
