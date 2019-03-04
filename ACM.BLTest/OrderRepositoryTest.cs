using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveExisting()
        {
            //Arrange
            Order expected = new Order();
            expected.OrderDate = new DateTimeOffset(2019, 3, 4, 22, 11, 0, TimeSpan.FromHours(8.5));

            OrderRepository orderRepository = new OrderRepository();

            //Act
            Order actual = orderRepository.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
    }
}
