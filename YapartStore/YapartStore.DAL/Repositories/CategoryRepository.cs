using System;
using System.Data.Entity;
using System.Linq;
using YapartStore.DAL.Repositories.Base;
using YapartStore.DL.Context;
using YapartStore.DL.Entities;

namespace YapartStore.DAL.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly YapartStoreContext _yapartStoreContext;
        public CategoryRepository(YapartStoreContext yapartStoreContext)
        {
            _yapartStoreContext = yapartStoreContext;
        }
        public IQueryable<Category> GetAll()
        {
            try
            {
                return _yapartStoreContext.Categories.Include("Products").Include("Section").AsQueryable();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Category GetItemById(int id)
        {
            try
            {
                var category = _yapartStoreContext.Categories.FirstOrDefault(br => br.Id == id);
                if (category != null)
                    return category;
                else
                    return null;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Create(Category item)
        {
            try
            {
                _yapartStoreContext.Categories.Add(item);
                _yapartStoreContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Update(Category item)
        {
            try
            {
                var category = _yapartStoreContext.Categories.FirstOrDefault(br => br.Id == item.Id);
                if (category != null)
                {
                    bool isModefied = false;
                    if (category.Name == item.Name)
                    {
                        category.Name = item.Name;
                        isModefied = true;
                    }
                    if (category.SectionId == item.SectionId)
                    {
                        category.SectionId = item.SectionId;
                        isModefied = true;
                    }

                    if (isModefied)
                    {
                        _yapartStoreContext.Entry(category).State = EntityState.Modified;
                        _yapartStoreContext.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Delete(int id)
        {
            var category = _yapartStoreContext.Categories.FirstOrDefault(i => i.Id == id);
            if (category != null)
            {
                _yapartStoreContext.Categories.Remove(category);
                _yapartStoreContext.SaveChanges();
            }
        }

        public IQueryable<Category> GetCategoriesByModification(string nameModification)
        {

            return from categories in _yapartStoreContext.Categories
                join products in _yapartStoreContext.Products on categories.Id equals products.CategoryId
                join productModif in _yapartStoreContext.ProductModifications on products.Id equals productModif
                    .ProductId
                join modification in _yapartStoreContext.Modifications on productModif.ModificationId equals
                    modification.Id
                where modification.Name == nameModification
                select categories;
        }
    }
}
