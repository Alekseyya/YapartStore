using System.Collections.Generic;
using System.Threading.Tasks;
using YapartStore.DAL.Repositories.Base;
using YapartStore.DL.Context;
using YapartStore.DL.Entities;

namespace YapartStore.DAL.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly YapartStoreContext _yapartStoreContext;
        public OrderRepository(YapartStoreContext yapartStoreContext)
        {
            _yapartStoreContext = yapartStoreContext;
        }

        public Task CreateAsync(Order item)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Order>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Order> GetItemByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(Order item)
        {
            throw new System.NotImplementedException();
        }
    }
}
