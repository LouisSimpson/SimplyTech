using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestFramework
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStock TestStock = new clsStock();
            Assert.IsNotNull(TestStock);
        }

        [TestMethod]
        public void itemNameOK()
        {
            clsStock TestStock = new clsStock();
            string TestData = "GTX1080";
            TestStock.StockName = TestData;
            Assert.AreEqual(TestStock.StockName, TestData);
        }

        [TestMethod]
        public void StockDescriptionOK()
        {
            clsStock TestStock = new clsStock();
            string TestData = "Nvidia GPU, GTX 1080, 8GB GDDR5 VM";
            TestStock.StockDesc = TestData;
            Assert.AreEqual(TestStock.StockDesc, TestData);
        }

        [TestMethod]
        public void StockLevelOK()
        {
            clsStock TestStock = new clsStock();
            int TestData = 1;
            TestStock.Stocklvl = TestData;
            Assert.AreEqual(TestStock.Stocklvl, TestData);
        }

        [TestMethod]
        public void StockPriceOK()
        {
            clsStock TestStock = new clsStock();
            int TestData = 400;
            TestStock.StockPrice = TestData;
            Assert.AreEqual(TestStock.StockPrice, TestData);
        }

        [TestMethod]
        public void ValidExistsItemName()
        {
            clsStock TestStock = new clsStock();
            Boolean Ok;
            Ok = TestStock.valid("GTX1080");
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void ValidExistsStockDescription()
        {
            clsStock TestStock = new clsStock();
            Boolean Ok;
            Ok = TestStock.valid2("Nvidia GPU, GTX 1080, 8GB GDDR5 VM");
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void ValidExiststockLevel()
        {
            clsStock TestStock = new clsStock();
            Boolean Ok;
            Ok = TestStock.valid3(0);
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void ValidExistsStockPrice()
        {
            clsStock TestStock = new clsStock();
            Boolean Ok;
            Ok = TestStock.valid4(400);
            Assert.IsTrue(Ok);
        }

        [TestMethod]

        public void FindMethodOK()
        {
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Int32 StockID = 1;
            Found = AnStock.Find(StockID);
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void TestStockIDFound()
        {
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockID = 21;
            Found = AnStock.Find(StockID);
            if (AnStock.StockID != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestItemNameFound()
        {
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockID = 21;
            Found = AnStock.Find(StockID);
            if (AnStock.ItemName != "Test Name")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestStockDescriptionFound()
        {
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockID = 21;
            Found = AnStock.Find(StockID);
            if (AnStock.StockDescription != "Test Description")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestStockLevelFound()
        {
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockID = 21;
            Found = AnStock.Find(StockID);
            if (AnStock.StockLevel != 5)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestStockPriceFound()
        {
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockID = 21;
            Found = AnStock.Find(StockID);
            if (AnStock.StockCost != 100)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}
