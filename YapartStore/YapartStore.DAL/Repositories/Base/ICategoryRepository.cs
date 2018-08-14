using System.Linq;
using YapartStore.DL.Entities;

namespace YapartStore.DAL.Repositories.Base
{
    public interface ICategoryRepository : IBaseRepository<Category>
    {
        IQueryable<Category> GetCategoriesByModification(string nameModification);
    }
}
