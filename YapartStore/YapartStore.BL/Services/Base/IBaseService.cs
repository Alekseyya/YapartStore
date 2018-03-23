using System.Linq;

namespace YapartStore.BL.Services.Base
{
    public interface IBaseService<T> where T : class
    {
        IQueryable<T> GetAll();
        T GetItemById(int id);
        void AddItem(T item);
        void UpdateItem(T item);
        void DeleteItem(T item);
    }
}
