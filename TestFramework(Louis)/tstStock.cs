using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
//version 1.1
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
        public void StockIDOK()
        {
            clsStock TestStock = new clsStock();
            int TestData = 21;
            TestStock.StockID = TestData;
            Assert.AreEqual(TestStock.StockID, TestData);
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
            TestStock.StockCost = TestData;
            Assert.AreEqual(TestStock.StockCost, TestData);
        }

         [TestMethod]
         public void ValidMethodOK()
         {
             clsStock TestStock = new clsStock();
             Boolean OK = false;
             string ItemName = "GTX1080";
             string StockDescription = "Nvidia GPU";
             string StockLevel = "2";
             string StockPrice = "100";
             OK = TestStock.ValidExists(ItemName, StockDescription, StockLevel, StockPrice);
             Assert.IsTrue(OK);
         }

         [TestMethod]
         public void StockItemNameMinLessOne()
         {
             clsStock TestStock = new clsStock();
             Boolean OK = false;
             string ItemName = "";
             string StockDescription = "Nvidia GPU";
             string StockLevel = "2";
             string StockPrice = "100";
            OK = TestStock.ValidExists(ItemName, StockDescription, StockLevel, StockPrice);
             Assert.IsFalse(OK);
         }

         [TestMethod]
         public void StockItemNameMin()
         {
             clsStock TestStock = new clsStock();
             Boolean OK = false;
             string ItemName = "G";
             string StockDescription = "Nvidia GPU";
            string StockLevel = "2";
            string StockPrice = "100";
            OK = TestStock.ValidExists(ItemName, StockDescription, StockLevel, StockPrice);
             Assert.IsTrue(OK);
         }

         [TestMethod]
         public void StockItemNameMinPlusOne()
         {
             clsStock TestStock = new clsStock();
             Boolean OK = false;
             string ItemName = "GT";
             string StockDescription = "Nvidia GPU";
            string StockLevel = "2";
            string StockPrice = "100";
            OK = TestStock.ValidExists(ItemName, StockDescription, StockLevel, StockPrice);
             Assert.IsTrue(OK);
         }

         [TestMethod]
         public void StockItemNameMaxLessOne()
         {
             clsStock TestStock = new clsStock();
             Boolean OK = false;
             string ItemName = "gtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtg";
             string StockDescription = "Nvidia GPU";
            string StockLevel = "2";
            string StockPrice = "100";
            OK = TestStock.ValidExists(ItemName, StockDescription, StockLevel, StockPrice);
             Assert.IsTrue(OK);
         }

         [TestMethod]
         public void StockItemNameMax()
         {
             clsStock TestStock = new clsStock();
             Boolean OK = false;
             string ItemName = "gtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgt";
             string StockDescription = "Nvidia GPU";
            string StockLevel = "2";
            string StockPrice = "100";
            OK = TestStock.ValidExists(ItemName, StockDescription, StockLevel, StockPrice);
             Assert.IsTrue(OK);
         }

         [TestMethod]
         public void StockItemNameMid()
         {
             clsStock TestStock = new clsStock();
             Boolean OK = false;
             string ItemName = "gtgtgtgtgtgtgtgtgtgtgtgtg";
             string StockDescription = "Nvidia GPU";
            string StockLevel = "2";
            string StockPrice = "100";
            OK = TestStock.ValidExists(ItemName, StockDescription, StockLevel, StockPrice);
             Assert.IsTrue(OK);
         }

        [TestMethod]
         public void StockItemNameMaxPlusOne()
         {
             clsStock TestStock = new clsStock();
             Boolean OK = false;
             string ItemName = "gtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtg";
             string StockDescription = "Nvidia GPU";
            string StockLevel = "2";
            string StockPrice = "100";
            OK = TestStock.ValidExists(ItemName, StockDescription, StockLevel, StockPrice);
             Assert.IsFalse(OK);
         }

         [TestMethod]
         public void StockItemNameExtremeMax()
         {
             clsStock TestStock = new clsStock();
             Boolean OK = false;
             string ItemName = "";
             ItemName = ItemName.PadRight(1000, 'a');
             string StockDescription = "Nvidia GPU";
            string StockLevel = "2";
            string StockPrice = "100";
            OK = TestStock.ValidExists(ItemName, StockDescription, StockLevel, StockPrice);
             Assert.IsFalse(OK);
         }

         [TestMethod]
         public void StockDescriptionMinLessOne()
         {
             clsStock TestStock = new clsStock();
             Boolean OK = false;
             string ItemName = "GTX1080";
             string StockDescription = "";
            string StockLevel = "2";
            string StockPrice = "100";
            OK = TestStock.ValidExists(ItemName, StockDescription, StockLevel, StockPrice);
             Assert.IsFalse(OK);
         }

         [TestMethod]
         public void StockDescriptionMin()
         {
             clsStock TestStock = new clsStock();
             Boolean OK = false;
             string ItemName = "GTX 1080";
             string StockDescription = "AMD GPU";
            string StockLevel = "2";
            string StockPrice = "100";
            OK = TestStock.ValidExists(ItemName, StockDescription, StockLevel, StockPrice);
             Assert.IsTrue(OK);
         }

         [TestMethod]
         public void StockDescriptionMinPlusOne()
         {
             clsStock TestStock = new clsStock();
             Boolean OK = false;
             string ItemName = "GTx 1080";
             string StockDescription = "Nvidia GPUA";
            string StockLevel = "2";
            string StockPrice = "100";
            OK = TestStock.ValidExists(ItemName, StockDescription, StockLevel, StockPrice);
             Assert.IsTrue(OK);
         }

         [TestMethod]
         public void StockDescriptionMaxLessOne()
         {
             clsStock TestStock = new clsStock();
             Boolean OK = false;
             string ItemName = "GTX 1080";
             string StockDescription = "";
            StockDescription = StockDescription.PadLeft(49, 'a');
            string StockLevel = "2";
            string StockPrice = "100";
            OK = TestStock.ValidExists(ItemName, StockDescription, StockLevel, StockPrice);
             Assert.IsTrue(OK);
         }

         [TestMethod]
         public void StockDescriptionNameMax()
         {
             clsStock TestStock = new clsStock();
             Boolean OK = false;
             string ItemName = "GTX 1080";
             string StockDescription = "gtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgt";
            string StockLevel = "2";
            string StockPrice = "100";
            OK = TestStock.ValidExists(ItemName, StockDescription, StockLevel, StockPrice);
             Assert.IsTrue(OK);
         }

         [TestMethod]
         public void StockDescriptionMid()
         {
             clsStock TestStock = new clsStock();
             Boolean OK = false;
             string ItemName = "GTX1080";
             string StockDescription = "gtgtgtgtgtgtgtgtgtgtgtgtg";
            string StockLevel = "2";
            string StockPrice = "100";
            OK = TestStock.ValidExists(ItemName, StockDescription, StockLevel, StockPrice);
             Assert.IsTrue(OK);
         }

         [TestMethod]
         public void StockDescriptionMaxPlusOne()
         {
             clsStock TestStock = new clsStock();
             Boolean OK = false;
             string ItemName = "GTX 1080";
             string StockDescription = "gtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtgtg";
            string StockLevel = "2";
            string StockPrice = "100";
            OK = TestStock.ValidExists(ItemName, StockDescription, StockLevel, StockPrice);
             Assert.IsFalse(OK);
         }

         [TestMethod]
         public void StockDescriptionExtremeMax()
         {
             clsStock TestStock = new clsStock();
             Boolean OK = false;
             string ItemName = "GTX 1080";
             string StockDescription = "";
             StockDescription = StockDescription.PadRight(1000, 'a');
            string StockLevel = "2";
            string StockPrice = "100";
            OK = TestStock.ValidExists(ItemName, StockDescription, StockLevel, StockPrice);
             Assert.IsFalse(OK);
         }

         [TestMethod]
         public void StockLevelMinLessOne()
         {
             clsStock TestStock = new clsStock();
             Boolean OK = false;
             string ItemName = "GTX1080";
             string StockDescription = "Nvidia GPU";
             string StockLevel = "-1";
             string StockPrice = "100";
             OK = TestStock.ValidExists(ItemName, StockDescription, StockLevel, StockPrice);
             Assert.IsFalse(OK);
         }

         [TestMethod]
         public void StockLevelMin()
         {
             clsStock TestStock = new clsStock();
             Boolean OK = false;
             string ItemName = "GTX 1080";
             string StockDescription = "Nvidia GPU";
            string StockLevel = "0";
            string StockPrice = "100";
            OK = TestStock.ValidExists(ItemName, StockDescription, StockLevel, StockPrice);
             Assert.IsTrue(OK);
         }

         [TestMethod]
         public void StockLevelMinPlusOne()
         {
             clsStock TestStock = new clsStock();
             Boolean OK = false;
             string ItemName = "GTX 1080";
             string StockDescription = "Nvidia GPU";
             string StockLevel = "1";
             string StockPrice = "100";
             OK = TestStock.ValidExists(ItemName, StockDescription, StockLevel, StockPrice);
             Assert.IsTrue(OK);
         }

         [TestMethod]
         public void StockLevelMaxLessOne()
         {
             clsStock TestStock = new clsStock();
             Boolean OK = false;
             string ItemName = "GTX 1080";
             string StockDescription = "Nvidia GPU";
             string StockLevel = "99";
             string StockPrice = "100";
             OK = TestStock.ValidExists(ItemName, StockDescription, StockLevel, StockPrice);
             Assert.IsTrue(OK);
         }

         [TestMethod]
         public void StockLevelMax()
         {
             clsStock TestStock = new clsStock();
             Boolean OK = false;
             string ItemName = "GTX 1080";
             string StockDescription = "Nvidia GPU";
             string StockLevel = "100";
             string StockPrice = "100";
             OK = TestStock.ValidExists(ItemName, StockDescription, StockLevel, StockPrice);
             Assert.IsTrue(OK);
         }

         [TestMethod]
         public void StockLevelMid()
         {
             clsStock TestStock = new clsStock();
             Boolean OK = false;
             string ItemName = "GTX1080";
             string StockDescription = "Nvidia GPU";
             string StockLevel = "50";
             string StockPrice = "100";
             OK = TestStock.ValidExists(ItemName, StockDescription, StockLevel, StockPrice);
             Assert.IsTrue(OK);
         }

         [TestMethod]
         public void StockLevelMaxPlusOne()
         {
             clsStock TestStock = new clsStock();
             Boolean OK = false;
             string ItemName = "GTX 1080";
             string StockDescription = "Nvidia GPU";
             string StockLevel = "101";
             string StockPrice = "100";
             OK = TestStock.ValidExists(ItemName, StockDescription, StockLevel, StockPrice);
             Assert.IsFalse(OK);
         }

         [TestMethod]
         public void StockLevelExtremeMax()
         {
             clsStock TestStock = new clsStock();
             Boolean OK = false;
             string ItemName = "GTX 1080";
             string StockDescription = "Nvidia GPU";
             string StockLevel = "2000";
             string StockPrice = "100";
             OK = TestStock.ValidExists(ItemName, StockDescription, StockLevel, StockPrice);
             Assert.IsFalse(OK);
         }

         [TestMethod]
         public void StockPriceMinLessOne()
         {
             clsStock TestStock = new clsStock();
             Boolean OK = false;
             string ItemName = "GTX1080";
             string StockDescription = "Nvidia GPU";
             string StockLevel = "2";
             string StockPrice = "-1";
             OK = TestStock.ValidExists(ItemName, StockDescription, StockLevel, StockPrice);
             Assert.IsFalse(OK);
         }

         [TestMethod]
         public void StockPriceMin()
         {
             clsStock TestStock = new clsStock();
             Boolean OK = false;
             string ItemName = "GTX 1080";
             string StockDescription = "Nvidia GPU";
             string StockLevel = "2";
             string StockPrice = "0";
             OK = TestStock.ValidExists(ItemName, StockDescription, StockLevel, StockPrice);
             Assert.IsTrue(OK);
         }

         [TestMethod]
         public void StockPriceMinPlusOne()
         {
             clsStock TestStock = new clsStock();
             Boolean OK = false;
             string ItemName = "GTX 1080";
             string StockDescription = "Nvidia GPU";
             string StockLevel = "2";
             string StockPrice = "1";
             OK = TestStock.ValidExists(ItemName, StockDescription, StockLevel, StockPrice);
             Assert.IsTrue(OK);
         }

         [TestMethod]
         public void StockPriceMaxLessOne()
         {
             clsStock TestStock = new clsStock();
             Boolean OK = false;
             string ItemName = "GTX 1080";
             string StockDescription = "Nvidia GPU";
             string StockLevel = "2";
             string StockPrice = "9999";
             OK = TestStock.ValidExists(ItemName, StockDescription, StockLevel, StockPrice);
             Assert.IsTrue(OK);
         }

         [TestMethod]
         public void StockPriceMax()
         {
             clsStock TestStock = new clsStock();
             Boolean OK = false;
             string ItemName = "GTX 1080";
             string StockDescription = "Nvidia GPU";
             string StockLevel = "2";
             string StockPrice = "10000";
             OK = TestStock.ValidExists(ItemName, StockDescription, StockLevel, StockPrice);
             Assert.IsTrue(OK);
         }

         [TestMethod]
         public void StockPriceMid()
         {
             clsStock TestStock = new clsStock();
             Boolean OK = false;
             string ItemName = "GTX 1080";
             string StockDescription = "Nvidia GPU";
             string StockLevel = "2";
             string StockPrice = "5000";
             OK = TestStock.ValidExists(ItemName, StockDescription, StockLevel, StockPrice);
             Assert.IsTrue(OK);
         }

         [TestMethod]
         public void StockPriceMaxPlusOne()
         {
             clsStock TestStock = new clsStock();
             Boolean OK = false;
             string ItemName = "GTX 1080";
             string StockDescription = "Nvidia GPU";
             string StockLevel = "2";
             string StockPrice = "10001";
             OK = TestStock.ValidExists(ItemName, StockDescription, StockLevel, StockPrice);
             Assert.IsFalse(OK);
         }

         [TestMethod]
         public void StockPriceExtremeMax()
         {
             clsStock TestStock = new clsStock();
             Boolean OK = false;
             string ItemName = "GTX 1080";
             string StockDescription = "Nvidia GPU";
             string StockLevel = "2";
             string StockPrice = "1000000";
             OK = TestStock.ValidExists(ItemName, StockDescription, StockLevel, StockPrice);
             Assert.IsFalse(OK);
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
        public void ValidExistsStockID()
        {
            clsStock TestStock = new clsStock();
            Boolean Ok;
            Ok = TestStock.valid5(21);
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

        public void TestStockNoFound()
        {
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockID = StockID = 21;
            Found = AnStock.Find(StockID);

            if (AnStock.StockID != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        
                public void FindMethodOK()
                {
                    clsStock AnStock = new clsStock();
                    Boolean Found = false;
                    Int32 StockID = 21;
                    Found = AnStock.Find(StockID);
                    Assert.IsTrue(Found);
                }

                

                [TestMethod]

                public void TestItemNameFound()
                {
                    clsStock AnStock = new clsStock();
                    Boolean Found = false;
                    Boolean OK = true;
                    Int32 StockID = 21;
                    Found = AnStock.Find(StockID);
                    if (AnStock.ItemName != "GTX1080")
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
                    if (AnStock.StockDescription != "Description")
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
                    if (AnStock.StockLevel != 1)
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
                    if (AnStock.StockPrice != 100)
                    {
                        OK = false;
                    }
                    Assert.IsTrue(OK);
                }

    }
}
