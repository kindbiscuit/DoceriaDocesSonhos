using DoceriaDocesSonhos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoceriaDocesSonhos.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        private ApplicationContext _applicationContext;
        public ProductRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }
        public IEnumerable<Product> getAllProducts()
        {
            return _applicationContext.produtos.ToList();
        }

        public Product getProductById(int id)
        {
            return _applicationContext.produtos.Find(id);
        }

        public void newProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
