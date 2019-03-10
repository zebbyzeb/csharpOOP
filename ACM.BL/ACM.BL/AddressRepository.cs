using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);
            if (addressId == 1)
            {
                address.StreetLine1 = "27b";
                address.StreetLine2 = "Lakeside Dr";
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            List<Address> addressList = new List<Address>();
            Address address = new Address(1)
            {
                StreetLine1 = "27b",
                StreetLine2 = "Lakeside Dr"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                StreetLine1 = "F-10",
                StreetLine2 = "Sai Apartments"
            };
            addressList.Add(address);

            return addressList;
        }

        public bool Save(Address address)
        {
            bool success = true;

            if (address.HasChanges && address.IsValid)
            {
                if (address.IsNew)
                {
                    //call an Insert stored prrocedure
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
