using System.Collections.Generic;
using System.Threading.Tasks;
using YapartStore.BL.Entities;

namespace YapartStore.BL.Services.Base
{
    public interface IPictureService : IBaseService<PictureDTO>
    {
        Task<List<PictureDTO>> GetAllAsync();
        Task AddAsync(PictureDTO picture);
        Task<PictureDTO> GetByIdAsync(int id);

    }
}
