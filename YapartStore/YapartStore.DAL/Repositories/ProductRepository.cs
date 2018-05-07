﻿using System;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using YapartStore.DAL.Repositories.Base;
using YapartStore.DL.Context;
using YapartStore.DL.Entities;

namespace YapartStore.DAL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly YapartStoreContext _yapartStoreContext;
        public ProductRepository(YapartStoreContext yapartStoreContext)
        {
            _yapartStoreContext = yapartStoreContext;
        }
        public IQueryable<Product> GetAll()
        {
            try
            {
                return _yapartStoreContext.Products.Select(ob => new
                    {
                        id = ob.Id,
                        article = ob.Article,
                        descriptions = ob.Descriptions,
                        price = ob.Price,
                        brandName = ob.Brand.Name,
                        categoryName = ob.Category.Name,
                        pictures = ob.Pictures
                    }).AsEnumerable()
                    .Select(pr => new Product
                    {
                        Id = pr.id,
                        Article = pr.article,
                        Descriptions = pr.descriptions,
                        Price = pr.price,
                        Brand = new Brand { Name = pr.brandName },
                        Category = new Category { Name = pr.categoryName},
                        Pictures = pr.pictures
                    }).AsQueryable();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Product GetItemById(int id)
        {
            try
            {
                var product = _yapartStoreContext.Products.FirstOrDefault(br => br.Id == id);
                if (product != null)
                    return product;
                else
                    return null;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Create(Product item)
        {
            try
            {
                _yapartStoreContext.Products.Add(item);
                _yapartStoreContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Update(Product item)
        {
            try
            {
                var product = _yapartStoreContext.Products.FirstOrDefault(br => br.Id == item.Id);
                if (product != null)
                {
                    bool isModefied = false;
                    if (product.Article == item.Article)
                    {
                        product.Article = item.Article;
                        isModefied = true;
                    }

                    if (product.Descriptions == item.Descriptions)
                    {
                        product.Descriptions = item.Descriptions;
                        isModefied = true;
                    }
                    if (product.Price == item.Price)
                    {
                        product.Price = item.Price;
                        isModefied = true;
                    }
                    if (product.BrandId == item.BrandId)
                    {
                        product.BrandId = item.BrandId;
                        isModefied = true;
                    }
                    if (product.CategoryId == item.CategoryId)
                    {
                        product.CategoryId = item.CategoryId;
                        isModefied = true;
                    }

                    if (isModefied)
                    {
                        _yapartStoreContext.Entry(product).State = EntityState.Modified;
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
            var product = _yapartStoreContext.Products.FirstOrDefault(i => i.Id == id);
            if (product != null)
            {
                _yapartStoreContext.Products.Remove(product);
                _yapartStoreContext.SaveChanges();
            }
        }

        public IQueryable<Product> GetAllProductsIncludeBrand()
        {
            try
            {
                return _yapartStoreContext.Products
                    .Select(ob => new
                    {
                        id = ob.Id,
                        article = ob.Article,
                        descriptions = ob.Descriptions,
                        price = ob.Price,
                        brandName = ob.Brand.Name
                    }).AsEnumerable()
                    .Select(pr => new Product
                    {
                        Id = pr.id,
                        Article = pr.article,
                        Descriptions = pr.descriptions,
                        Price = pr.price,
                        Brand = new Brand {Name = pr.brandName}
                    }).AsQueryable();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
