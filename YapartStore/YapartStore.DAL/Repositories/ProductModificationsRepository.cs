using System.Linq;
using System.Threading.Tasks;
using YapartStore.DAL.Repositories.Base;
using YapartStore.DL.Context;
using YapartStore.DL.Entities;

namespace YapartStore.DAL.Repositories
{
    public class ProductModificationsRepository : IProductModificationsRepository
    {
        private readonly YapartStoreContext _yapartStoreContext;
        public ProductModificationsRepository(YapartStoreContext yapartStoreContext)
        {
            _yapartStoreContext = yapartStoreContext;
        }
        public Task CreateAsync(ProductModification item)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IQueryable<ProductModification>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<ProductModification> GetItemByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(ProductModification item)
        {
            throw new System.NotImplementedException();
        }
    }
}
