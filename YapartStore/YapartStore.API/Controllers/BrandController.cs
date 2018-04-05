using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using YapartStore.BL.Entities;
using YapartStore.BL.Services.Base;

namespace YapartStore.API.Controllers
{
    public class BrandController : ApiController
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpPost]
        public HttpResponseMessage AddBrand(BrandDTO brand)
        {
            if (ModelState.IsValid)
            {
                _brandService.AddItem(brand);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            else
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }

        [HttpPost]
        public HttpResponseMessage UpdateBrand(BrandDTO brand)
        {
            if (ModelState.IsValid)
            {
                _brandService.UpdateItem(brand);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            else
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }

        [HttpDelete]
        public HttpResponseMessage DeleteBrand(string brandName)
        {
            if (ModelState.IsValid)
            {
                _brandService.DeleteByName(brandName);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            else
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }

        [HttpGet]
        public IEnumerable<BrandDTO> GetBrands()
        {
            var brands = _brandService.GetAll().AsEnumerable();
            return brands;
        }
    }
}
