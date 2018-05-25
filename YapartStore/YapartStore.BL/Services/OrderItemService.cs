using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using YapartStore.BL.Entities;
using YapartStore.BL.Services.Base;
using YapartStore.DAL.Repositories.Base;

namespace YapartStore.BL.Services
{
    public class OrderItemService : IOrderItemService
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrderItemService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void AddItem(OrderItemDTO item)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteItem(OrderItemDTO item)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteItemAsync(int id)
        {
            try
            {
                return _unitOfWork.OrderItemRepository.DeleteAsync(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IList<OrderItemDTO> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public OrderItemDTO GetItemById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateItem(OrderItemDTO item)
        {
            throw new System.NotImplementedException();
        }
    }
}
