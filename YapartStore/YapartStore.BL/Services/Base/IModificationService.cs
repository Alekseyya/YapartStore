using System.Collections.Generic;
using System.Threading.Tasks;
using YapartStore.BL.Entities;

namespace YapartStore.BL.Services.Base
{
   public interface IModificationService: IBaseAsyncService<ModificationDTO>
   {
       Task<List<ModificationDTO>> GetAllModificationByModelName(string modelName);
   }
}
