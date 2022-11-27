using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FStoreAppLibrary.Data_Layer.Repository
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
        Product GetProductById(int productId);
        Boolean InsertProduct(Product product);
        Boolean UpdateProduct(Product product);
        Boolean DeleteProduct(int productId);

    }
}
