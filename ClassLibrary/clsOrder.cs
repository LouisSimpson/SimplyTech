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
                mOrderPrice= value;
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
            mDateOrdered = Convert.ToDateTime("23/02/2017");
            mOrderNo = 10;
            mOrderPrice = 10.00;
            mProductName = "HP Compaq Elite";
            mQuantityNo = 10;
            return true;
        }

        public bool Valid(int someOrder)
        {
            if (someOrder != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            }

        public bool Valid2(DateTime date)
        {
            return true;
        }

        public bool Valid3(double v)
        {
            return true;
        }

        public bool Valid4(string v)
        {
            return true;
        }

        public bool Valid5(int v)
        {
            return true;
        }
    }
        

      
    }
