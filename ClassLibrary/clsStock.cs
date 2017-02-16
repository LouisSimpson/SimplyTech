using System;

namespace ClassLibrary
{
    public class clsStock
    {
        private Int32 mStockID;

        public clsStock()
        {

        }

        public string StockName { get; set; }
        public string StockDesc { get; set; }
        public int Stocklvl { get; set; }
        public int StockPrice { get; set; }

        public int StockID
        {
            get
            {
                return mStockID;
            }

            set
            {
                mStockID = value;
            }
        }

        public bool valid(string v)
        {
            return true;
        }

        public bool valid2(string v)
        {
            return true;
        }

        public bool valid3(int v)
        {
            return true;
        }

        public bool valid4(int v)
        {
            return true;
        }

        public bool Find(int stockID)
        {
            mStockID = 21;

            return true;
        }
    }
}