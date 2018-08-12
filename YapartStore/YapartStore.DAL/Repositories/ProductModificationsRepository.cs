using System.Linq;
using System.Threading.Tasks;
using YapartStore.DAL.Repositories.Base;
using YapartStore.DL.Context;
using YapartStore.DL.Entities;
using System.Data.Entity;

namespace YapartStore.DAL.Repositories
{
    public class ProductModificationsRepository : IProductModificationsRepository
    {
        private readonly YapartStoreContext _yapartStoreContext;
        public ProductModificationsRepository(YapartStoreContext yapartStoreContext)
        {
            _yapartStoreContext = yapartStoreContext;
        }

        public void Create(ProductModification item)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<ProductModification> GetAll()
        {
            return _yapartStoreContext.ProductModifications
                .Include(pr => pr.Product)
                .Include(modif => modif.Modification)
                .AsQueryable();
        }

        public ProductModification GetItemById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(ProductModification item)
        {
            throw new System.NotImplementedException();
        }
    }
}
