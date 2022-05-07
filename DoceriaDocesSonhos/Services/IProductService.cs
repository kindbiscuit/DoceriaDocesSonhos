using DoceriaDocesSonhos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoceriaDocesSonhos.Services
{
    public interface IProductService
    {
        public IEnumerable<Product> getAllProducts();
        public Product getProductById();
        public void removeProductById();


    }
}
