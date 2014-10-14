using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductLib;
using ProductAdapterLib;

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

        [TestMethod]
        public void TestIfExternalProductReturnsCorrectValues()
        {
            //Arrange
            var extProduct = new ExternalProduct();
            extProduct.Title = "ktm";
            extProduct.Price = 100;
            extProduct.EANCode = "12345";
            //Act
            IProduct product = new ExternalProductAdapterLib(extProduct);
            //Assert
            Assert.AreEqual(extProduct.Title, product.ProductName);
            Assert.AreEqual(extProduct.EANCode, product.Code);
            Assert.AreEqual(extProduct.Price, product.Price);
        }
    }
}
