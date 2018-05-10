using System.Collections.Generic;
using YapartStore.BL.Entities;

namespace YapartStore.BL.Services.Base
{
   public interface IProductService : IBaseService<ProductDTO>
    {
        void DeleteItem(string article);
        IList<ProductDTO> GetAllProductsOfBrand(string nameBrand);
        IList<ProductDTO> GetAllProductsIncludeBrand();
        IList<ProductDTO> GetAllCaps();
        IList<ProductDTO> GetSizeOfCaps(int size);
    }
}
