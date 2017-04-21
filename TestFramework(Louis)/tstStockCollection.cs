using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;
//test test
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
            TestItem.ItemName = "GTX 1080";
            TestItem.StockDescription = "NVIDIA GPU";
            TestItem.StockLevel = 1;
            TestItem.StockPrice = 100;

            TestList.Add(TestItem);

            AllStock.StockList = TestList;

            Assert.AreEqual(AllStock.StockList, TestList);
        }

        

        /*[TestMethod]

        public void ThisStockOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.StockID = 21;
            TestItem.ItemName = "GTX 1080";
            TestItem.StockDescription = "Description";
            TestItem.StockLevel = 1;
            TestItem.StockPrice = 100;

            TestList.Add(TestItem);

            AllStock.ThisStock = TestList;

            Assert.AreEqual(AllStock.ThisStock, TestList);
        }*/

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

       /* [TestMethod]
        public void AddMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.StockID = 4;
            TestItem.ItemName = "GTX 780";
            TestItem.StockDescription = "NVIDIA GPU";
            TestItem.StockLevel = 1;
            TestItem.StockPrice = 150;

            AllStock.ThisStock = TestItem;

            PrimaryKey = AllStock.Add();

            TestItem.StockID = PrimaryKey;

            AllStock.ThisStock.Find(PrimaryKey);

            Assert.AreEqual(AllStock.ThisStock, TestItem);


        }*/

        




    }
}
