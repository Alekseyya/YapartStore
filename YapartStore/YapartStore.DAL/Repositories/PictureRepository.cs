using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using YapartStore.DAL.Repositories.Base;
using YapartStore.DL.Context;
using YapartStore.DL.Entities;

namespace YapartStore.DAL.Repositories
{
    public class PictureRepository : IPictureRepository
    {
        private readonly YapartStoreContext _yapartStoreContext;

        public PictureRepository(YapartStoreContext yapartStoreContext)
        {
            _yapartStoreContext = yapartStoreContext;
        }

        public void Create(Picture item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Picture> GetAll()
        {
            return _yapartStoreContext.Pictures
                .Include(x=>x.Model)
                .AsQueryable();
        }

        public Picture GetItemById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Picture item)
        {
            throw new NotImplementedException();
        }
        
    }
}
