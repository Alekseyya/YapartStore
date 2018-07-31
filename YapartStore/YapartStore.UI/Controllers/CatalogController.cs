using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using YapartStore.UI.App_Start;
using YapartStore.UI.Models;
using YapartStore.UI.Services.Base;
using YapartStore.UI.ViewModels;

namespace YapartStore.UI.Controllers
{
    public class CatalogController : Controller
    {
        private readonly IProductService _productService;

        private readonly IModelService _modelService;

        private readonly IModificationService _modificationService;
        private readonly ICategoryService _categoryService;
        //private readonly IBrandService _brandService;
        public CatalogController(IProductService productService, 
                                IModelService modelService,
                                IModificationService modificationService,
                                ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
            //_brandService = brandService;
            _modelService = modelService;
            _modificationService = modificationService;

        }
        public async Task<ActionResult> Index(int page = 1)
        {
            int pageSize = 3;
            var products = await _productService.GetAllProducts();
            var productPerPage = products.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            var pageInfo = new PageInfo { PageNumber = page, PageSize = pageSize, TotalItems = products.Count };
            var catalog = new CapsCatalogViewModel() { PageInfo = pageInfo, Products = productPerPage };
            return View(catalog);
        }

        [HttpGet]
        [RequireRouteValues(new[] { "car" })]
        public async Task<ActionResult> Cars(string car)
        {
            var listModels = await _modelService.GetModelByMarkName(car);
            ViewBag.Mark = car;
            return View(listModels);
        }

        [HttpGet]
        //[RequireRequestValue("model")]
        [RequireRouteValues(new[] { "car", "model" })]
        public async Task<ActionResult> Cars(string car, string model)
        {
            //достать фотку автомобиля
            var carModel = await _modelService.GetModelByName(model);
            ViewBag.Model = carModel;
            ViewData["Model"] = carModel;
            ViewData["Car"] = car;
            ViewBag.Categories = await _categoryService.GetCategories();
            var modifictions = await _modificationService.GetModificationByModelName(model);
            return View("~/Views/Catalog/Modifications.cshtml", modifictions); //изменить путь к вьюшке, поставить другой
        }
    }
}