using System.Linq;
using YapartStore.DL.Entities;

namespace YapartStore.DAL.Repositories.Base
{
    public interface IModelRepository :IBaseRepository<Model>
    {
        Model GetItemByName(string name);
        IQueryable<Model> GetModelsByMarkName(string markName);
    }
}
