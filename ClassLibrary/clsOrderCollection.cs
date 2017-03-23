using System.Collections.Generic;
using clslibrary;
using System;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        public clsOrderCollection()
        {
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderNo = 1;
            TestItem.DateOrdered = DateTime.Now.Date;
            TestItem.ProductName = "some name";
            TestItem.QuantityNo = 1;
            TestItem.OrderPrice = 100;
            //add order to test list
            mOrderList.Add(TestItem);
            //reinitialise the object fo rsome new data
            TestItem = new clsOrder();
            //set properties
            TestItem.OrderNo = 2;
            TestItem.DateOrdered = DateTime.Now.Date;
            TestItem.ProductName = "some name";
            TestItem.QuantityNo = 2;
            TestItem.OrderPrice = 200;
            //add item to test list
            mOrderList.Add(TestItem);

        }
        //private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        public List<clsOrder> OrderList
        {
            get
            {
                //return private data
                return mOrderList;
            }
            set
            {
                //set private data
                mOrderList = value;
            }
        }
        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {
                ///?????????????
            }
        }

        public clsOrder ThisOrder { get; set; }
    }
}
