using System;
//blah
namespace ClassLibrary
{
    public class clsStock
    {
        private Int32 mStockID;
        private String mItemName;
        private String mStockDescription;
        private Int32 mStockLevel;
        private Decimal mStockPrice;

        public clsStock()
        {

        }

        public string StockName { get; set; }
        public string StockDesc { get; set; }
        public int Stocklvl { get; set; }
        public int StockCost { get; set; }

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

        public string ItemName
        {
            get
            {
                return mItemName;
            }
            set
            {
                mItemName = value;
            }
        }

        public string StockDescription
        {
            get
            {
                return mStockDescription;
            }

            set
            {
                mStockDescription = value;
            }
        }

        public int StockLevel
        {
            get
            {
                return mStockLevel;
            }

            set
            {
                mStockLevel = value;
            }
        }

        public decimal StockPrice
        {
            get
            {
                return mStockPrice;
            }
            set
            {
                mStockPrice = value;
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

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StockID", stockID);
            DB.Execute("sproc_Stock_FilterByStockID");

            if (DB.Count == 1)
            {
                mStockID = Convert.ToInt32(DB.DataTable.Rows[0]["StockID"]);
                mItemName = Convert.ToString(DB.DataTable.Rows[0]["ItemName"]);
                mStockDescription = Convert.ToString(DB.DataTable.Rows[0]["StockDescription"]);
                mStockLevel = Convert.ToInt32(DB.DataTable.Rows[0]["StockLevel"]);
                mStockPrice = Convert.ToInt32(DB.DataTable.Rows[0]["StockPrice"]);

                return true;
            }

            else
            {
                return false;
            }
           

            
        }

        public bool ValidExists(string ItemName, string stockDescription, int stockLevel, int stockPrice)
        {


            Boolean OK = true;

            if (ItemName.Length == 0)
            {
                OK = false;
            }

            if (ItemName.Length > 50)
            {
                OK = false;
            }

            if (stockDescription.Length == 0)
            {

                OK = false;

            }

            if (stockDescription.Length > 50)
            {
                OK = false;
            }
            

        

        

        if (stockLevel == -1)
        {

            OK = false;

        }

        if (stockLevel > 100)
        {
            OK = false;
        }

        if (stockPrice == -1)
        {

            OK = false;

        }

        if (stockPrice > 10000)
        {
            OK = false;
        }







        return OK;
    }

        public bool valid5(int v)
        {
            return true;
        }
    }
}