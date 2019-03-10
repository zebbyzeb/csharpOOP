using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer : EntityBase
    {
        public Customer()
            :this(0)
        {

        }
        public Customer(int customerId)
        {
            this.CustomerId = customerId;
            this.AddressList = new List<Address>();
        }

        public int CustomerType { get; set; }
        
        //public Address WorkAddress { get; set; }

        //public Address MyProperty { get; set; }

        //Can either have two types of addresses or can have an address list to keep all the addresses.
        public List<Address> AddressList { get; set; }

        public static int InstanceCount { get; set; }

        public string FirstName { get; set; }

        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public string EmailAddress { get; set; }

        public int CustomerId { get; private set; }

        public string FullName
        {
            get
            {

                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(LastName))
                    {
                        return LastName + "," + FirstName;
                    }
                    return FirstName;
                }
                return LastName;

            }
        }

        public override bool Validate()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(EmailAddress) || string.IsNullOrWhiteSpace(LastName))
            {
                return isValid = false;
            }
            return isValid;
        }

        public override string ToString()
        {
            return FullName;
        }
    }
}
