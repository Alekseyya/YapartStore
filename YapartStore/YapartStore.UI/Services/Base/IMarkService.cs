using System.Collections.Generic;
using System.Threading.Tasks;
using YapartStore.UI.ViewModels;

namespace YapartStore.UI.Services.Base
{
    public interface IMarkService
    {
        Task<List<MarkViewModel>> GetAllMarks();
    }
}
