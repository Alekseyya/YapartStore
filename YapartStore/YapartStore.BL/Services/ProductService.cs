using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using YapartStore.BL.Entities;
using YapartStore.BL.MapperConfig;
using YapartStore.BL.Services.Base;
using YapartStore.DAL.Repositories.Base;
using YapartStore.DL.Entities;

namespace YapartStore.BL.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void AddItem(ProductDTO item)
        {
            try
            {
                var product = Mapper.Map<ProductDTO, Product>(item);
                _unitOfWork.ProductRepository.Create(product);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteItem(ProductDTO item)
        {
            try
            {
                var product = Mapper.Map<ProductDTO, Product>(item);
                var findProduct = _unitOfWork.ProductRepository.GetAll().FirstOrDefault(prod => prod.Article == item.Article && prod.Brand.Name == item.Brand.Name);
                if (findProduct != null)
                {
                    _unitOfWork.ProductRepository.Delete(findProduct.Id);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteItem(string article)
        {
            try
            {
                var findProduct = _unitOfWork.ProductRepository.GetAll()
                    .FirstOrDefault(prod => prod.Article == article);
                if (findProduct != null)
                {
                    _unitOfWork.ProductRepository.Delete(findProduct.Id);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<ProductDTO> GetAll()
        {
            try
            {
                var configurate = new MapperConfiguration(cfg =>
                {
                    cfg.AddProfile(new AutoMapperServicesConfig.ProductProfile());
                }).CreateMapper();

                var products = configurate.Map<IQueryable<Product>, IList<ProductDTO>>(_unitOfWork.ProductRepository.GetAll());
                if (products != null)
                    return products;
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<ProductDTO> GetAllCaps()
        {
            try
            {
                var configurate = new MapperConfiguration(cfg =>
                {
                    cfg.AddProfile(new AutoMapperServicesConfig.ProductProfile());
                }).CreateMapper();

                var products = configurate.Map<IQueryable<Product>, IList<ProductDTO>>(_unitOfWork.ProductRepository.GetAllCaps());
                if (products != null)
                    return products;
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<ProductDTO> GetAllProductsIncludeBrand()
        {
            try
            {
                var configurate = new MapperConfiguration(cfg =>
                {
                    cfg.AddProfile(new AutoMapperServicesConfig.ProductWithoutCategoryProfile());
                }).CreateMapper();
                var products = Mapper.Map<IQueryable<Product>, IList<ProductDTO>>
                                        (_unitOfWork.ProductRepository.GetAllProductsIncludeBrand());
                if (products != null)
                    return products;
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<ProductDTO> GetAllProductsOfBrand(string nameBrand)
        {
            try
            {
                var products =_unitOfWork.ProductRepository.GetAll().Where(br => br.Brand.Name == nameBrand);
                if (products != null)
                {
                    var configurate = new MapperConfiguration(cfg =>
                    {
                        cfg.AddProfile(new AutoMapperServicesConfig.ProductWithoutBrandAndCategoryProfile());
                    }).CreateMapper();

                    var productsDTO = configurate.Map<IQueryable<Product>, IList<ProductDTO>>(products);
                    return productsDTO;
                }

                return null;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ProductDTO GetItemById(int id)
        {
            try
            {
                var product = _unitOfWork.ProductRepository.GetAll().FirstOrDefault(car => car.Id == id);
                if (product != null)
                    return Mapper.Map<Product, ProductDTO>(product);
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<ProductDTO> GetSizeOfCaps(int size)
        {
            try
            {
                var configurate = new MapperConfiguration(cfg =>
                {
                    cfg.AddProfile(new AutoMapperServicesConfig.ProductProfile());
                }).CreateMapper();
                var listCapsOfCurSize = _unitOfWork.ProductRepository.GetAllCaps()
                    .Where(item => item.Article.Contains(size.ToString()));

                var products = configurate.Map<IQueryable<Product>, IList<ProductDTO>>(listCapsOfCurSize);
                if (products != null)
                    return products;
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateItem(ProductDTO item)
        {
            var product = Mapper.Map<ProductDTO, Product>(item);
            _unitOfWork.ProductRepository.Update(product);
        }
    }
}
