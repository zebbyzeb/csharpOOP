using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            if(order.OrderId == 1)
            {
                order.OrderDate = new DateTimeOffset(2019,3,4,22,11,0,TimeSpan.FromHours(8.5));
            }
            return order;
        }

        public bool Save()
        {
            return true;
        }
    }
}
