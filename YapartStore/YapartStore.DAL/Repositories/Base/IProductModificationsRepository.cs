
using System.Collections.Generic;
using System.Linq;
using YapartStore.DL.Entities;

namespace YapartStore.DAL.Repositories.Base
{
    public interface IProductModificationsRepository : IBaseRepository<ProductModification>
    {
        IQueryable<Product> GetProductsByModificationId(int id);
    }
}
