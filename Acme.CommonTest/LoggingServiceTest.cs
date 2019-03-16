using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;
using System.Collections.Generic;
using Acme.Common;

namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            //Arrange

            var customer = new Customer()
            {
                FirstName = "abc",
                LastName = "def",
                EmailAddress = "you@yours.com"
            };

            var myList = new List<ILoggable>();

            myList.Add(customer);

            var expected = "0: def,abc Email: you@yours.com";

            //Act

            var loggableService = new LoggingService();
            loggableService.WriteToFile(myList);

            //Assert
            Assert.AreEqual(expected, loggableService.outputLogs[0]);
        }
    }
}
