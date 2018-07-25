﻿using System;
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

        public async Task<ModelDTO> GetModelByName(string modelName)
        {
            return Mapper.Map<Model, ModelDTO>
                (await Task.Run(() =>
                    {
                        return _unitOfWork.ModelRepository.GetItemByName(modelName);
                    }
                )).ChangePathImage();
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

                var modelsDTOs = mapper.Map<List<Model>, List<ModelDTO>>(models);
                
                var pictureIds = await _unitOfWork.PictureRepository.GetAll()
                    .Select(x => new {x.Id, x.Path}).ToListAsync();

                var newModelsDTO = new List<ModelDTO>();

                foreach (var pictureId in pictureIds)
                {
                    foreach (var modelDTO in modelsDTOs)
                    {
                        if (pictureId.Id == modelDTO.Id)
                        {
                            modelDTO.PicturePath = pictureId.Path;
                            newModelsDTO.Add(modelDTO);
                        }
                    }
                }

                return newModelsDTO.ChangePathImage();
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
