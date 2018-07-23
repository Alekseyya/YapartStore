using System;
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
    public class ModelService : IModelService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ModelService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task AddItemAsync(ModelDTO item)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteItemAsync(ModelDTO item)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<ModelDTO>> GetAllAsync()
        {
            return Mapper.Map<List<Model>, List<ModelDTO>>(
                await _unitOfWork.ModelRepository.GetAll().ToListAsync());
        }

        public Task<ModelDTO> GetItemByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<ModelDTO>> GetModelsByMarkName(string markName)
        {
            try
            {
                var models = await _unitOfWork.ModelRepository.GetAll()
                    .Where(x => x.Mark.Name == markName).ToListAsync();
                
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.AddProfile(new AutoMapperServicesConfig.ModelDTOProfile());
                });
                
                var mapper = config.CreateMapper();

                var modelsDTO = mapper.Map<List<Model>, List<ModelDTO>>(models);
                var list = new List<int>();
                foreach (var model in modelsDTO)
                {
                    list.Add(model.Id);
                }

                var bb = await _unitOfWork.PictureRepository.GetAll().ToListAsync();
                var a = await _unitOfWork.PictureRepository.GetAll()
                    .Where(x => modelsDTO.Any(y => x.Model.Id == y.Id)).ToListAsync();
                
                modelsDTO.ChangePathImage();
                return null;
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }

        public Task UpdateItemAsync(ModelDTO item)
        {
            throw new System.NotImplementedException();
        }
    }
}
