
using System.Collections.Generic;
using System.Threading.Tasks;
using YapartStore.UI.ViewModels;

namespace YapartStore.UI.Services.Base
{
   public interface IModelService
   {
       Task<List<ModelViewModel>> GetModelByMarkName(string markName);
       Task<ModelViewModel> GetModelByName(string modelName);
   }
}
