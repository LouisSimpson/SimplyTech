using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsStockCollection
    {
     
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

        public List<clsStock> ThisStock { get; set; }

        List<clsStock> mStockList = new List<clsStock>();

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
    }
}