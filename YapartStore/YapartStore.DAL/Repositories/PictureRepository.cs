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
        public Task Create(Picture item)
        {
            try
            {
                _yapartStoreContext.Pictures.Add(item);
                return _yapartStoreContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Task Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IQueryable<Picture>> GetAll()
        {
            try
            {
                return Task.Run(() => { return _yapartStoreContext.Pictures.AsQueryable(); });
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<List<Picture>> GetAllAsync()
        {
            try
            {
                return await Task.Run(() =>
                {
                    return _yapartStoreContext.Pictures.Include("Brand").ToListAsync();
                });
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Task<Picture> GetItemById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(Picture item)
        {
            throw new System.NotImplementedException();
        }
    }
}
