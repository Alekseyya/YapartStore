using System.Collections.Generic;
using System.Linq;
using YapartStore.DL.Entities;

namespace YapartStore.DAL.Repositories.Base
{
    public interface IModificationRepository :IBaseRepository<Modification>
    {
        IQueryable<Modification> GetModificationsByModel(string modelName);
        void ChangeNameForLink();
        Modification GetModificationByModificationName(string modificationUrl);
    }
}
