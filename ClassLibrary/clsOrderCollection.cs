using System.Collections.Generic;
using clslibrary;
using System;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
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
