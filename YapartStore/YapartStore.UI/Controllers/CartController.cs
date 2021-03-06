﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using YapartStore.UI.Services.Base;
using YapartStore.UI.ViewModels;

namespace YapartStore.UI.Controllers
{
    public class CartController : Controller
    {
        private IProductService _productService;

        public CartController(IProductService productService)
        {
            _productService = productService;
        }
        public ActionResult Index()
        {
            if (Session["Cart"] == null)
                return RedirectToAction("Index", "Caps");
            CartViewModel cart = Session["Cart"] as CartViewModel;
            
            return View(cart);
        }

        [HttpPost]
        public async Task<ActionResult> AddToCart(string article)
        {
            CartViewModel cart = Session["Cart"] as CartViewModel;
            if (cart == null || Session["Cart"] == null)
            {
                cart = new CartViewModel();
                cart.Lines = new List<ProductViewModel>();
                Session["Cart"] = cart;
                Session["CountInCart"] = 1;
                var product = await _productService.GetProductByArticle(article);
                product.Quantity = 1;
                Session["TotalConstInCart"] = product.Price;
                cart.Lines.Add(product);
            }
            else
            {
                var inCart = (CartViewModel)Session["Cart"];
                if (inCart.Lines.Any(res => res.Article == article))
                {
                    var product = inCart.Lines.First(res => res.Article == article);
                    product.Quantity++;
                    Session["TotalConstInCart"] = (decimal)Session["TotalConstInCart"] + product.Price;
                }
                else
                {
                    var product = await _productService.GetProductByArticle(article);
                    product.Quantity++;
                    inCart.Lines.Add(product);
                    Session["TotalConstInCart"] = (decimal)Session["TotalConstInCart"] + product.Price;
                }

                Session["CountInCart"] = Convert.ToInt32(Session["CountInCart"]) + 1;
            }
            
            return RedirectToAction("Index", "Caps");
        }

        [HttpGet]
        public ActionResult RemoteItem(string article)
        {
            var cart = (CartViewModel) Session["Cart"];
            var product = cart.Lines.First(res => res.Article == article);
            var countInCart = (int)Session["CountInCart"];
            var totalPrice = (decimal) Session["TotalConstInCart"];
            if (product.Quantity >= 2)
            {
                product.Quantity--;
                countInCart--;
                totalPrice -= product.Price;
            }
            else
            {
                totalPrice -= product.Price;
                cart.Lines.Remove(product);
                countInCart--;
            }

            Session["TotalConstInCart"] = totalPrice;
            Session["CountInCart"] = countInCart;
            return RedirectToAction("Index", "Cart");
        }

       

        public async Task<ActionResult> GetUserCart()
        {
            //<----------- пополнение корзины
            return null;
        }
    }
}