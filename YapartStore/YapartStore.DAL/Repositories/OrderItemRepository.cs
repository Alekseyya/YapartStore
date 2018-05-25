using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YapartStore.DAL.Repositories.Base;
using YapartStore.DL.Context;
using YapartStore.DL.Entities;

namespace YapartStore.DAL.Repositories
{
    public class OrderItemRepository : IOrderItemRepository
    {
        private readonly YapartStoreContext _yapartStoreContext;
        public OrderItemRepository(YapartStoreContext yapartStoreContext)
        {
            _yapartStoreContext = yapartStoreContext;
        }
        public Task CreateAsync(OrderItem item)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            return Task.Run(() =>
            {
                var item = _yapartStoreContext.OrderItems.First(i => i.Id == id);
                if (item != null)
                {
                    _yapartStoreContext.OrderItems.Remove(item);
                    _yapartStoreContext.SaveChangesAsync();
                }
            });
        }

        public Task<IQueryable<OrderItem>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<OrderItem> GetItemByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(OrderItem item)
        {
            throw new System.NotImplementedException();
        }
    }
}
