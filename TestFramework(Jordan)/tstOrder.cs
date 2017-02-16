using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using clslibrary;

namespace TestFramework
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrder AnOrder = new clsOrder();
            //test to see it exists
            Assert.IsNotNull(AnOrder);
        }
        [TestMethod]
        public void OrderDateOK()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.DateOrdered = TestData;
            //test to see it exists
            Assert.AreEqual(AnOrder.DateOrdered, TestData);
        }
        [TestMethod]
        public void OrderNoOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 111;
            //assign the data to the property
            AnOrder.OrderNo = TestData;
            //test to see it exists
            Assert.AreEqual(AnOrder.OrderNo, TestData);

        }
        [TestMethod]
        public void PriceOK()
        {
            clsOrder AnOrder = new clsOrder();
            Double TestData = 1.00;
            //assign the data to the property
            AnOrder.OrderPrice = TestData;
            //test to see it exists
            Assert.AreEqual(AnOrder.OrderPrice, TestData);

        }
        [TestMethod]
        public void ProductNameOK()
        {
            clsOrder AnOrder = new clsOrder();
            String TestData = "Hp Compaq Elite 8300";
            //assign the data to the property
            AnOrder.ProductName = TestData;
            //test to see it exists
            Assert.AreEqual(AnOrder.ProductName, TestData);

        }
        [TestMethod]
        public void ProductNoOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 111;
            //assign the data to the property
            AnOrder.ProductNo = TestData;
            //test to see it exists
            Assert.AreEqual(AnOrder.ProductNo, TestData);

        }
        [TestMethod]
        public void QuantityNoOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.QuantityNo = TestData;
            //test to see it exists
            Assert.AreEqual(AnOrder.QuantityNo, TestData);

        }
    }
}
