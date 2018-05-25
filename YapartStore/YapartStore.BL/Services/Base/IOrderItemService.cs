using System.Threading.Tasks;
using YapartStore.BL.Entities;

namespace YapartStore.BL.Services.Base
{
     public interface IOrderItemService : IBaseService<OrderItemDTO>
     {
         Task DeleteItemAsync(int id);
     }
}
