using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using YapartStore.BL.Entities;
using YapartStore.BL.Services.Base;

namespace YapartStore.API.Controllers
{
    public class CategoryController : ApiController
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
 
        }

        [HttpGet]
        public IEnumerable<CategoryDTO> GetCategories()
        {
            var categories = _categoryService.GetAll();
            return categories;
        }

        [HttpPost]
        public IHttpActionResult AddCategory(CategoryDTO category)
        {
            if (ModelState.IsValid)
            {
                _categoryService.AddItem(category);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IHttpActionResult DeleteCategory(string categoryName)
        {
            try
            {
                _categoryService.DeleteItem(categoryName);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
