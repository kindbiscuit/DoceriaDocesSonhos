using DoceriaDocesSonhos.Models;
using DoceriaDocesSonhos.Models.Enums;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoceriaDocesSonhos.ViewComponents
{
    [ViewComponent(Name = "Cart")]
    public class CartViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Cart> listaDeCarrinho = new List<Cart>( );
            listaDeCarrinho.Add(new Cart(0,1, new Product("Docinho","Doce gostoso", 10, 20, EnumTipoDeDoce.Brownie),2));
            listaDeCarrinho.Add(new Cart(0,1, new Product("Docinho 15 conto","Doce gostoso", 15, 30, EnumTipoDeDoce.Brownie),1));
            listaDeCarrinho.Add(new Cart(0,1, new Product("Docinho 15 conto","Doce gostoso", 15, 30, EnumTipoDeDoce.Brownie),1));
            return View(listaDeCarrinho);
        }
    }
}
