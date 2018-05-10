using System.Collections.Generic;
using System.Threading.Tasks;
using YapartStore.UI.ViewModels;

namespace YapartStore.UI.Services.Base
{
    public interface IProductService
    {
        Task<List<ProductViewModel>> GetAllProducts();
        Task<List<ProductViewModel>> GetProductsOfBrand(string brand);
        Task<List<ProductViewModel>> GetAllCaps();
        Task<List<ProductViewModel>> GetSizeOfCaps(int size);
    }
}
