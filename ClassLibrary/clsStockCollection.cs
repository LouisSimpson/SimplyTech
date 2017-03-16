using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
     
        public clsStockCollection()
        {
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