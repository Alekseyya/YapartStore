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
    public class CatalogController : Controller
    {
        private readonly IProductService _productService;
        //private readonly IBrandService _brandService;
        public CatalogController(IProductService productService)
        {
            _productService = productService;
            //_brandService = brandService;
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
        public ActionResult Cars(string car)
        {
            IEnumerable<CarViewModel> listCars = new List<CarViewModel>()
            {
                new CarViewModel() {Id = 1, Car = "Audi",Popular = true, Model = "A1",
                    Image = @"C:/Work/YapartStore/YapartStore/YapartStore.UI/Content/Images/Cars/Audi/A1.png", Years = 2004},
                new CarViewModel() {Id = 2, Car = "Audi",Popular = true, Model = "A3",
                    Image = @"C:/Work/YapartStore/YapartStore/YapartStore.UI/Content/Images/Cars/Audi/A3.png", Years = 2005},
                new CarViewModel() {Id = 3, Car = "Audi",Popular = false, Model = "A4",
                    Image = @"C:/Work/YapartStore/YapartStore/YapartStore.UI/Content/Images/Cars/Audi/A4.png", Years = 2007},
                new CarViewModel() {Id = 4, Car = "Audi",Popular = true, Model = "A5",
                    Image = @"C:/Work/YapartStore/YapartStore/YapartStore.UI/Content/Images/Cars/Audi/A5.png", Years = 2008},
                new CarViewModel() {Id = 5, Car = "Audi", Popular = false, Model = "A6",
                    Image = @"C:/Work/YapartStore/YapartStore/YapartStore.UI/Content/Images/Cars/Audi/A6.png", Years = 2009},
               };

            return View(listCars);
        }

        //public async Task<ActionResult> Cars(string car, string model)
        //{

        //    return View();
        //}
    }
}