using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FStoreAppLibrary.Data_Layer.Repository
{
    public interface IOrderDetailRepository
    {
        List<OrderDetail> GetOrderDetails();
        OrderDetail GetOrderDetailById(int orderId, int productId);
        Boolean InsertOrderDetail(OrderDetail orderDetail);
        Boolean UpdateOrderDetail(OrderDetail orderDetail);
        Boolean DeleteOrderDetail(int orderId, int productId);
       
    }
}
