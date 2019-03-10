using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Common;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void TestStringHandler()
        {
            //Arrange
            string expected = "Lakeside Drive";

            //Act
            StringHandler stringHandler = new StringHandler();

            string actual = stringHandler.InsertSpace("LakesideDrive");

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestStringHandler2()
        {
            //Arrange
            string expected = "Lakeside Drive";

            //Act
            StringHandler stringHandler = new StringHandler();

            string actual = stringHandler.InsertSpace("Lakeside Drive");

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
