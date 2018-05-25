using System.Collections.Generic;
using System.Threading.Tasks;
using YapartStore.BL.Entities;

namespace YapartStore.BL.Services.Base
{
     public interface IOrderService : IBaseService<OrderDTO>
     {
         Task<IList<OrderDTO>> GetAllAsync();
         Task CreateOrder(OrderDTO order);
         Task<OrderDTO> GetOrderById(int id);
     }
}
