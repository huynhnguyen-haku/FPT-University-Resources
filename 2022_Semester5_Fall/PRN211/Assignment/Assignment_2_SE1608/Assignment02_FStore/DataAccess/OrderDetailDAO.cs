using BusinessObject;

namespace FStoreAppLibrary.Data_Layer
{
    public class OrderDetailDAO
    {
        //Singleton Pattern
        private static OrderDetailDAO instance = null;
        private static readonly object instanceLock = new object();
        private OrderDetailDAO() { }

        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                    return instance;
                }
            }
        }

        public List<OrderDetail> GetOrderDetails()
        {
            using (FStoreContext fStoreContext = new FStoreContext())
            {
                return fStoreContext.OrderDetails.ToList();
            }
        }

        public OrderDetail GetOrderDetailById(int orderId, int productid)
        {
            using (FStoreContext fStoreContext = new FStoreContext())
            {
                OrderDetail orderDetail = fStoreContext.OrderDetails.Find(orderId, productid);
                return orderDetail;
            }
        }

        public Boolean Delete(int orderId, int productId)
        {
            OrderDetail orderDetail = GetOrderDetailById(orderId, productId);

            if (orderDetail != null)
            {
                using (FStoreContext fStoreContext = new FStoreContext())
                {
                    fStoreContext.OrderDetails.Remove(orderDetail);
                    fStoreContext.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public Boolean Update(OrderDetail orderDetail)
        {
            OrderDetail orderDetail1 = GetOrderDetailById(orderDetail.OrderId, orderDetail.ProductId);

            if (orderDetail1 != null)
            {
                using (FStoreContext fStoreContext = new FStoreContext())
                {
                    fStoreContext.OrderDetails.Attach(orderDetail);
                    fStoreContext.Entry(orderDetail).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    fStoreContext.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public Boolean Insert(OrderDetail orderDetail)
        {
            OrderDetail orderDetail1 = GetOrderDetailById(orderDetail.OrderId, orderDetail.ProductId);

            if (orderDetail1 == null)
            {
                using (FStoreContext fStoreContext = new FStoreContext())
                {
                    fStoreContext.OrderDetails.Attach(orderDetail);
                    fStoreContext.OrderDetails.Add(orderDetail);
                    fStoreContext.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public List<OrderDetail> GetOrderItemsByOrderId(int orderId)
        {
            using (FStoreContext fStoreContext = new FStoreContext())
            {
               return fStoreContext.OrderDetails.Where(s => s.OrderId == orderId).ToList();
            }

        }
    }
}
