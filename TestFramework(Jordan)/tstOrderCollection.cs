using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;
using clslibrary;
using MyClassLibrary;
using ClassLibrary;

namespace TestFramework_Jordan_
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            Assert.IsNotNull(AllOrder);
        }
        [TestMethod]
        public void OrderListOk()
        {
            //create intance of class to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create test data to assign to the property
            //data needs to be list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add item to list
            //create item of test data
            clsOrder TestItem = new clsOrder();
            //set properties
            TestItem.OrderNo = 1;
            TestItem.DateOrdered = DateTime.Now.Date;
            TestItem.ProductName = "HP Compaq Elite 8300";
            TestItem.QuantityNo = 1;
            TestItem.OrderPrice = 50;
            //add item to test list
            TestList.Add(TestItem);
            //assign data to property
            AllOrders.OrderList = TestList;
            //test to see two equal values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);

        }


        [TestMethod]
        public void ThisOrderOK()
        {
            //create instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            //set properties of the test object
            TestOrder.OrderNo = 1;
            TestOrder.DateOrdered = DateTime.Now.Date;
            TestOrder.ProductName = "HP Compaq Elite 8300";
            TestOrder.QuantityNo = 1;
            TestOrder.OrderPrice = 50;
            //assign data to property
            AllOrders.ThisOrder = TestOrder;
            //test to see two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create intance of class to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create test data to assign to the property
            //data needs to be list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add item to list
            //create item of test data
            clsOrder TestItem = new clsOrder();
            //set properties
            TestItem.OrderNo = 1;
            TestItem.DateOrdered = DateTime.Now.Date;
            TestItem.ProductName = "HP Compaq Elite 8300";
            TestItem.QuantityNo = 1;
            TestItem.OrderPrice = 50;
            //add item to test list
            TestList.Add(TestItem);
            //assign data to property
            AllOrders.OrderList = TestList;
            //test to see two equal values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);


        }
        [TestMethod]
        public void AddMethodOk()
        {
            //create intance of class to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //var to store primary key
            Int32 PrimaryKey = 0;
            //create test data to assign to the property
            clsOrder TestItem = new clsOrder();

            //set properties
            TestItem.OrderNo = 4;
            TestItem.DateOrdered = DateTime.Now.Date;
            TestItem.ProductName = "Logitech M220 Silent Wireless Mouse ";
            TestItem.QuantityNo = 3;
            TestItem.OrderPrice = 50;
            //set thisorder to test data
            AllOrders.ThisOrder = TestItem;
            //add record
            PrimaryKey = AllOrders.Add();
            //set primary key of the test data
            TestItem.OrderNo = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see the values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOk()
        {
            //create intance of class to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create test data to assign to the property
            clsOrder TestItem = new clsOrder();
            //var to store primary key
            Int32 PrimaryKey = 0;
            //set properties
            TestItem.OrderNo = 13;
            TestItem.DateOrdered = DateTime.Now.Date;
            TestItem.ProductName = "Logitech M220 Silent Wireless Mouse";
            TestItem.QuantityNo = 3;
            TestItem.OrderPrice = 60;
            //set thisorder to test data
            AllOrders.ThisOrder = TestItem;
            //add record
            PrimaryKey = AllOrders.Add();
            //set primary key of the test data
            TestItem.OrderNo = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //delete record
            AllOrders.Delete();
            //find record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see the values are the same
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create intance of class to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create test data to assign to the property
            clsOrder TestItem = new clsOrder();
            //var to store primary key
            Int32 PrimaryKey = 0;

            //set properties
            TestItem.DateOrdered = DateTime.Now.Date;
            TestItem.ProductName = "Logitech M220 Silent Wireless Mouse ";
            TestItem.QuantityNo = 3;
            TestItem.OrderPrice = 50;
            //set thisorder to test data
            AllOrders.ThisOrder = TestItem;
            //add record
            PrimaryKey = AllOrders.Add();
            //set primary key of the test data
            TestItem.OrderNo = PrimaryKey;
            //MODIFY TEST DATA
            TestItem.DateOrdered = DateTime.Now.Date;
            TestItem.ProductName = "Logitech 11 Wireless Mouse ";
            TestItem.QuantityNo = 2;
            TestItem.OrderPrice = 20;
            AllOrders.ThisOrder = TestItem;
            //UPDATE RECORD
            AllOrders.Update();
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see the values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
        [TestMethod]
        public void FilterByProductNameMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.FilterByProductName("");
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void FilterByProductNameNoneFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.FilterByProductName("CXSC CPU");
            //Test to see there are no records
            Assert.AreEqual(0, FilteredOrders.Count);
        }

        [TestMethod]
        public void FilterByProductNameTestDataFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //var to tore outcome
            Boolean OK = true;
            FilteredOrders.FilterByProductName("Logitech M220 Silent Wireless Mouse ");
            //Test to see there are no records
            if (FilteredOrders.Count == 2)
            {
                if (FilteredOrders.OrderList[0].OrderNo !=13)
                {
                    OK = false;
                }
                if (FilteredOrders.OrderList[1].OrderNo !=)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}