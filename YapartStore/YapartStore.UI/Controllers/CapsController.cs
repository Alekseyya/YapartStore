using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using YapartStore.UI.Models;
using YapartStore.UI.Services.Base;
using YapartStore.UI.ViewModels;

namespace YapartStore.UI.Controllers
{
    public class CapsController : Controller
    {
        private readonly IProductService _productService;
        public CapsController(IProductService productService)
        {
            _productService = productService;
        }

        private List<SelectListItem> GetSizeCaps()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem() {Text = "13", Value = "13"},
                new SelectListItem() {Text = "14", Value = "14"},
                new SelectListItem() {Text = "15", Value = "15"},
                new SelectListItem() {Text = "16", Value = "16"}
            };
        }

        [HttpGet]
        public async Task<ActionResult> Index(int page = 1)
        {
            int pageSize = 7;
            var products = await _productService.GetAllCaps();
            var productPerPage = products.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            var pageInfo = new PageInfo { PageNumber = page, PageSize = pageSize, TotalItems = products.Count };
            var catalog = new CapsCatalogViewModel { PageInfo = pageInfo, Products = productPerPage };
            catalog.CapsSize = GetSizeCaps().AsEnumerable();
            return View(catalog);
        }

        [HttpPost]
        public async Task<ActionResult> Index(CapsCatalogViewModel model, int page = 1)
        {
            int pageSize = 7;
            var caps = await _productService.GetSizeOfCaps(model.SelectedId);
            //else error
            
            var productPerPage = caps.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            var pageInfo = new PageInfo { PageNumber = page, PageSize = pageSize, TotalItems = caps.Count };
            var catalog = new CapsCatalogViewModel { PageInfo = pageInfo, Products = productPerPage };
            catalog.CapsSize = GetSizeCaps().AsEnumerable();
            return View(catalog);
        }
    }
}