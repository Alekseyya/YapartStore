using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using AutoMapper;
using YapartStore.BL.Entities;
using YapartStore.BL.Services.Base;
using YapartStore.DAL.Repositories.Base;
using YapartStore.DL.Entities;

namespace YapartStore.BL.Services
{
    public class ModificationService : IModificationService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ModificationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task AddItemAsync(ModificationDTO item)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteItemAsync(ModificationDTO item)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<ModificationDTO>> GetAllAsync()
        {
            return Mapper.Map<List<Modification>, List<ModificationDTO>>(
                await _unitOfWork.ModificationRepository.GetAll().ToListAsync());
        }

        public Task<ModificationDTO> GetItemByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateItemAsync(ModificationDTO item)
        {
            throw new System.NotImplementedException();
        }
    }
}
