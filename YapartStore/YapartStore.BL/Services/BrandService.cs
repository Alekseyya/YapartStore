using System;
using System.Linq;
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
            throw new NotImplementedException();
        }

        public void DeleteItem(BrandDTO item)
        {
            throw new NotImplementedException();
        }

        public IQueryable<BrandDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public BrandDTO GetItemById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(BrandDTO item)
        {
            throw new NotImplementedException();
        }
    }
}
