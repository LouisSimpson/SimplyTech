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
        private decimal mOrderPrice;
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

        public DateTime DateTemp { get; private set; }

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
        public decimal OrderPrice
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





        public bool Find(string ProductName)
        {
            //CREATE AN INSTANCE OF THE DATA CONNECTION
            clsDataConnection DB = new clsDataConnection();
            //add parameter for orderNo to search for
            DB.AddParameter("@ProductName", ProductName);
            //execute stored procedure
            DB.Execute("sproc_tblOrder_FilterByProductName");
            //if one record is found should be either one or zero
            if (DB.Count == 1)
            {
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mDateOrdered = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOrdered"]);
                mProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                mQuantityNo = Convert.ToInt32(DB.DataTable.Rows[0]["QuantityNo"]);
                mOrderPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["OrderPrice"]);
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

        public bool Valid( string dateOrdered, string productName, string quantityNo, string orderPrice)
        {
            //BOOLEAN VARIABLE TO FLAG ERROR
            Boolean OK = true;
            //copy the dateordered value to datetemp variable
            DateTemp = Convert.ToDateTime(dateOrdered);
            //check to see if the date is less than todays date
            if (DateTemp < DateTime.Now.Date)
            {
                OK = false;
            }
         
            //check to see if the date is greater than todays date
            if (DateTemp > DateTime.Now.Date)
            {
                OK = false;
            }

            try
            {
                decimal TempPrice =Convert.ToDecimal( orderPrice);
                //if price is blank return false
                if (TempPrice < 0)
                {
                    OK = false;
                }

                //if price greater than 10001 digits return false
                if (TempPrice > 10000)
                {
                    OK = false;
                }
            }
            catch
            {
                OK = false;
            }

          //if product name blank
          if (productName.Length < 2)
            {
                OK = false;
            }
          //if productname too long
          if (productName.Length > 30)
            {
                OK = false;
            }

            try
            {
                int TempQuantity = Convert.ToInt32(quantityNo);
                if (TempQuantity < 1)
                {
                    OK = false;
                }
            }
            catch
            {
                OK = false;
            }

            try
            {
                int TempQuantity = Convert.ToInt32(quantityNo);
                if (TempQuantity > 10)
                {
                    OK = false;
                }
            }
            catch
            {
                OK = false;
            }
         
         
            //return value of ok
            return OK;
        }

    }
}