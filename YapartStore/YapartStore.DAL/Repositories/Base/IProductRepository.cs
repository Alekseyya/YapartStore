using System.Linq;
using YapartStore.DL.Entities;

namespace YapartStore.DAL.Repositories.Base
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        IQueryable<Product> GetAllProductsIncludeBrand();
        IQueryable<Product> GetAllCaps();

    }
}
