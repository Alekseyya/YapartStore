using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using YapartStore.BL.Entities;
using YapartStore.BL.MapperConfig;
using YapartStore.BL.Services.Base;
using YapartStore.DAL.Repositories.Base;
using YapartStore.DL.Entities;

namespace YapartStore.BL.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddItemAsync(CategoryDTO item)
        {
            var category = await Task.Run(() => { return Mapper.Map<CategoryDTO, Category>(item); });
            await Task.Run(() => { _unitOfWork.CategoryRepository.Create(category); }); 
        }

        public void DeleteItem(CategoryDTO item)
        {
            try
            {
                var category = Mapper.Map<CategoryDTO, Category>(item);
                var findCategory = _unitOfWork.CategoryRepository.GetAll().FirstOrDefault(catName => catName.Name == item.Name);
                if (findCategory != null)
                {
                    _unitOfWork.CategoryRepository.Delete(findCategory.Id);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task DeleteItemAsync(CategoryDTO item)
        {
            throw new NotImplementedException();
        }

        public IList<CategoryDTO> GetAll()
        {
            try
            {
                var categories = Mapper.Map<IQueryable<Category>, IList<CategoryDTO>>(_unitOfWork.CategoryRepository.GetAll());
                if (categories != null)
                    return categories;
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<CategoryDTO>> GetAllAsync()
        {
            try
            {
                var categories = await _unitOfWork.CategoryRepository.GetAll().ToListAsync();
                if (categories != null)
                {
                    var configurate = new MapperConfiguration(cfg =>
                    {
                        cfg.AddProfile(new AutoMapperServicesConfig.CategoryWithoutProductsProfile());
                    }).CreateMapper();

                    return configurate.Map<List<Category>, List<CategoryDTO>>(categories);
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<CategoryDTO>> GetCategoryByModification(string modificationName)
        {
            var categories = await _unitOfWork.CategoryRepository.GetCategoriesByModification(modificationName)
                .ToListAsync();

            if (categories.Count > 0)
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.AddProfile(new AutoMapperServicesConfig.CategoryProfile());
                });
                var mapper = config.CreateMapper();
                return mapper.Map<List<Category>, List<CategoryDTO>>(categories);
            }
            return null;
        }

        public async Task<CategoryDTO> GetCategoryByName(string cartegoryName)
        {
            try
            {
                var category = await Task.Run(() =>
                {
                     return _unitOfWork.CategoryRepository.GetAll()
                        .FirstOrDefault(cat => cat.EnglishName.ToLower() == cartegoryName.ToLower());
                });

                if (category != null)
                {
                    var configurate = new MapperConfiguration(cfg =>
                    {
                        cfg.AddProfile(new AutoMapperServicesConfig.CategoryWithoutProductsProfile());
                    }).CreateMapper();

                    return configurate.Map<Category, CategoryDTO>(category);
                }

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CategoryDTO GetItemById(int id)
        {
            try
            {
                var category = _unitOfWork.CategoryRepository.GetAll().FirstOrDefault(car => car.Id == id);
                if (category != null)
                    return Mapper.Map<Category, CategoryDTO>(category);
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<CategoryDTO> GetItemByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(CategoryDTO item)
        {
            var category = Mapper.Map<CategoryDTO, Category>(item);
            _unitOfWork.CategoryRepository.Update(category);
        }

        public Task UpdateItemAsync(CategoryDTO item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteItem(string categoryName)
        {
            try
            {
                var findCategory = _unitOfWork.CategoryRepository.GetAll().FirstOrDefault(catName => catName.Name == categoryName);
                if (findCategory != null)
                {
                    _unitOfWork.CategoryRepository.Delete(findCategory.Id);
                    
                }
                return Task.CompletedTask;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
