using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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
            try
            {
                _yapartStoreContext.Orders.Add(item);
               return _yapartStoreContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Task DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IQueryable<Order>> GetAllAsync()
        {
            try
            {
                return await Task.Run(() =>
                {
                    return _yapartStoreContext.Orders.Include(orderItems=> orderItems.OrderItems);
                });
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<Order> GetItemByIdAsync(int id)
        {
            try
            {
                return await Task.Run(() =>
                {
                    return _yapartStoreContext.Orders.FirstOrDefault(i => i.Id == id);
                });
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Task UpdateAsync(Order item)
        {
            throw new System.NotImplementedException();
        }
    }
}
