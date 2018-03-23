using System;
using System.Data.Entity;
using System.Linq;
using YapartStore.DAL.Repositories.Base;
using YapartStore.DL.Context;
using YapartStore.DL.Entities;

namespace YapartStore.DAL.Repositories
{
    public class GroupRepository : IGroupRepository
    {
        private readonly YapartStoreContext _yapartStoreContext;
        public GroupRepository(YapartStoreContext yapartStoreContext)
        {
            _yapartStoreContext = yapartStoreContext;
        }
        public void Create(Group item)
        {
            try
            {
                _yapartStoreContext.Groups.Add(item);
                _yapartStoreContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Delete(int id)
        {
            var group = _yapartStoreContext.Groups.FirstOrDefault(i => i.Id == id);
            if (group != null)
            {
                _yapartStoreContext.Groups.Remove(group);
                _yapartStoreContext.SaveChanges();
            }
        }

        public IQueryable<Group> GetAll()
        {
            try
            {
                return _yapartStoreContext.Groups.AsQueryable();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Group GetItemById(int id)
        {
            try
            {
                var group = _yapartStoreContext.Groups.FirstOrDefault(br => br.Id == id);
                if (group != null)
                    return group;
                else
                    return null;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Update(Group item)
        {
            try
            {
                var group = _yapartStoreContext.Groups.FirstOrDefault(br => br.Id == item.Id);
                if (group != null)
                {
                    bool isModefied = false;
                    if (group.Name == item.Name)
                    {
                        group.Name = item.Name;
                        isModefied = true;
                    }
                    
                    if (isModefied)
                    {
                        _yapartStoreContext.Entry(group).State = EntityState.Modified;
                        _yapartStoreContext.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
