using YapartStore.BL.Entities;
using YapartStore.DL.Entities;

namespace YapartStore.BL.Services.Base
{
    public interface IBrandService : IBaseService<BrandDTO>
    {
        void DeleteByName(string brandName);
    }
}
