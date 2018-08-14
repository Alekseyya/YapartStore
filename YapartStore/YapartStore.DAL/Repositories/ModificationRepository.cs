using System.Collections.Generic;
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

        public void ChangeNameForLink()
        {
            var nullModificationsUrl = _yapartStoreContext.Modifications;

            if (nullModificationsUrl.Any())
            {
                foreach (var modification in nullModificationsUrl)
                {
                    modification.Url = modification.Name
                        .Trim()
                        .Replace("/", "")
                        .Replace("рестайлинг", "restyling")
                        .Replace(" ","-")
                        .ToLower();
                    _yapartStoreContext.Entry(modification).State = EntityState.Modified;
                }
                _yapartStoreContext.SaveChanges();
            }
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

        public Modification GetModificationByModificationName(string modificationUrl)
        {
            return _yapartStoreContext.Modifications.FirstOrDefault(modif => modif.Url == modificationUrl);
        }

        public void Update(Modification item)
        {
            throw new System.NotImplementedException();
        }
    }
}
