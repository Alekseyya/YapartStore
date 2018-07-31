using System.Collections.Generic;
using System.Threading.Tasks;
using YapartStore.UI.Models;

namespace YapartStore.UI.Services.Base
{
   public interface ICategoryService
   {
       Task<List<CategoryModel>> GetCategories();
   }
}
