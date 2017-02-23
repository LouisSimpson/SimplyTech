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
        public void QuantityNoOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.QuantityNo = TestData;
            //test to see it exists
            Assert.AreEqual(AnOrder.QuantityNo, TestData);

        }
        [TestMethod]
        public void FindMethodOK()
        {
            //Create instance of the class to create
            clsOrder AnOrder = new clsOrder();
            //create some test data
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderNo = 1;
            //invoke method
            Found = AnOrder.Find(OrderNo);
            //test to see result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderNumberFound()
        {
            //Create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 10;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.OrderNo != 10)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOrderedFound()
        {
            //Create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 10;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.DateOrdered !=Convert.ToDateTime("23/02/2017"))
            { 
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderPriceFound()
        {
            //Create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 10;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.OrderPrice!= 10.00)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestProdcutNameFound()
        {
            //Create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 10;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.ProductName != "HP Compaq Elite")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestProductQuantityFound()
        {
            //Create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 10;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.QuantityNo != 10)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }











        [TestMethod]
        public void ValidExistsOrderNumber()
        {
            //Create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean to store result of validation
            Boolean OK = false;
            //create test to assign to property
            Int32 SomeOrder = 1;
            //invoke method
            OK = AnOrder.Valid(SomeOrder);
            //test to see result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void ValidExistsDateOrdered()
        {
            //Create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            Boolean OK;
            OK = AnOrder.Valid2(DateTime.Now.Date);
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void ValidExistsOrderPrice()
        {
            //Create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            Boolean OK;
            OK = AnOrder.Valid3(10.00);
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidExistsProductName()
        {
            //Create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            Boolean OK;
            OK = AnOrder.Valid4("HP Compaq Elite 8300");
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidExistsProductQuantity()
        {
            //Create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            Boolean OK;
            OK = AnOrder.Valid5(1);
            Assert.IsTrue(OK);
        }
    }
}