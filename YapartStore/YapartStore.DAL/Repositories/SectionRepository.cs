using System;
using System.Data.Entity;
using System.Linq;
using YapartStore.DAL.Repositories.Base;
using YapartStore.DL.Context;
using YapartStore.DL.Entities;

namespace YapartStore.DAL.Repositories
{
    public class SectionRepository : ISectionRepository
    {
        private readonly YapartStoreContext _yapartStoreContext;
        public SectionRepository(YapartStoreContext yapartStoreContext)
        {
            _yapartStoreContext = yapartStoreContext;
        }
        public void Create(Section item)
        {
            try
            {
                _yapartStoreContext.Sections.Add(item);
                _yapartStoreContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Delete(int id)
        {
            var section = _yapartStoreContext.Sections.FirstOrDefault(i => i.Id == id);
            if (section != null)
            {
                _yapartStoreContext.Sections.Remove(section);
                _yapartStoreContext.SaveChanges();
            }
        }

        public IQueryable<Section> GetAll()
        {
            try
            {
                return _yapartStoreContext.Sections.Include("Group").Include("Categories").AsQueryable();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Section GetItemById(int id)
        {
            try
            {
                var section = _yapartStoreContext.Sections.FirstOrDefault(br => br.Id == id);
                if (section != null)
                    return section;
                else
                    return null;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Update(Section item)
        {
            try
            {
                var section = _yapartStoreContext.Sections.FirstOrDefault(br => br.Id == item.Id);
                if (section != null)
                {
                    bool isModefied = false;
                    if (section.Name == item.Name)
                    {
                        section.Name = item.Name;
                        isModefied = true;
                    }

                    if (section.GroupId== item.GroupId)
                    {
                        section.GroupId = item.GroupId;
                        isModefied = true;
                    }
                    
                    if (isModefied)
                    {
                        _yapartStoreContext.Entry(section).State = EntityState.Modified;
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
