﻿using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using YapartStore.DAL.Repositories.Base;
using YapartStore.DL.Context;
using YapartStore.DL.Entities;

namespace YapartStore.DAL.Repositories
{
   public class ModificationRepository : IModificationRepository
   {
       private readonly YapartStoreContext _yapartStoreContext;
        public ModificationRepository(YapartStoreContext yapartStoreContext)
        {
            _yapartStoreContext = yapartStoreContext;
        }

        public void Create(Modification item)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<Modification> GetAll()
        {
            return _yapartStoreContext.Modifications.Include(x => x.Model)
                .Include(x=>x.Picture).AsQueryable();
        }

        public Modification GetItemById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<Modification> GetModificationsByModel(string modelName)
        {
            return _yapartStoreContext.Modifications.Include(x => x.Picture)
                .Where(x => x.Model.Name == modelName).AsQueryable();
        }

        public void Update(Modification item)
        {
            throw new System.NotImplementedException();
        }
    }
}
