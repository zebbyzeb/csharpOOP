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
            string source = "LakesideDrive";
            string expected = "Lakeside Drive";

            //Act
            string actual = source.InsertSpace();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestStringHandler2()
        {
            //Arrange
            string expected = "Lakeside Drive";

            //Act
            string source = "LakesideDrive";
            string actual = source.InsertSpace();

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
