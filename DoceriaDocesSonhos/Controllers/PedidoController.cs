using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoceriaDocesSonhos.Controllers
{
    public class PedidoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View("pedido");
        }
    }
}
