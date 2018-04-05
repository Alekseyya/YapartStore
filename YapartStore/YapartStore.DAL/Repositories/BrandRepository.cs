using System;
using System.Data.Entity;
using System.Linq;
using YapartStore.DAL.Repositories.Base;
using YapartStore.DL.Context;
using YapartStore.DL.Entities;

namespace YapartStore.DAL.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly YapartStoreContext _yapartStoreContext;
        public BrandRepository(YapartStoreContext yapartStoreContext)
        {
            _yapartStoreContext = yapartStoreContext;
        }
        public void Create(Brand item)
        {
            try
            {
                _yapartStoreContext.Brands.Add(item);
                _yapartStoreContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Delete(int id)
        {
            var brand = _yapartStoreContext.Brands.FirstOrDefault(i => i.Id == id);
            if (brand != null)
            {
                _yapartStoreContext.Brands.Remove(brand);
                _yapartStoreContext.SaveChanges();
            }
        }

        public IQueryable<Brand> GetAll()
        {
            try
            {                
                return _yapartStoreContext.Brands.Include("Products").AsQueryable();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Brand GetItemById(int id)
        {
            try
            {
                var brand = _yapartStoreContext.Brands.FirstOrDefault(br => br.Id == id);
                if (brand != null)
                    return brand;
                else
                    return null;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Update(Brand item)
        {
            try
            {
                var brand = _yapartStoreContext.Brands.FirstOrDefault(br => br.Id == item.Id);
                if (brand != null)
                {
                    bool isModefied = false;
                    if (brand.Name == item.Name)
                    {
                        brand.Name = item.Name;
                        isModefied = true;
                    }

                    if (isModefied)
                    {
                        _yapartStoreContext.Entry(brand).State = EntityState.Modified;
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
