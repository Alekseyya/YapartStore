using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using YapartStore.BL.Entities;
using YapartStore.BL.MapperConfig;
using YapartStore.BL.Services.Base;
using YapartStore.DAL.Repositories.Base;
using YapartStore.DL.Entities;

namespace YapartStore.BL.Services
{
    public class PictureService : IPictureService
    {
        private readonly IUnitOfWork _unitOfWork;
        public PictureService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task AddAsync(PictureDTO picture)
        {
            throw new System.NotImplementedException();
        }

        public void AddItem(PictureDTO item)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteItem(PictureDTO item)
        {
            throw new System.NotImplementedException();
        }

        public IList<PictureDTO> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<PictureDTO>> GetAllAsync()
        {
            try
            {
                var pictures = await _unitOfWork.PictureRepository.GetAll().ToListAsync();
                if (pictures != null)
                   return Mapper.Map<List<Picture>,List<PictureDTO>>(pictures);
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<PictureDTO> GetByIdAsync(int id)
        {
            //try
            //{
            //    var pictures = await _unitOfWork.PictureRepository.GetItemByIdAsync(id);
            //    if (pictures != null)
            //        return Mapper.Map<Picture, PictureDTO>(pictures);
            //    else
            //        return null;
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return null;
        }

        public PictureDTO GetItemById(int id)
        {
            
            throw new NotImplementedException();
        }

        public void UpdateItem(PictureDTO item)
        {
            throw new System.NotImplementedException();
        }
    }
}
