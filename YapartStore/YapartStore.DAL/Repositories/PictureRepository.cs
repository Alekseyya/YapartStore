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
        public Task CreateAsync(Picture item)
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
        

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
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

        public Task<Picture> GetItemByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        
        public Task UpdateAsync(Picture item)
        {
            throw new NotImplementedException();
        }
    }
}
