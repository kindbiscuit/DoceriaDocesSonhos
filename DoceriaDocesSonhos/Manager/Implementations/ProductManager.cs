using DoceriaDocesSonhos.Data.Repository;
using DoceriaDocesSonhos.Manager.Interfaces;
using DoceriaDocesSonhos.Models;
using DoceriaDocesSonhos.Validator;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DoceriaDocesSonhos.Manager.Implementations
{
    public class ProductManager : IProductManager
    {
        IProductRepository _productRepository;
        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IEnumerable<Product> getAllProductsManager()
        {
            return _productRepository.getAllProducts();
        }

        public Product getProductByIdManager(int id)
        {
            return _productRepository.getProductById(id);
        }

        public void newProductManager(Product product)
        {
            ProductValidator productValidator = new ProductValidator();
            var result = productValidator.Validate(product);
            if (result.IsValid)
            {
                _productRepository.newProduct(product);
            }
            

        }
    }
}
