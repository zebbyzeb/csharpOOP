using System;
using System.Collections.Generic;
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

        [TestMethod]
        public void RetrieveOrderDisplayTest()
        {
            //Arrange
            OrderDisplay expected = new OrderDisplay()
            {
                FirstName = "Zebby",
                ShippingAddress = new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "27 Lakeside Dr"
                },
                orderDisplayItemList = new List<OrderDisplayItem>()
                {
                    new OrderDisplayItem()
                    {
                        ProductName = "Sunflowers",
                        OrderQuantity = 5
                    },

                    new OrderDisplayItem()
                    {
                        ProductName = "Cakes",
                        OrderQuantity = 6
                    }
                }
            };

            //Act
            OrderRepository orderRepository = new OrderRepository();
            OrderDisplay actual = orderRepository.RetrieveOrderDisplay(10);

            //Assert
            for(int i=0; i<actual.orderDisplayItemList.ToArray().Length; i++)
            {
                Assert.AreEqual(expected.orderDisplayItemList[i].ProductName, actual.orderDisplayItemList[i].ProductName);
                Assert.AreEqual(expected.orderDisplayItemList[i].OrderQuantity, actual.orderDisplayItemList[i].OrderQuantity);

            }
        }
    }
}