using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using YapartStore.BL.Entities;
using YapartStore.BL.Services.Base;

namespace YapartStore.API.Controllers
{
    public class OrderController : ApiController
    {
        private readonly IOrderService _orderService;
        private readonly IOrderItemService _orderItemService;

        public OrderController(IOrderService orderService, IOrderItemService orderlItemService)
        {
            _orderService = orderService;
            _orderItemService = orderlItemService;
        }

        [HttpGet]
        public async Task<IEnumerable<OrderDTO>> GetAllOrders()
        {
            var orders = await _orderService.GetAllAsync();
            if (orders == null)
                return null;
            return orders;
        }

        [HttpPost]
        public async Task CreateOrder(OrderDTO order)
        {
            try
            {
                await _orderService.CreateOrder(order);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpGet]
        public async Task<OrderDTO> GetOrderById(int orderId)
        {
            try
            {
                var order = await _orderService.GetOrderById(orderId);
                return order;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        #region OrderItem
        
        [HttpDelete]
        public async Task DeleteItemFromOrder(int itemId)
        {
            try
            {
                await _orderItemService.DeleteItemAsync(itemId);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion
    }
}
