﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            this.ProductId = productId;
        }

        public Decimal? CurrentPrice { get; set; }

        public int ProductId { get; private set; }

        public string ProductDescription { get; set; }

        public string ProductName { get; set; }

        public override bool Validate()
        {
            bool isValid = true;
            if(string.IsNullOrWhiteSpace(ProductName) || CurrentPrice == null)
            {
                return isValid = false;
            }
            return isValid;
        }

        public override string ToString()
        {
            return ProductName;
        }
    }
}
