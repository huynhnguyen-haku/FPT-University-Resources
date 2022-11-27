using System;
using System.Collections.Generic;

namespace BusinessObject
{
    public partial class OrderDetail
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }

        public virtual Order Order { get; set; } = null!;
        public virtual Product OrderNavigation { get; set; } = null!;

        public override string? ToString()
        {
            return $"OrderID: {OrderId}; ProductID: {ProductId}";
        }
    }
}
