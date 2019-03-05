using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            //Customer c = new Customer();
            
            Customer customer = new Customer(customerId);

            if(customerId == 1)
            {
                customer.EmailAddress = "abc";
                customer.FirstName = "Zebby";
                customer.LastName = "Khairah";
            }
            return customer;
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
