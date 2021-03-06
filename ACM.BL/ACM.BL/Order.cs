﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order : EntityBase
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            this.OrderId = orderId;
        }

        public int CustomerId { get; set; }

        public int ShippingAddressId { get; set; }

        public DateTimeOffset? OrderDate { get; set; }

        public int OrderId { get; private set; }

        public List<OrderItem> orderItems { get; set; }

        public override string ToString()
        {
            return OrderDate.Value.Date + "(" + OrderId + ")";
        }

        public override bool Validate()
        {
            return true;
        }
    }
}
