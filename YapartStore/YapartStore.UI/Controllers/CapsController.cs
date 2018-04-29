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

        public async Task<ActionResult> Index(int page=1)
        {
            //int pageSize = 3;
            //var products = await _productService.GetAllProducts();
            //var productPerPage = products.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            //var pageInfo = new PageInfo { PageNumber = page, PageSize = pageSize, TotalItems = products.Count };
            //var catalog = new CapsCatalogViewModel { PageInfo = pageInfo, Products = productPerPage };
            //return View(catalog);
            return View();
        }
    }
}