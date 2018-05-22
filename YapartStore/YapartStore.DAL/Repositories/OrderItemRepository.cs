using System.Collections.Generic;
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
            throw new System.NotImplementedException();
        }

        public Task<List<OrderItem>> GetAllAsync()
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
