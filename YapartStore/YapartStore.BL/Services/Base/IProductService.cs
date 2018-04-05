using YapartStore.BL.Entities;

namespace YapartStore.BL.Services.Base
{
   public interface IProductService : IBaseService<ProductDTO>
    {
        void DeleteItem(string article);
    }
}
