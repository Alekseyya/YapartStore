using YapartStore.BL.Entities;

namespace YapartStore.BL.Services.Base
{
    public interface ICategoryService : IBaseService<CategoryDTO>
    {
        void DeleteItem(string categoryName);
    }
}
