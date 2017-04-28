using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;
//test test test
namespace TestFramework_Louis_
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            Assert.IsNotNull(AllStock);
        }

        [TestMethod]

        public void StockListOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.StockID = 1;
            TestItem.ItemName = "GTX1080TI";
            TestItem.StockDescription = "NVIDIA GPU";
            TestItem.StockLevel = 2;
            TestItem.StockPrice = 800;

            TestList.Add(TestItem);

            AllStock.StockList = TestList;

            Assert.AreEqual(AllStock.StockList, TestList);
        }

        

        //[TestMethod]

        //public void ThisStockOK()
        //{
        //    clsStockCollection AllStock = new clsStockCollection();
        //    List<clsStock> TestList = new List<clsStock>();
        //    clsStock TestItem = new clsStock();
        //    TestItem.StockID = 21;
        //    TestItem.ItemName = "GTX 1080";
        //    TestItem.StockDescription = "Description";
        //    TestItem.StockLevel = 1;
        //    TestItem.StockPrice = 100;

        //    TestList.Add(TestItem);

        //    AllStock.ThisStock = TestList;

        //    Assert.AreEqual(AllStock.ThisStock, TestList);
        //}

        [TestMethod]

        public void ListAndCountOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.StockID = 1;
            TestItem.ItemName = "GTX 1080";
            TestItem.StockDescription = "NVIDIA GPU";
            TestItem.StockLevel = 1;
            TestItem.StockPrice = 100;

            TestList.Add(TestItem);

            AllStock.StockList = TestList;

            Assert.AreEqual(AllStock.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            Int32 PrimaryKey = 0;
            clsStock TestItem = new clsStock();
            
            TestItem.StockID =4;
            TestItem.ItemName = "GTX 780";
            TestItem.StockDescription = "NVIDIA GPU";
            TestItem.StockLevel = 1;
            TestItem.StockPrice = 150;

            AllStock.ThisStock = TestItem;

            PrimaryKey = AllStock.Add();

            TestItem.StockID = PrimaryKey;

            AllStock.ThisStock.Find(PrimaryKey);

            Assert.AreEqual(AllStock.ThisStock, TestItem);


        }



        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.StockID = 2;
            TestItem.ItemName = "GTX 780";
            TestItem.StockDescription = "NVIDIA GPU";
            TestItem.StockLevel = 1;
            TestItem.StockPrice = 150;

            AllStock.ThisStock = TestItem;

            PrimaryKey = AllStock.Add();

            TestItem.StockID = PrimaryKey;

            AllStock.ThisStock.Find(PrimaryKey);

            AllStock.Delete();

            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);

            Assert.IsFalse(Found);
        }
    
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.ItemName = "GTX1080";
            TestItem.StockDescription = "NVIDIA GPU";
            TestItem.StockLevel = 2;
            TestItem.StockPrice = 150;

            AllStock.ThisStock = TestItem;

            PrimaryKey = AllStock.Add();

            TestItem.StockID = PrimaryKey;

            TestItem.ItemName = "RX550";
            TestItem.StockDescription = "AMD GPU";
            TestItem.StockLevel = 3;
            TestItem.StockPrice = 400;

            AllStock.ThisStock = TestItem;

            AllStock.Update();

            AllStock.ThisStock.Find(PrimaryKey);

            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void FilterByStockDescriptionOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStockCollection FilteredStock = new clsStockCollection();
            FilteredStock.FilterByStockDescription("");
            Assert.AreEqual(AllStock.Count, FilteredStock.Count);
        }

        [TestMethod]
        public void FilterByStockDescriptionNoneFound()
        {
          
            clsStockCollection FilteredStock = new clsStockCollection();
            FilteredStock.FilterByStockDescription("ATI GPU");
            Assert.AreEqual(0, FilteredStock.Count);
        }








    }
}
