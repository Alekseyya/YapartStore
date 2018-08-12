using System.Collections.Generic;
using System.Threading.Tasks;
using YapartStore.BL.Entities;

namespace YapartStore.BL.Services.Base
{
   public interface IProductService : IBaseService<ProductDTO>, IBaseAsyncService<ProductDTO>
    {
        void DeleteItem(string article);
        IList<ProductDTO> GetAllProductsOfBrand(string nameBrand);
        IList<ProductDTO> GetAllProductsIncludeBrand();
        IList<ProductDTO> GetAllCaps();
        IList<ProductDTO> GetSizeOfCaps(int size);
        ProductDTO GetProductByArticle(string article);

        Task<List<ProductDTO>> GetProductsByModification(string modificationName);
    }
}
