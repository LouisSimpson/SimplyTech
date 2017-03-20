using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;


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
    }
}
