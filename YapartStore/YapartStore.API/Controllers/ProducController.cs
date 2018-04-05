using System;
using System.Collections.Generic;
using System.Web.Http;
using YapartStore.BL.Entities;
using YapartStore.BL.Services.Base;

namespace YapartStore.API.Controllers
{
    public class ProducController : ApiController
    {
        private readonly IProductService _productService;
        public ProducController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IEnumerable<ProductDTO> GetProducts()
        {
            var products = _productService.GetAll();
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
