﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Common;

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

        private string _ProductName;

        public string ProductName
        {
            get {
                return StringHandler.InsertSpace(_ProductName); }
            set { _ProductName = value; }
        }


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
