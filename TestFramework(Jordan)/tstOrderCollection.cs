using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;
using clslibrary;

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
            TestItem.ProductName = "some name";
            TestItem.QuantityNo = 1;
            TestItem.OrderPrice = 100;
            //add item to test list
            TestList.Add(TestItem);
            //assign data to property
            AllOrders.OrderList = TestList;
            //test to see two equal values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);

        }
        [TestMethod]
        public void CountOrderOk()
        {
            //create instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create test data to assign to property
            Int32 SomeCount = 0;
            //assign the data to the property
            AllOrders.Count = SomeCount;
            //test to see that two values are the same
            Assert.AreEqual(AllOrders.Count, SomeCount);
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
            TestOrder.ProductName = "some name";
            TestOrder.QuantityNo = 1;
            TestOrder.OrderPrice = 100;
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
            TestItem.ProductName = "some name";
            TestItem.QuantityNo = 1;
            TestItem.OrderPrice = 100;
            //add item to test list
            TestList.Add(TestItem);
            //assign data to property
            AllOrders.OrderList = TestList;
            //test to see two equal values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);

        }
        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create inst\nce of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, 2);
        }
    }
}
