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
            Int32 OrderNo = 1;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.OrderNo != 1)
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
            Int32 OrderNo = 1;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.DateOrdered != Convert.ToDateTime("09/03/2017"))
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
            Int32 OrderNo = 1;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.OrderPrice != 50.00)
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
            Int32 OrderNo = 1;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.ProductName != "HP Compaq Elite 8300")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestProductQuantityNoFound()
        {
            //Create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 1;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.QuantityNo != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }






        [TestMethod]
        public void ValidMethodOK()
        {
            //Create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean to store result of validation
            Boolean OK = false;
            //create test data to pass the method
            int OrderNo = 1;
            string DateOrdered = DateTime.Now.Date.ToString();
            string ProductName = "Some Product";
            int QuantityNo = 1;
            double OrderPrice = 50;
            //invoke method
            OK = AnOrder.Valid(OrderNo, DateOrdered, ProductName, QuantityNo, OrderPrice);
            //test to see result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void OrderNoMinLessOne()
        {
            //Create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean to store result of validation
            Boolean OK = false;
            //create test data to pass the method
            int OrderNo = 0; //should trigger an error
            string DateOrdered = DateTime.Now.Date.ToString();
            string ProductName = "Some Product";
            int QuantityNo = 1;
            double OrderPrice = 50;
            //invoke method
            OK = AnOrder.Valid(OrderNo, DateOrdered, ProductName, QuantityNo, OrderPrice);
            //test to see result is correct
            Assert.IsFalse(OK);
        }


    }
}

