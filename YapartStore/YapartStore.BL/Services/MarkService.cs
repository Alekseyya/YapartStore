

using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using YapartStore.BL.Entities;
using YapartStore.BL.Services.Base;
using YapartStore.DAL.Repositories.Base;
using YapartStore.DL.Entities;

namespace YapartStore.BL.Services
{
     public class MarkService : IMarkService
    {
        private readonly IUnitOfWork _unitOfWork;

        public MarkService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task AddItemAsync(MarkDTO item)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteItemAsync(MarkDTO item)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<MarkDTO>> GetAllAsync()
        {
            return Mapper.Map<List<Mark>, List<MarkDTO>>(
                await _unitOfWork.MarkRepository.GetAll().ToListAsync());
        }

        public Task<MarkDTO> GetItemByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateItemAsync(MarkDTO item)
        {
            throw new System.NotImplementedException();
        }
    }
}
