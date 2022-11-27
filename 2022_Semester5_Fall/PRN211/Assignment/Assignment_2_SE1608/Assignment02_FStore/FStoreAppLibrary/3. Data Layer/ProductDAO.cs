using BusinessObject;

namespace FStoreAppLibrary.Data_Layer
{
    public class ProductDAO
    {
        private static ProductDAO instance = null;
        private static readonly object instanceLock = new object();
        private ProductDAO() { }

        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }

        public List<Product> GetProducts()
        {
            using (FStoreContext fStoreContext = new FStoreContext())
            {
                return fStoreContext.Products.ToList();
            }
        }

        public List<Product> SearchProducts(string searchBy, string keyword)
        {
            using (FStoreContext fStoreContext = new FStoreContext())
            {
                try
                {
                    switch (searchBy)
                    {
                        case "Product Name":
                            return fStoreContext.Products.Where(p => p.ProductName.Contains(keyword)).ToList();
                            break;
                        case "Product ID":
                            return fStoreContext.Products.Where(p => p.ProductId == int.Parse(keyword)).ToList();
                            break;
                        case "Unit In Stock":
                            return fStoreContext.Products.Where(p => p.UnitStock == int.Parse(keyword)).ToList();
                            break;
                        case "Unit Price":
                            return fStoreContext.Products.Where(p => p.UnitPrice == decimal.Parse(keyword)).ToList();
                            break;
                        default:
                            return null;
                            break;
                    }
                } catch(Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public Product GetProductById(int producId)
        {
            using (FStoreContext fStoreContext = new FStoreContext())
            {
                Product product = fStoreContext.Products.Find(producId);
                return product;
            }
        }

        public Boolean Delete(int producId)
        {
            Product product = GetProductById(producId);

            if (product != null)
            {
                using (FStoreContext fStoreContext = new FStoreContext())
                {
                    fStoreContext.Products.Remove(product);
                    fStoreContext.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public Boolean Update(Product product)
        {
            Product product1 = GetProductById(product.ProductId);

            if (product1 != null)
            {
                using (FStoreContext fStoreContext = new FStoreContext())
                {
                    fStoreContext.Products.Attach(product);
                    fStoreContext.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    fStoreContext.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public Boolean Insert(Product product)
        {
            Product product1 = GetProductById(product.ProductId);

            if (product1 == null)
            {
                using (FStoreContext fStoreContext = new FStoreContext())
                {
                    fStoreContext.Products.Attach(product);
                    fStoreContext.Products.Add(product);
                    fStoreContext.SaveChanges();
                    return true;
                }
            }
            return false;
        }

    }
}
