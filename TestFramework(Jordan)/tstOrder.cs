﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using clslibrary;
using ClassLibrary;
using System.Collections.Generic;

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
        public void PriceOK()
        {
            clsOrder AnOrder = new clsOrder();
            Decimal TestData = 1;
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
            Found = AnOrder.Find(OrderNo);
            //test to see result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderNoFound()
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
            if (AnOrder.OrderPrice != 50)
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
            string DateOrdered = DateTime.Now.Date.ToString();
            string ProductName = "Some Product";
            String QuantityNo = "1";
            string OrderPrice = "5";
            //invoke method
            OK = AnOrder.Valid(DateOrdered, ProductName, QuantityNo, OrderPrice);
            //test to see result is correct
            Assert.IsTrue(OK);
        }

       
        //DATEORDERED PARAMETERS  //DATEORDERED PARAMETERS   //DATEORDERED PARAMETERS    //DATEORDERED PARAMETERS    //DATEORDERED PARAMETERS    //DATEORDERED PARAMETERS    //DATEORDERED PARAMETERS

        [TestMethod]
        public void DateOrderedExtremeMin()
        {
            //Create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean to store result of validation
            Boolean OK = false;
            //create test data to pass the method
            string ProductName = "Some Product";
            String QuantityNo = "1";
            string OrderPrice = "50";
            //create variable to store test date data
            DateTime TestDate;
            //set date to todays date
            TestDate = DateTime.Now.Date;
            //change date to less than 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to string variable
            string DateOrdered = TestDate.ToString();
            //invoke method
            OK = AnOrder.Valid( DateOrdered, ProductName, QuantityNo, OrderPrice);
            //test to see result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void DateOrderedMinLessOne()
        {
            //Create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean to store result of validation
            Boolean OK = false;
            //create test data to pass the method
            string ProductName = "Some Product";
            String QuantityNo = "1";
            string OrderPrice = "50";
            //create variable to store test date data
            DateTime TestDate;
            //set date to todays date
            TestDate = DateTime.Now.Date;
            //change date to less than 100 years
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to string variable
            string DateOrdered = TestDate.ToString();
            //invoke method
            OK = AnOrder.Valid( DateOrdered, ProductName, QuantityNo, OrderPrice);
            //test to see result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void DateOrderedMin()
        {
            //Create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean to store result of validation
            Boolean OK = false;
            //create test data to pass the method
            string ProductName = "Some Product";
            String QuantityNo = "1";
            string OrderPrice = "50";
            //create variable to store test date data
            DateTime TestDate;
            //set date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to string variable
            string DateOrdered = TestDate.ToString();
            //invoke method
            OK = AnOrder.Valid(DateOrdered, ProductName, QuantityNo, OrderPrice);
            //test to see result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void DateOrderedMinPlusOne()
        {
            //Create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean to store result of validation
            Boolean OK = false;
            //create test data to pass the method
            string ProductName = "Some Product";
            String QuantityNo = "1";
            string OrderPrice = "50";
            //create variable to store test date data
            DateTime TestDate;
            //set date to todays date
            TestDate = DateTime.Now.Date;
            //change date to date plus one
            TestDate = TestDate.AddDays(1);
            //convert the date variable to string variable
            string DateOrdered = TestDate.ToString();
            //invoke method
            OK = AnOrder.Valid( DateOrdered, ProductName, QuantityNo, OrderPrice);
            //test to see result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void DateOrderedExtremeMax()
        {
            //Create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean to store result of validation
            Boolean OK = false;
            //create test data to pass the method
            string ProductName = "Some Product";
            String QuantityNo = "1";
            string OrderPrice = "50";
            //create variable to store test date data
            DateTime TestDate;
            //set date to todays date
            TestDate = DateTime.Now.Date;
            //change date to plus than 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to string variable
            string DateOrdered = TestDate.ToString();
            //invoke method
            OK = AnOrder.Valid(DateOrdered, ProductName, QuantityNo, OrderPrice);
            //test to see result is correct
            Assert.IsFalse(OK);
        }

        //OrderPrice    //OrderPrice    //OrderPrice    //OrderPrice   //OrderPrice    //OrderPrice    //OrderPrice    //OrderPrice    //OrderPrice

        [TestMethod]
        public void OrderPriceMinLessOne()
        {
            //Create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean to store result of validation
            Boolean OK = false;
            //create test data to pass the method
            string DateOrdered = DateTime.Now.Date.ToString();
            string ProductName = "Some Product";
            String QuantityNo = "1";
            string OrderPrice = "-1";
            //invoke method
            OK = AnOrder.Valid(DateOrdered, ProductName, QuantityNo, OrderPrice);
            //test to see result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void OrderPriceMin()
        {
            //Create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean to store result of validation
            Boolean OK = false;
            //create test data to pass the method
            string DateOrdered = DateTime.Now.Date.ToString();
            string ProductName = "Some Product";
            String QuantityNo = "1";
            string OrderPrice = "0";
            //invoke method
            OK = AnOrder.Valid( DateOrdered, ProductName, QuantityNo, OrderPrice);
            //test to see result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void OrderPriceMinPlusOne()
        {
            //Create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean to store result of validation
            Boolean OK = false;
            //create test data to pass the method
            string DateOrdered = DateTime.Now.Date.ToString();
            string ProductName = "Some Product";
            String QuantityNo = "1";
            String OrderPrice = "1";
            //invoke method
            OK = AnOrder.Valid(DateOrdered, ProductName, QuantityNo, OrderPrice);
            //test to see result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void OrderPriceMaxLessOne()
        {
            //Create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean to store result of validation
            Boolean OK = false;
            //create test data to pass the method
            string DateOrdered = DateTime.Now.Date.ToString();
            string ProductName = "Some Product";
            String QuantityNo = "1";
            string OrderPrice = "9999";
            //invoke method
            OK = AnOrder.Valid(DateOrdered, ProductName, QuantityNo, OrderPrice);
            //test to see result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void OrderPriceMax()
        {
            //Create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean to store result of validation
            Boolean OK = false;
            //create test data to pass the method
            string DateOrdered = DateTime.Now.Date.ToString();
            string ProductName = "Some Product";
            String QuantityNo = "1";
            string OrderPrice = "10000";
            //invoke method
            OK = AnOrder.Valid( DateOrdered, ProductName, QuantityNo, OrderPrice);
            //test to see result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void OrderPriceMaxPlusOne()
        {
            //Create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean to store result of validation
            Boolean OK = false;
            //create test data to pass the method
            string DateOrdered = DateTime.Now.Date.ToString();
            string ProductName = "Some Product";
            String QuantityNo = "1";
            string OrderPrice = "10001";
            //invoke method
            OK = AnOrder.Valid(DateOrdered, ProductName, QuantityNo, OrderPrice);
            //test to see result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void OrderPriceMid()
        {
            //Create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean to store result of validation
            Boolean OK = false;
            //create test data to pass the method
            string DateOrdered = DateTime.Now.Date.ToString();
            string ProductName = "Some Product";
            String QuantityNo = "1";
            string OrderPrice = "5000";
            //invoke method
            OK = AnOrder.Valid( DateOrdered, ProductName, QuantityNo, OrderPrice);
            //test to see result is correct
            Assert.IsTrue(OK);
        }
        //PRODUCTNAME           //PRODUCTNAME           //PRODUCTNAME           //PRODUCTNAME           //PRODUCTNAME           //PRODUCTNAME


        [TestMethod]
        public void ProductNameMinLessOne()
        {
            //Create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean to store result of validation
            Boolean OK = false;
            //create test data to pass the method
            string DateOrdered = DateTime.Now.Date.ToString();
            string ProductName = "a";
            String QuantityNo = "1";
            String OrderPrice = "1";
            //invoke method
            OK = AnOrder.Valid( DateOrdered, ProductName, QuantityNo, OrderPrice);
            //test to see result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void ProductNameMin()
        {
            //Create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean to store result of validation
            Boolean OK = false;
            //create test data to pass the method
            string DateOrdered = DateTime.Now.Date.ToString();
            string ProductName = "aa";
            String QuantityNo = "1";
            String OrderPrice = "1";
            //invoke method
            OK = AnOrder.Valid( DateOrdered, ProductName, QuantityNo, OrderPrice);
            //test to see result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ProductNameMinPlusOne()
        {
            //Create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean to store result of validation
            Boolean OK = false;
            //create test data to pass the method
            string DateOrdered = DateTime.Now.Date.ToString();
            string ProductName = "aaa";
            String QuantityNo = "1";
            String OrderPrice = "1";
            //invoke method
            OK = AnOrder.Valid( DateOrdered, ProductName, QuantityNo, OrderPrice);
            //test to see result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ProductNameMaxLessOne()
        {
            //Create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean to store result of validation
            Boolean OK = false;
            //create test data to pass the method
            string DateOrdered = DateTime.Now.Date.ToString();
            string ProductName = "";
            ProductName = ProductName.PadRight(29, 'a');
            String QuantityNo = "1";
            String OrderPrice = "1";
            //invoke method
            OK = AnOrder.Valid(DateOrdered, ProductName, QuantityNo, OrderPrice);
            //test to see result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductNameMax()
        {
            //Create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean to store result of validation
            Boolean OK = false;
            //create test data to pass the method
            string DateOrdered = DateTime.Now.Date.ToString();
            string ProductName = "";
            ProductName = ProductName.PadRight(30, 'a');
            String QuantityNo = "1";
            String OrderPrice = "1";
            //invoke method
            OK = AnOrder.Valid( DateOrdered, ProductName, QuantityNo, OrderPrice);
            //test to see result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductNameMaxPlusOne()
        {
            //Create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean to store result of validation
            Boolean OK = false;
            //create test data to pass the method
            string DateOrdered = DateTime.Now.Date.ToString();
            string ProductName = "";
            ProductName = ProductName.PadRight(31, 'a');
            String QuantityNo = "1";
            String OrderPrice = "1";
            //invoke method
            OK = AnOrder.Valid( DateOrdered, ProductName, QuantityNo, OrderPrice);
            //test to see result is correct
            Assert.IsFalse(OK);
        }



        //QUANTITY  //QUANTITY  //QUANTITY  //QUANTITY  //QUANTITY  //QUANTITY  //QUANTITY  //QUANTITY  //QUANTITY  //QUANTITY  //QUANTITY  //QUANTITY



        [TestMethod]
        public void QuantityMinLessOne()
        {
            //Create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean to store result of validation
            Boolean OK = false;
            //create test data to pass the method
            string DateOrdered = DateTime.Now.Date.ToString();
            string ProductName = "aaaa";
            String QuantityNo = "0";
            String OrderPrice = "1";
            //invoke method
            OK = AnOrder.Valid( DateOrdered, ProductName, QuantityNo, OrderPrice);
            //test to see result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void QuantityMin()
        {
            //Create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean to store result of validation
            Boolean OK = false;
            //create test data to pass the method
            string DateOrdered = DateTime.Now.Date.ToString();
            string ProductName = "aaaa";
            String QuantityNo = "1";
            String OrderPrice = "1";
            //invoke method
            OK = AnOrder.Valid( DateOrdered, ProductName, QuantityNo, OrderPrice);
            //test to see result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void QuantityMinPlusOne()
        {
            //Create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean to store result of validation
            Boolean OK = false;
            //create test data to pass the method
            string DateOrdered = DateTime.Now.Date.ToString();
            string ProductName = "aaaa";
            string QuantityNo = "2";
            string OrderPrice = "1";
            //invoke method
            OK = AnOrder.Valid( DateOrdered, ProductName, QuantityNo, OrderPrice);
            //test to see result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void QuantityMaxLessOne()
        {
            //Create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean to store result of validation
            Boolean OK = false;
            //create test data to pass the method
            string DateOrdered = DateTime.Now.Date.ToString();
            string ProductName = "aaaa";
            String QuantityNo = "9";
            String OrderPrice = "1";
            //invoke method
            OK = AnOrder.Valid(DateOrdered, ProductName, QuantityNo, OrderPrice);
            //test to see result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void QuantityMax()
        {
            //Create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean to store result of validation
            Boolean OK = false;
            //create test data to pass the method
            string DateOrdered = DateTime.Now.Date.ToString();
            string ProductName = "aaaa";
            string QuantityNo = "10";
            String OrderPrice = "1";
            //invoke method
            OK = AnOrder.Valid( DateOrdered, ProductName, QuantityNo, OrderPrice);
            //test to see result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            //Create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean to store result of validation
            Boolean OK = false;
            //create test data to pass the method
            string DateOrdered = DateTime.Now.Date.ToString();
            string ProductName = "aaaa";
            string QuantityNo = "11";
            String OrderPrice = "1";
            //invoke method
            OK = AnOrder.Valid( DateOrdered, ProductName, QuantityNo, OrderPrice);
            //test to see result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void QuantityMid()
        {
            //Create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean to store result of validation
            Boolean OK = false;
            //create test data to pass the method
            string DateOrdered = DateTime.Now.Date.ToString();
            string ProductName = "aa";
            string QuantityNo = "5";
            String OrderPrice = "1";
            //invoke method
            OK = AnOrder.Valid( DateOrdered, ProductName, QuantityNo, OrderPrice);
            //test to see result is correct
            Assert.IsTrue(OK);
        }
    }
}

