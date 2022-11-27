using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FStoreAppLibrary.Data_Layer.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public bool DeleteOrderDetail(int orderId, int productId) => OrderDetailDAO.Instance.Delete(orderId, productId);

        public OrderDetail GetOrderDetailById(int orderId, int productId) => OrderDetailDAO.Instance.GetOrderDetailById(orderId, productId);
        public List<OrderDetail> GetOrderDetails() => OrderDetailDAO.Instance.GetOrderDetails();

        public bool InsertOrderDetail(OrderDetail orderDetail) => OrderDetailDAO.Instance.Insert(orderDetail);

        public bool UpdateOrderDetail(OrderDetail orderDetail) => OrderDetailDAO.Instance.Update(orderDetail);

        public List<OrderDetail> GetOrderItemsByOrderId(int orderId) => OrderDetailDAO.Instance.GetOrderItemsByOrderId(orderId);
    }
}
