using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using YapartStore.BL.Entities;
using YapartStore.BL.Helpers;
using YapartStore.BL.MapperConfig;
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

        public async Task<List<ModificationDTO>> GetAllModificationByModelName(string modelName)
        {
            var model = await Task.Run(() =>
            {
                return _unitOfWork.ModelRepository.GetAll().FirstOrDefault(x=>x.Name.ToLower() == modelName);
            });

            if (model != null)
            {
                var modifications = await _unitOfWork.ModificationRepository.GetAll()
                    .Where(x => x.ModelId == model.Id).OrderBy(x=>x.Sort)
                    .ToListAsync();

                if (modifications.Count != 0)
                {
                    var config = new MapperConfiguration(cfg =>
                    {
                        cfg.AddProfile(new AutoMapperServicesConfig.ModificationDTOProfile());
                    });

                    var mapper = config.CreateMapper();

                    var modificationsDto = mapper.Map<List<Modification>, List<ModificationDTO>>(modifications);
                    
                    return modificationsDto.ChangePathImage();
                }

                return null;
            }
            return null;
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
