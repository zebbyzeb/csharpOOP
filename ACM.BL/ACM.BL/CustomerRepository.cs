using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository { get; set; }

        public CustomerRepository()
        {
            this.addressRepository = new AddressRepository();
        }

        public Customer Retrieve(int customerId)
        {           
            Customer customer = new Customer(customerId);
            customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
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
            bool success = true;

            if (customer.HasChanges && customer.IsValid)
            {
                if (customer.IsNew)
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
