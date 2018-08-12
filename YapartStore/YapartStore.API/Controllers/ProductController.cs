using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using YapartStore.API.Helpers;
using YapartStore.BL.Entities;
using YapartStore.BL.Services.Base;

namespace YapartStore.API.Controllers
{
    [EnableCors(origins: "http://localhost:58823", headers: "*", methods: "*")]
    public class ProductController : ApiController
    {
        private readonly IProductService _productService;
        private readonly IPictureService _pictureService;

        public ProductController(IProductService productService, IPictureService pictureService)
        {
            _productService = productService;
            _pictureService = pictureService;
        }

        [HttpGet]
        public IEnumerable<ProductDTO> GetProducts()
        {
            var products = _productService.GetAll().ChangePathImage();
            if (products == null)
                return null;
            return products;
        }

        [HttpGet]
        public IEnumerable<ProductDTO> GetAllCaps()
        {
            var products = _productService.GetAllCaps().ChangePathImage();
            if (products == null)
                return null;
            return products;
        }

        [HttpGet]
        public IEnumerable<ProductDTO> GetProductsByModification(string modificationName)
        {
            return null;
        }

        [HttpGet]
        public IEnumerable<ProductDTO> GetSizeCaps()
        {
            return null;
        }

        [HttpPost]
        public IEnumerable<ProductDTO> GetSizeCaps(int size)
        {
            return _productService.GetSizeOfCaps(size).ChangePathImage();
        }

        [HttpGet]
        public ProductDTO GetProductByArticle(string article)
        {
            return _productService.GetProductByArticle(article).ChangePathImage();
        }

        [HttpGet]
        public IEnumerable<ProductDTO> GetProductsOfBrand(string brand)
        {
            var products = _productService.GetAllProductsOfBrand(brand).AsEnumerable();
            return products;
        }

        [HttpPost]
        public IHttpActionResult AddProduct(ProductDTO product)
        {
            if (ModelState.IsValid)
            {
                _productService.AddItem(product);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IHttpActionResult DeleteProduct(string article)
        {
            try
            {
                _productService.DeleteItem(article);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
