using System.Collections.Generic;
using System.Threading.Tasks;
using YapartStore.UI.Models;
using YapartStore.UI.ViewModels;

namespace YapartStore.UI.Services.Base
{
   public interface ICategoryService
   {
       Task<List<CategoryModel>> GetCategories();
       Task<List<CategoryViewModel>> MappingCategoryModelToViewModel(List<CategoryModel> categories);
       Task<CategoryViewModel> GetCategoryByName(string categoryName);
   }
}
