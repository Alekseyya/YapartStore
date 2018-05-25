using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using YapartStore.BL.Entities;
using YapartStore.BL.MapperConfig;
using YapartStore.BL.Services.Base;
using YapartStore.DAL.Repositories.Base;
using YapartStore.DL.Entities;

namespace YapartStore.BL.Services
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrderService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void AddItem(OrderDTO item)
        {
            try
            {
                var order = Mapper.Map<OrderDTO, Order>(item);
                _unitOfWork.OrderRepository.CreateAsync(order);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task CreateOrder(OrderDTO order)
        {
            try
            {
                var newOrder = Mapper.Map<OrderDTO, Order>(order);
                return _unitOfWork.OrderRepository.CreateAsync(newOrder);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void DeleteItem(OrderDTO item)
        {
            throw new System.NotImplementedException();
        }

        public IList<OrderDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<IList<OrderDTO>> GetAllAsync()
        {
            try
            {
                var orders = Mapper.Map<IQueryable<Order>, IList<OrderDTO>>
                    (await _unitOfWork.OrderRepository.GetAllAsync());
                if (orders != null)
                    return orders;
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public OrderDTO GetItemById(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<OrderDTO> GetOrderById(int id)
        {
            try
            {
                var order = await _unitOfWork.OrderRepository.GetItemByIdAsync(id);
                if (order != null)
                {
                    return Mapper.Map<Order, OrderDTO>(order);
                }
                return null;
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }

        public void UpdateItem(OrderDTO item)
        {
            throw new System.NotImplementedException();
        }
       
    }
}
