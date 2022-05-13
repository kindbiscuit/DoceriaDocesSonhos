using DoceriaDocesSonhos.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DoceriaDocesSonhos.Manager.Interfaces
{
    public interface IProductManager
    {
        public void newProductManager(Product product);
        public IEnumerable<Product> getAllProductsManager();
        public Product getProductByIdManager(int id);

    }
}
