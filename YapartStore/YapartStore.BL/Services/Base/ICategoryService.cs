using System.Collections.Generic;
using System.Threading.Tasks;
using YapartStore.BL.Entities;

namespace YapartStore.BL.Services.Base
{
    public interface ICategoryService : IBaseAsyncService<CategoryDTO>
    {
        Task DeleteItem(string categoryName);
        Task<CategoryDTO> GetCategoryByName(string cartegoryName);
        Task<List<CategoryDTO>> GetCategoryByModification(string modificationName);
    }
}
