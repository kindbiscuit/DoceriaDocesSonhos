using DoceriaDocesSonhos.Models;
using DoceriaDocesSonhos.Manager.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoceriaDocesSonhos.Controllers
{
    public class CartController : Controller
    {
        //private ICartManager _cartManager { get; set; }
        //public CartController(ICartManager cartManager) {
        //    _cartManager = cartManager;
        //}
        [HttpGet]
        public IActionResult Index()
        {
            return View("carrinho");
        }
        //public IActionResult Add(Cart cart)
        //{
        //   _cartManager.AddCart(cart);
        //    return View();
        //}
        //public IActionResult Delete(Cart cart)
        //{
        //    _cartManager.DeleteCart(cart);
        //    return View();
        //}
    }
}
