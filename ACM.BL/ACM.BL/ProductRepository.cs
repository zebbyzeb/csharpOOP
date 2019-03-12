using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);
            if (product.ProductId == 1)
            {
                product.ProductName = "HydroChlorine";
                product.ProductDescription = "Part of Chemicals";
            }
            return product;
        }

        public List<Product> Retrieve()
        {
            return new List<Product>();
        }

        public bool Save(Product product)
        {
            bool success = true;

            if (product.HasChanges && product.IsValid)
            {
                if (product.IsNew)
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
