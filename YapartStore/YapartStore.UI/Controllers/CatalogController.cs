﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using YapartStore.UI.Models;
using YapartStore.UI.Services.Base;

namespace YapartStore.UI.Controllers
{
    public class CatalogController : Controller
    {
        private readonly IProductService _productService;
        private readonly IBrandService _brandService;
        public CatalogController(IProductService productService, IBrandService brandService)
        {
            _productService = productService;
            _brandService = brandService;
        }
        public async Task<ActionResult> Index(int page = 1)
        {
            //int pageSize = 3;
            //var products = await _productService.GetAllProducts();
            //var productPerPage = products.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            //var pageInfo = new PageInfo { PageNumber = page, PageSize = pageSize, TotalItems = products.Count };
            //var catalog = new CatalogViewModel { PageInfo = pageInfo, Products = productPerPage };
            //return View(catalog);
            return View();
        }
    }
}