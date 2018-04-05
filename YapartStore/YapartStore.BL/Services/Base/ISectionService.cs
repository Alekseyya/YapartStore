using YapartStore.BL.Entities;

namespace YapartStore.BL.Services.Base
{
   public interface ISectionService : IBaseService<SectionDTO>
    {
        void DeleteItem(string sectionName);
    }
}
