using System.Collections.Generic;
using clslibrary;
using System;
using ClassLibrary;
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

            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //Execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            PopulateArray(DB);



           /* clsOrder TestItem = new clsOrder();
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

            mOrderList.Add(TestItem);*/
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
                
            }
        }
       


        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@DateOrdered", mThisOrder.DateOrdered);
            DB.AddParameter("@ProductName", mThisOrder.ProductName);
            DB.AddParameter("@QuantityNo", mThisOrder.QuantityNo);
            DB.AddParameter("@OrderPrice", mThisOrder.OrderPrice);
            //execute query returning primary key value
            return DB.Execute("sproc_tblOrder_Insert");


        }
        public void Delete()
        {

            clsDataConnection DB = new clsDataConnection();
            //set parameters for stored procedure
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Delete");
        }
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            DB.AddParameter("@DateOrdered", mThisOrder.DateOrdered);
            DB.AddParameter("@ProductName", mThisOrder.ProductName);
            DB.AddParameter("@QuantityNo", mThisOrder.QuantityNo);
            DB.AddParameter("@OrderPrice", mThisOrder.OrderPrice);
            //execute query returning primary key value
            DB.Execute("sproc_tblOrder_Update");
        }

        public void FilterByProductName(string ProductName)
        {
            //filters records based on full or partial product name
            clsDataConnection DB = new clsDataConnection();
            //send productname to parameter
            DB.AddParameter("@ProductName", ProductName);
            //eecute stored procedure
            DB.Execute("sproc_tblOrder_FilterByProductName");
            //POPULATE ARRAY LIST
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mOrderList = new List<clsOrder>();

            while (Index < RecordCount)
            {
                //create blank order
                clsOrder AnOrder = new clsOrder();
                //read in fields from the current records in the tbale
                AnOrder.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
                AnOrder.DateOrdered = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOrdered"]);
                AnOrder.ProductName = Convert.ToString(DB.DataTable.Rows[Index]["ProductName"]);
                AnOrder.QuantityNo = Convert.ToInt32(DB.DataTable.Rows[Index]["QuantityNo"]);
                AnOrder.OrderPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["OrderPrice"]);
                //add record to private data member
                mOrderList.Add(AnOrder);
                //point at next record
                Index++;
            }
        }
    }
}



