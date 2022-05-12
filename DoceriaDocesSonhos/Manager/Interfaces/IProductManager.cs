using DoceriaDocesSonhos.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoceriaDocesSonhos.Manager.Interfaces
{
    public interface IProductManager
    {
        public IEnumerable<Product> getAllProducts();
        public Product getProductById();

    }
}
