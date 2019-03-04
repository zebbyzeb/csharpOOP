using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameValidTest()
        {
            //Arrange
            Customer customer = new Customer();
            customer.FirstName = "Zebby";
            customer.LastName = "Khairah";

            string expected = "Khairah,Zebby";
            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FirstNameOnlyTest()
        {
            //Arrange
            Customer customer = new Customer();
            customer.FirstName = "Zebby";
            customer.LastName = "";

            string expected = "Zebby";
            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LastNameOnlyTest()
        {
            //Arrange
            Customer customer = new Customer();
            customer.FirstName = "";
            customer.LastName = "Khairah";

            string expected = "Khairah";
            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //Arrange
            Customer c1 = new Customer();
            Customer.InstanceCount += 1;
            Customer c2 = new Customer();
            Customer.InstanceCount += 1;
            Customer c3 = new Customer();
            Customer.InstanceCount += 1;

            int expected = 3;

            //Act
            int actual = Customer.InstanceCount;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateTestFail()
        {
            //Arrange
            Customer customer = new Customer();
            customer.EmailAddress = "";
            customer.LastName = "Khairah";

            bool expected = false;

            //act
            bool actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateTestPass()
        {
            //Arrange
            Customer customer = new Customer();
            customer.EmailAddress = "bla";
            customer.LastName = "Khairah";

            bool expected = true;

            //act
            bool actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
