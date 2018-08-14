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
        public async Task<ActionResult> AllCars()
        {
            return View();
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
        [RequireRouteValues(new[] { "car", "model" })]
        public async Task<ActionResult> Cars(string car, string model)
        {
            var carModel = await _modelService.GetModelByName(model);
            ViewBag.Mark = car;
            ViewBag.Model = model;
            ViewBag.Categories = await _categoryService
                .MappingCategoryModelToViewModel(await _categoryService.GetCategories());
            var modifictions = await _modificationService.GetModificationByModelName(model);
            ViewBag.Accessories = await _productService.GetProductsByModel(model);
            return View("~/Views/Catalog/Models.cshtml", modifictions);
        }

        [HttpGet]
        [RequireRouteValues(new[] { "car", "model", "modification" })]
        public async Task<ActionResult> Cars(string car, string model, string modification)
        {
            //тогда уже тут надо два параметра чтобы из базы вытянуло
            var carModel = await _modelService.GetModelByName(model);
            var modificationObject = await _modificationService.GetModificationByModificationUrl(modification);
            ViewBag.Mark = car;
            ViewBag.Model = model;
            ViewBag.Modification = modification;
            ViewBag.Categories = await _categoryService.GetCategoriesByModification(modificationObject.Name);
            ViewBag.Accessories = await _productService.GetProductsByModification(modificationObject.Name);
            return View("~/Views/Catalog/Modifications.cshtml");
        }


        [HttpGet]
        public async Task<ActionResult> AllAccessories()
        {
            return View();
        }

        [HttpGet]
        //[Route("/{mark}")]
        [RequireRouteValues(new[] { "mark" })]
        public async Task<ActionResult> Accessories(string mark)
        {
            return View();
        }


        [HttpGet]
        //[Route("/{mark}/{model}")]
        [RequireRouteValues(new[] { "mark", "model" })]
        public async Task<ActionResult> Accessories(string mark, string model)
        {
            return View();
        }

        [HttpGet]
        //[Route("/{mark}/{model}/{modification}")]
        [RequireRouteValues(new[] { "mark", "model", "modification" })]
        public async Task<ActionResult> Accessories(string mark, string model, string modification)
        {
            return View();
        }

        [HttpGet]
        //[Route("/{accessories}/{mark}/{model}")]
        [RequireRouteValues(new[] { "accessories" })]
        public async Task<ActionResult> CurrentAccessories(string accessories)
        {

            return View("~/Views/Catalog/Accessories.cshtml");
        }

        [HttpGet]
        //[Route("/{accessories}/{mark}/{model}")]
        [RequireRouteValues(new[] { "accessories", "mark" })]
        public async Task<ActionResult> CurrentAccessories(string accessories, string mark)
        {
            return View("~/Views/Catalog/Accessories.cshtml");
        }

        [HttpGet]
        //[Route("/{accessories}/{mark}/{model}")]
        [RequireRouteValues(new[] { "accessories", "mark", "model" })]
        public async Task<ActionResult> CurrentAccessories(string accessories, string mark, string model)
        {
            ViewBag.Mark = mark;
            ViewBag.Model = model;
            ViewBag.Accessories = await Task.Run(() =>
            {
                return _categoryService.GetCategoryByName(accessories);
            });

            ViewBag.Modifications = await Task.Run(() =>
                {
                    return _modificationService.GetModificationByModelName(model);
                });


            return View("~/Views/Catalog/Accessories.cshtml");
        }

        [HttpGet]
        //[Route("/{accessories}/{mark}/{model}")]
        [RequireRouteValues(new[] { "accessories", "mark", "model", "modification" })]
        public async Task<ActionResult> CurrentAccessories(string accessories, string mark, string model, string modification)
        {
            ViewBag.Mark = mark;
            ViewBag.Model = model;
            ViewBag.Accessories = await Task.Run(() =>
            {
                return _categoryService.GetCategoryByName(accessories);
            });

            ViewBag.Modifications = await Task.Run(() =>
            {
                return _modificationService.GetModificationByModelName(model);
            });

            return View("~/Views/Catalog/Accessories.cshtml");
        }

        [HttpGet]
        //[Route("/{accessories}/{mark}/{model}")]
        [RequireRouteValues(new[] { "accessories", "mark", "model", "modification", "brand" })]
        public async Task<ActionResult> CurrentAccessories(string accessories,
                                string mark, string model, string modification, string brand)
        {
            

            return View("~/Views/Catalog/Accessories.cshtml");
        }

    }
}