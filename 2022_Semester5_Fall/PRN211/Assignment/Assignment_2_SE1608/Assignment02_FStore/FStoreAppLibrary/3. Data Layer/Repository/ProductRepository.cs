using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FStoreAppLibrary.Data_Layer.Repository
{
    public class ProductRepository : IProductRepository
    {
        public bool DeleteProduct(int productId) => ProductDAO.Instance.Delete(productId);

        public Product GetProductById(int productId) => ProductDAO.Instance.GetProductById(productId);

        public List<Product> GetProducts() => ProductDAO.Instance.GetProducts();

        public bool InsertProduct(Product product) => ProductDAO.Instance.Insert(product);

        public bool UpdateProduct(Product product) => ProductDAO.Instance.Update(product);

        public List<Product> Searching(string searchBy, string keyword) => ProductDAO.Instance.SearchProducts(searchBy, keyword);
    }
}
