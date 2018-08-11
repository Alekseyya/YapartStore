using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using YapartStore.BL.Entities;
using YapartStore.BL.Services.Base;

namespace YapartStore.API.Controllers
{
    [EnableCors(origins: "http://localhost:58823", headers: "*", methods: "*")]
    public class CategoryController : ApiController
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
 
        }

        [HttpGet]
        public async Task<IEnumerable<CategoryDTO>> GetCategories()
        {
            var categories = await _categoryService.GetAllAsync();
            return categories;
        }

        [HttpGet]
        public async Task<CategoryDTO> GetCategoryByName(string categoryName)
        {
            var category = await _categoryService.GetCategoryByName(categoryName);
            return category;
        }

        [HttpPost]
        public async Task<IHttpActionResult> AddCategory(CategoryDTO category)
        {
            if (ModelState.IsValid)
            {
                await _categoryService.AddItemAsync(category);
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
