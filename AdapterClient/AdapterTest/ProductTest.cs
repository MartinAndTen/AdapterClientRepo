using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductLib;

namespace AdapterTest
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void TestIfProductReturnsCorrectValue()
        {
            //Arrange
            string expectedCode = "1234";
            decimal expectedPrice = 99;
            string expectedProductName = "honda";
            //Act
            var product = new Product("honda", 99, "1234");
            //Assert
            Assert.AreEqual(expectedCode, product.Code);
            Assert.AreEqual(expectedPrice, product.Price);
            Assert.AreEqual(expectedProductName, product.ProductName);
        }
    }
}
