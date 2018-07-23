using System.Collections.Generic;
using System.Threading.Tasks;
using YapartStore.BL.Entities;

namespace YapartStore.BL.Services.Base
{
    public interface IModelService : IBaseAsyncService<ModelDTO>
    {
        Task<List<ModelDTO>> GetModelsByMarkName(string markName);
    }
}
