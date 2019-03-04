using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveExisting()
        {
            //Arrange
            CustomerRepository customerRepository = new CustomerRepository();
            Customer expected = new Customer(1);
            expected.EmailAddress = "abc";
            expected.FirstName = "Zebby";
            expected.LastName = "Khairah";

            //Act
            Customer actual = customerRepository.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
        }
    }
}
