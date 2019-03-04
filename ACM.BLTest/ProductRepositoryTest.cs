using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveExisting()
        {
            //Arrange
            Product expected = new Product();
            expected.ProductName = "Chlorine";
            expected.ProductDescription = "Part of Chemicals";

            ProductRepository productRepository = new ProductRepository();

            //act
            Product actual = productRepository.Retrieve(1);

            //assert
            Assert.AreEqual(expected.ProductName, actual.ProductName);
        }
    }
}
