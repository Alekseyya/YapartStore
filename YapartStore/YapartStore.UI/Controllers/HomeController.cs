using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using Newtonsoft.Json;
using YapartStore.UI.Models;
using YapartStore.UI.Services;
using YapartStore.UI.Services.Base;
using YapartStore.UI.ViewModels;

namespace YapartStore.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMarkService _markService;
        public HomeController(IProductService productService, IMarkService markService)
        {
            _productService = productService;
            _markService = markService;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public async Task<ActionResult> GetAllProducts()
        {
            try
            {
                var products = await _productService.GetAllProducts();
                return View(products);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpGet]
        public async Task<ActionResult> GetProductsOfBrand(string brand)
        {
            try
            {
                var products = await _productService.GetProductsOfBrand(brand);
                return View(products);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpGet]
        public async Task<ActionResult> GetAllMarks()
        {
            var marks = await _markService.GetAllMarks();
            var listmarksForJson = marks.Select(x => new {x.Name, x.Show});
            return Json(JsonConvert.SerializeObject(listmarksForJson), JsonRequestBehavior.AllowGet);
        }
    }
}