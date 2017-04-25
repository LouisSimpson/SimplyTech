using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsStockCollection
    {

        List<clsStock> mStockList = new List<clsStock>();
        clsStock mThisStock = new clsStock();
     
       public clsStockCollection()
        {
            /*Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_Stock_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsStock AnStock = new clsStock();
                AnStock.StockID = Convert.ToInt32(DB.DataTable.Rows[Index]["StockID"]);
                AnStock.ItemName = Convert.ToString(DB.DataTable.Rows[Index]["ItemName"]);
                AnStock.StockDescription = Convert.ToString(DB.DataTable.Rows[Index]["StockDescription"]);
                AnStock.StockLevel = Convert.ToInt32(DB.DataTable.Rows[Index]["StockLevel"]);
                AnStock.StockPrice = Convert.ToInt32(DB.DataTable.Rows[Index]["StockPrice"]);

                mStockList.Add(AnStock);

                Index++;
            }*/

            clsStock TestItem = new clsStock();
            TestItem.StockID = 1;
            TestItem.ItemName = "GTX 1080";
            TestItem.StockDescription = "NVIDIA GPU";
            TestItem.StockLevel = 1;
            TestItem.StockPrice = 100;

            mStockList.Add(TestItem);

            TestItem = new clsStock();

            TestItem.StockID = 2;
            TestItem.ItemName = "RX 480";
            TestItem.StockDescription = "AMD GPU";
            TestItem.StockLevel = 2;
            TestItem.StockPrice = 95;

            mStockList.Add(TestItem);
        }

        public clsStock ThisStock
        {
            get { return mThisStock; }
            set { mThisStock= value; }
        }


        public List<clsStock> StockList
        {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;
            }
        }

        public int Count
        {
            get
            {
                return mStockList.Count;
            }
            set
            {

            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

           
            DB.AddParameter("@ItemName", mThisStock.ItemName);
            DB.AddParameter("@StockDescription", mThisStock.StockDescription);
            DB.AddParameter("@StockLevel", mThisStock.StockLevel);
            DB.AddParameter("@StockPrice", mThisStock.StockPrice);

            return DB.Execute("sproc_Stock_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StockID", mThisStock.StockID);
            DB.Execute("sproc_Stock_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StockID", mThisStock.StockID);
            DB.AddParameter("@StockDescription", mThisStock.StockDescription);
            DB.AddParameter("@StockLevel", mThisStock.StockLevel);
            DB.AddParameter("@StockPrice", mThisStock.StockPrice);

            DB.Execute("sproc_Stock_Update");
        }

        public void FilterByStockDescription(string StockDescription)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StockDescription", StockDescription);
            DB.Execute("sproc_Stock_FilterByStockDescription");
        }
    }
}