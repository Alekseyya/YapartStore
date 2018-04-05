using System;
using System.Linq;
using AutoMapper;
using YapartStore.BL.Entities;
using YapartStore.BL.Services.Base;
using YapartStore.DAL.Repositories.Base;
using YapartStore.DL.Entities;

namespace YapartStore.BL.Services
{
    public class BrandService: IBrandService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BrandService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddItem(BrandDTO item)
        {
            var brand = Mapper.Map<BrandDTO, Brand>(item);
            _unitOfWork.BrandRepository.Create(brand);
        }

        public void DeleteByName(string brandName)
        {
            try
            {
                var brand = _unitOfWork.BrandRepository.GetAll().FirstOrDefault(brName => brName.Name == brandName);
                if (brand != null)
                    _unitOfWork.BrandRepository.Delete(brand.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteItem(BrandDTO item)
        {
            var brand = Mapper.Map<BrandDTO, Brand>(item);
            var findBrand = _unitOfWork.BrandRepository.GetAll().FirstOrDefault(brName => brName.Name == item.Name);
            if (findBrand != null)
            {
                _unitOfWork.BrandRepository.Delete(findBrand.Id);
            }
        }

        public IQueryable<BrandDTO> GetAll()
        {
            try
            {
                var brands = Mapper.Map<IQueryable<Brand>, IQueryable<BrandDTO>>(_unitOfWork.BrandRepository.GetAll());
                return brands;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public BrandDTO GetItemById(int id)
        {
            try
            {
                var brand = _unitOfWork.BrandRepository.GetAll().FirstOrDefault(br => br.Id == id);
                return Mapper.Map<Brand, BrandDTO>(brand);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public void UpdateItem(BrandDTO item)
        {
            throw new NotImplementedException();
        }
    }
}
