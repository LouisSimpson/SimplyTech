using System.Collections.Generic;
using clslibrary;
using System;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        //private data memberthisorder
        clsOrder mThisOrder = new clsOrder();
        public clsOrderCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //Execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //get the count of records to process
            while (Index < RecordCount)
            {
                //create blank order
                clsOrder AnOrder = new clsOrder();
                //read in fields from the current records in the tbale
                AnOrder.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
                AnOrder.DateOrdered = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOrdered"]);
                AnOrder.ProductName = Convert.ToString(DB.DataTable.Rows[Index]["ProductName"]);
                AnOrder.QuantityNo = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AnOrder.OrderPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["OrderPrice"]);
                //add record to private data member
                mOrderList.Add(AnOrder);
                //point at next record
                Index++;
            }
            clsOrder TestItem = new clsOrder();
            TestItem.OrderNo = 1;
            TestItem.DateOrdered = DateTime.Now.Date;
            TestItem.ProductName = "HP Compaq Elite 8300";
            TestItem.QuantityNo = 1;
            TestItem.OrderPrice = 50;

            mOrderList.Add(TestItem);
            TestItem = new clsOrder();

            TestItem.OrderNo = 13;
            TestItem.DateOrdered = DateTime.Now.Date;
            TestItem.ProductName = "Logitech M220 Silent Wireless Mouse ";
            TestItem.QuantityNo = 3;
            TestItem.OrderPrice = 60;

            mOrderList.Add(TestItem);
        }
        //private data member for the list
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
        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }

      
            public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@DateOrdered", mThisOrder.DateOrdered);
            DB.AddParameter("@ProductName", mThisOrder.ProductName);
            DB.AddParameter("@QuantityNo", mThisOrder.QuantityNo);
            DB.AddParameter("@OrderPrice", mThisOrder);
            //execute query returning primary key value
            return DB.Execute("sproc_tblOrder_Insert");
          
         
        }
        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            DB.Execute("sproc_tblOrder_Delete");
        }
    }

    }

