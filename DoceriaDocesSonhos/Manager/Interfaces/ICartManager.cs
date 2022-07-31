using DoceriaDocesSonhos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoceriaDocesSonhos.Manager.Interfaces
{
    public interface ICartManager
    {
        public void AddCart(Cart cart);
        public void DeleteCart(Cart cart);
    }
}
