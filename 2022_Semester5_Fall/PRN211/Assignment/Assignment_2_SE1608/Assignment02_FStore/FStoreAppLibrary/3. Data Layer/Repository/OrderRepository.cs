using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FStoreAppLibrary.Data_Layer.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public bool DeleteOrder(int orderId) => OrderDAO.Instance.Delete(orderId);

        public Order GetOrderById(int orderId) => OrderDAO.Instance.GetOrderById(orderId);

        public List<Order> GetOrders() => OrderDAO.Instance.GetOrders();

        public List<Order> GetOrdersByMemberId(int memberId) => OrderDAO.Instance.GetOrdersByMenberId(memberId);

        public List<Order> GetOrdersInDateRange(DateTime startDate, DateTime endDate) => OrderDAO.Instance.GetOrdersInDateRange(startDate, endDate);
       
        public bool InsertOrder(Order order) => OrderDAO.Instance.Insert(order);

        public bool UpdateOrder(Order order) => OrderDAO.Instance.Update(order);
    }
}
