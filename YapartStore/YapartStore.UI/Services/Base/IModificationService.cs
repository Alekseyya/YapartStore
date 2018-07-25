using System.Collections.Generic;
using System.Threading.Tasks;
using YapartStore.UI.ViewModels;

namespace YapartStore.UI.Services.Base
{
    public interface IModificationService
    {
        Task<List<ModificationViewModel>> GetModificationByModelName(string modelName);
    }
}
