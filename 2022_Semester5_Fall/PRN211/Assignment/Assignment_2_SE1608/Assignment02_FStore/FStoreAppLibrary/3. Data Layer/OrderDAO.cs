using BusinessObject;

namespace FStoreAppLibrary.Data_Layer
{
    public class OrderDAO
    {
        private static OrderDAO instance = null;
        private static readonly object instanceLock = new object();
        private OrderDAO() { }

        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }

        public List<Order> GetOrders()
        {
            using (FStoreContext fStoreContext = new FStoreContext())
            {
                return fStoreContext.Orders.ToList();
            }
        }

        public List<Order> GetOrdersByMenberId(int memberId)
        {
            using (FStoreContext fStoreContext = new FStoreContext())
            {
                return fStoreContext.Orders.Where(p => p.MemberId == memberId).ToList();
            }
        }

        public List<Order> GetOrdersInDateRange(DateTime startDate, DateTime endDate)
        {
            using (FStoreContext fStoreContext = new FStoreContext())
            {
                return fStoreContext.Orders.Where(p => p.OrderDate >= startDate && p.OrderDate <= endDate )
                    .OrderByDescending(p => p.OrderDate).ToList();
            }
        }

        public Order GetOrderById(int orderId)
        {
            using (FStoreContext fStoreContext = new FStoreContext())
            {
                Order order = fStoreContext.Orders.Find(orderId);
                return order;
            }
        }

        public Boolean Delete(int orderId)
        {
            Order order = GetOrderById(orderId);

            if (order != null)
            {
                using (FStoreContext fStoreContext = new FStoreContext())
                {
                    fStoreContext.Orders.Remove(order);
                    fStoreContext.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public Boolean Update(Order order)
        {
            Order order1 = GetOrderById(order.OrderId);

            if (order1 != null)
            {
                using (FStoreContext fStoreContext = new FStoreContext())
                {
                    fStoreContext.Orders.Attach(order);
                    fStoreContext.Entry(order).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    fStoreContext.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public Boolean Insert(Order order)
        {
            Order order1 = GetOrderById(order.OrderId);

            if (order1 == null)
            {
                using (FStoreContext fStoreContext = new FStoreContext())
                {
                    fStoreContext.Orders.Attach(order);
                    fStoreContext.Orders.Add(order);
                    fStoreContext.SaveChanges();
                    return true;
                }
            }
            return false;
        }
    }
}
