using System.Data.Entity;
using System;
using System.Linq;
using System.Threading.Tasks;
using YapartStore.DAL.Repositories.Base;
using YapartStore.DL.Context;
using YapartStore.DL.Entities;

namespace YapartStore.DAL.Repositories
{
     public class MarkRepository : IMarkRepository
    {
        private readonly YapartStoreContext _yapartStoreContext;

        public MarkRepository(YapartStoreContext yapartStoreContext)
        {
            _yapartStoreContext = yapartStoreContext;
        }

        public void Create(Mark item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Mark> GetAll()
        {
            return _yapartStoreContext.Marks.Include(x=>x.Picture).AsQueryable();
        }

        public Mark GetItemById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Mark item)
        {
            throw new NotImplementedException();
        }
    }
}
