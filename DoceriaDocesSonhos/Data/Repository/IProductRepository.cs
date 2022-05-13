using DoceriaDocesSonhos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoceriaDocesSonhos.Data.Repository
{
    public interface IProductRepository
    {
        public IEnumerable<Product> getAllProducts();
        public Product getProductById(int id);
        public void newProduct(Product product);
    }
}
