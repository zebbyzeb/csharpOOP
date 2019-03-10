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

        public OrderDisplay RetrieveOrderDisplay(int orderId)
        {
            OrderDisplay orderDisplay = new OrderDisplay();

            if (orderId == 10)
            {
                orderDisplay.FirstName = "Zebby";
                orderDisplay.ShippingAddress = new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "27 Lakeside Dr"
                };
            }

            orderDisplay.orderDisplayItemList = new List<OrderDisplayItem>();

            if (orderId == 10)
            {
                OrderDisplayItem orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Sunflowers",
                    OrderQuantity = 5
                };

                orderDisplay.orderDisplayItemList.Add(orderDisplayItem);

                orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Cakes",
                    OrderQuantity = 6
                };

                orderDisplay.orderDisplayItemList.Add(orderDisplayItem);
            }

            return orderDisplay;
        }

        public bool Save(Order order)
        {
            bool success = true;

            if (order.HasChanges && order.IsValid)
            {
                if (order.IsNew)
                {
                    //call an Insert stored procedure
                }
                else
                {
                    //call an Update stored procedure
                }
            }

            return success;
        }
    }
}
