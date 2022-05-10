using DoceriaDocesSonhos.Models;
using DoceriaDocesSonhos.Validator;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoceriaDocesSonhos.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            ProductValidator productValidator = new ProductValidator();
            var result = productValidator.Validate(product);
            return View();
        }
    }
}
