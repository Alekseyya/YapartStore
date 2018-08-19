using System;
using System.Data.Entity;
using System.Linq;
using YapartStore.DAL.Repositories.Base;
using YapartStore.DL.Context;
using YapartStore.DL.Entities;

namespace YapartStore.DAL.Repositories
{
   public class ModelRepository : IModelRepository
    {
        private readonly YapartStoreContext _yapartStoreContext;
        public ModelRepository(YapartStoreContext yapartStoreContext)
        {
            _yapartStoreContext = yapartStoreContext;
        }

        public void Create(Model item)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<Model> GetAll()
        {
                return _yapartStoreContext.Models
                    .Include(x => x.Mark)
                    .Include(x => x.Picture)
                    .AsQueryable();
        }

        public Model GetItemById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Model GetItemByName(string name)
        {
            return _yapartStoreContext.Models.FirstOrDefault(x => x.Name == name);
        }

        public IQueryable<Model> GetModelsByMarkName(string markName)
        {
            return from models in _yapartStoreContext.Models
                join marks in _yapartStoreContext.Marks on models.MarkId equals marks.Id
                where marks.Name.ToLower() == markName.ToLower()
                select models;
        }

        public void Update(Model item)
        {
            throw new System.NotImplementedException();
        }
    }
}
