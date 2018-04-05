using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using YapartStore.BL.Entities;
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
        public void AddItem(CategoryDTO item)
        {
            try
            {
                var category = Mapper.Map<CategoryDTO, Category>(item);
                _unitOfWork.CategoryRepository.Create(category);
            }
            catch (Exception ex)
            {
                throw ex;
            }
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

        public void DeleteItem(string categoryName)
        {
            try
            {
                var findCategory = _unitOfWork.CategoryRepository.GetAll().FirstOrDefault(catName => catName.Name == categoryName);
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

        public void UpdateItem(CategoryDTO item)
        {
            var category = Mapper.Map<CategoryDTO, Category>(item);
            _unitOfWork.CategoryRepository.Update(category);
        }
    }
}
