using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace MyTestFrame
{
    /// <summary>
    /// Summary description for tstCustomerDetails
    /// </summary>
    [TestClass]
    public class tstCustomerDetails
    {
        public tstCustomerDetails()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        
        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void InstanceOk()
        {
            clsCustomerDetails NewPage = new clsCustomerDetails();
            Assert.IsNotNull(NewPage);
        }
        [TestMethod]
        public void FirstName()
        {
            clsCustomerDetails TestFirstName= new clsCustomerDetails();
            string SomeName = "Jonathan";
            TestFirstName.firstname = SomeName;
            Assert.AreEqual( SomeName,TestFirstName.firstname);
        }
        [TestMethod]
        public void CustomerID()
        {
            clsCustomerDetails CustomerID = new clsCustomerDetails();
            Int32 SomeNumber;
            SomeNumber = 475;
            CustomerID.customerid = SomeNumber;
            Assert.AreEqual(SomeNumber, CustomerID.customerid);
        }
        [TestMethod]
        public void Valid()
        {
            clsCustomerDetails TestHouseNumber = new clsCustomerDetails();
            Boolean Ok;
            Int32 HouseNumber;
            HouseNumber = 25;
            string FirstName;
            FirstName= "Jonathan";
            Ok = TestHouseNumber.Valid(HouseNumber, FirstName);
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void MinBoundary()
        {
            clsCustomerDetails TestHouseNumber = new clsCustomerDetails();
            Boolean Ok = false;
            Int32 HouseNumber ;
            HouseNumber = 2;
            string FirstName;
            FirstName = "tim";
            Ok = TestHouseNumber.Valid(HouseNumber, FirstName);
            Assert.IsTrue(Ok);
        }


        [TestMethod]
        public void MaxBoundary()
        {
            clsCustomerDetails TestHouseNumber = new clsCustomerDetails();
            Boolean Ok = false;
            Int32 HouseNumber;
            HouseNumber = 1234;
            string FirstName;
            FirstName = "timhytihndtgeuld";
            Ok = TestHouseNumber.Valid(HouseNumber, FirstName);
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void ExtremeMin()
        {
            clsCustomerDetails TestHouseNumber = new clsCustomerDetails();
            Boolean Ok = false;
            Int32 HouseNumber;
            HouseNumber = 2;
            string FirstName;
            FirstName = "T";
            Ok = TestHouseNumber.Valid(HouseNumber,FirstName);
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void MinMinusOne()
        {
            clsCustomerDetails TestHouseNumber = new clsCustomerDetails();
            Boolean Ok = false;
            Int32 HouseNumber;
            HouseNumber = 0;
            string FirstName;
            FirstName = "";
            Ok = TestHouseNumber.Valid(HouseNumber, FirstName);
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void MinPlusOne()
        {
            clsCustomerDetails TestHouseNumber = new clsCustomerDetails();
            Boolean Ok = false;
            Int32 HouseNumber;
            HouseNumber = 45;
            string FirstName;
            FirstName = "Trge";
            Ok = TestHouseNumber.Valid(HouseNumber, FirstName);
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void MaxMinusOne()
        {
            clsCustomerDetails TestHouseNumber = new clsCustomerDetails();
            Boolean Ok = false;
            Int32 HouseNumber;
            HouseNumber = 863;
            string FirstName;
            FirstName = "TGDUNKLOUGHBSTDX";
            Ok = TestHouseNumber.Valid(HouseNumber, FirstName);
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void MaxPlusOne()
        {
            clsCustomerDetails TestHouseNumber = new clsCustomerDetails();
            Boolean Ok = false;
            Int32 HouseNumber;
            HouseNumber = 86893;
            string FirstName;
            FirstName = "HSUNKLOTDGHXTGSNZ";
            Ok = TestHouseNumber.Valid(HouseNumber, FirstName);
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void Mid()
        {
            clsCustomerDetails TestHouseNumber = new clsCustomerDetails();
            Boolean Ok = false;
            Int32 HouseNumber;
            HouseNumber = 86;
            string FirstName;
            FirstName = "uhdnjsut";
            Ok = TestHouseNumber.Valid(HouseNumber, FirstName);
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void ExtremeMax()
        {
            clsCustomerDetails TestHouseNumber = new clsCustomerDetails();
            Boolean Ok = false;
            Int32 HouseNumber;
            HouseNumber = 84125965;
            string FirstName;
            FirstName = "dhjcngshtdnkdhnaolptdwens";
            Ok = TestHouseNumber.Valid(HouseNumber, FirstName);
            Assert.IsFalse(Ok);
        }
    }
}
