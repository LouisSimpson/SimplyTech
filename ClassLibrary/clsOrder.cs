using System;

namespace clslibrary
{
    public class clsOrder
    {
        //private data member for dateOrdered
        private DateTime mDateOrdered;
        //private data member for orderNo
        private Int32 mOrderNo;
        //private data member for OrderPrice
        private double mOrderPrice;
        //private data member for productname
        private string mProductName;
        //private data member for quantityno
        private Int32 mQuantityNo;

        public clsOrder()
        {

        }



        public DateTime DateOrdered
        {
            get
            {
                return mDateOrdered;
            }
            set
            {
                mDateOrdered = value;
            }
        }

        public Int32 OrderNo
        {
            get
            {
                return mOrderNo;
            }
            set
            {
                mOrderNo = value;
            }
        }
        public Double OrderPrice
        {
            get
            {
                return mOrderPrice;
            }
            set
            {
                mOrderPrice = value;
            }
        }
        public string ProductName
        {
            get
            {
                return mProductName;
            }
            set
            {
                mProductName = value;
            }
        }
        public Int32 QuantityNo
        {
            get
            {
                return mQuantityNo;
            }
            set
            {
                mQuantityNo = value;
            }
        }





        public bool Find(int OrderNo)
        {
            //CREATE AN INSTANCE OF THE DATA CONNECTION
            clsDataConnection DB = new clsDataConnection();
            //add parameter for orderNo to search for
            DB.AddParameter("@OrderNo", OrderNo);
            //execute stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderNo");
            //if one record is found should be either one or zero
            if (DB.Count == 1)
            {
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mDateOrdered = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOrdered"]);
                mProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                mQuantityNo = Convert.ToInt32(DB.DataTable.Rows[0]["QuantityNo"]);
                mOrderPrice = Convert.ToDouble(DB.DataTable.Rows[0]["OrderPrice"]);
                //return that it worked OK
                return true;

            }
            //if no record found
            else
            {
                //return false
                return false;
            }
        }

        public bool Valid(int orderNo, string dateOrdered, string productName, int quantityNo, double orderPrice)
        {
            //create boolean variable to flag error
            Boolean OK = true;
            //if Order number is 0/blank
            if (orderNo == 0)
            {
                OK = false;
            }
            return OK;
        }
    }
}