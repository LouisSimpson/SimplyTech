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

            //changed work

        [TestMethod]
        public void InstanceOk()
        {
            clsCustomerDetails NewPage = new clsCustomerDetails();
            Assert.IsNotNull(NewPage);
        }
        [TestMethod]
        public void CustomerID()
        {
            //create an instance of the class we want to create
            clsCustomerDetails CustomerID = new clsCustomerDetails();
            //create some test data to assign to the property
            Int32 SomeData;
            SomeData = 475;
            //assign the data to the property
            CustomerID.customerid = SomeData;
            //test to see that the two values are the same
            Assert.AreEqual(SomeData, CustomerID.customerid);
        }
        [TestMethod]
        public void FirstName()
        {
            //create an instance of the class we want to create
            clsCustomerDetails TestFirstName = new clsCustomerDetails();
            //create some test data to assign to the property
            string SomeData = "Jonathan";
            //assign the data to the property
            TestFirstName.firstname = SomeData;
            //test to see that the two values are the same
            Assert.AreEqual(SomeData, TestFirstName.firstname);
        }
      
        [TestMethod]
        public void LastName()
        {
            //create an instance of the class we want to create
            clsCustomerDetails TestLastName = new clsCustomerDetails();
            //create some test data to assign to the property
            string SomeData = "Smith";
            //assign the data to the property
            TestLastName.lastname = SomeData;
            //test to see that the two values are the same
            Assert.AreEqual(SomeData, TestLastName.lastname);

        }
        [TestMethod]
        public void EmailAddress()
        {
            //create an instance of the class we want to create
            clsCustomerDetails TestEmailAddress = new clsCustomerDetails();
            //create some test data to assign to the property
            string SomeData = "JonathanSmith@gmail.com";
            //assign the data to the property
            TestEmailAddress.emailaddress = SomeData;
            //test to see that the two values are the same
            Assert.AreEqual(SomeData, TestEmailAddress.emailaddress);

        }
        [TestMethod]
        public void CardNumber()
        {
            //instance of the class
            clsCustomerDetails CustomerDetails = new clsCustomerDetails();
            //create some test data to assign to the property 
            string SomeData = "0236562385697459";
            //assign the data to the property
            CustomerDetails.CardNumber = SomeData;
            //test to see that the two values are the same 
            Assert.AreEqual(CustomerDetails.CardNumber, SomeData);
        }
        [TestMethod]
        public void AccountNumber()
        {
            //instance of the class
            clsCustomerDetails CustomerDetails = new clsCustomerDetails();
            //create some test data to assign to the property 
            string SomeData = "00856324";
            //assign the data to the property
            CustomerDetails.AccountNumber = SomeData;
            //test to see that the two values are the same 
            Assert.AreEqual(CustomerDetails.AccountNumber, SomeData);
        }
        [TestMethod]
        public void SortCode()
        {
            //instance of the class
            clsCustomerDetails CustomerDetails = new clsCustomerDetails();
            //create some test data to assign to the property 
            string SomeData = "004853";
            //assign the data to the property
            CustomerDetails.SortCode = SomeData;
            //test to see that the two values are the same 
            Assert.AreEqual(CustomerDetails.SortCode, SomeData);
        }
        [TestMethod]
        public void SecurityCode()
        {
            //instance of the class
            clsCustomerDetails CustomerDetails = new clsCustomerDetails();
            //create some test data to assign to the property 
            string SomeData = "458";
            //assign the data to the property
            CustomerDetails.SecurityCode = SomeData;
            //test to see that the two values are the same 
            Assert.AreEqual(CustomerDetails.SecurityCode, SomeData);
        }
        [TestMethod]
        public void ExpiryDate()
        {
            //instance of the class
            clsCustomerDetails CustomerDetails = new clsCustomerDetails();
            //create some test data to assign to the property 
            string SomeData = "11/06";
            //assign the data to the property
            CustomerDetails.ExpiryDate = SomeData;
            //test to see that the two values are the same 
            Assert.AreEqual(CustomerDetails.ExpiryDate, SomeData);
        }
        [TestMethod]
        public void MobileNumber()
        {
            //instance of the class
            clsCustomerDetails CustomerDetails = new clsCustomerDetails();
            //create some test data to assign to the property 
            string SomeData = "07701343822";
            //assign the data to the property
            CustomerDetails.mobilenumber = SomeData;
            //test to see that the two values are the same 
            Assert.AreEqual(CustomerDetails.mobilenumber, SomeData);
        }
        [TestMethod]
        public void AddressDoorNumber()
        {
            //instance of the class
            clsCustomerDetails CustomerDetails = new clsCustomerDetails();
            //create some test data to assign to the property 
            string SomeData = "07701343822";
            //assign the data to the property
            CustomerDetails.mobilenumber = SomeData;
            //test to see that the two values are the same 
            Assert.AreEqual(CustomerDetails.mobilenumber, SomeData);
        }
        [TestMethod]
        public void Valid()
        {
            clsCustomerDetails TestHouseNumber = new clsCustomerDetails();
            Boolean Ok;
            Int32 HouseNumber;
            HouseNumber = 25;
            string FirstName;
            FirstName = "Jonathan";
            Ok = TestHouseNumber.Valid(HouseNumber, FirstName);
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void MinBoundary()
        {
            clsCustomerDetails TestHouseNumber = new clsCustomerDetails();
            Boolean Ok = false;
            Int32 HouseNumber;
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
            Ok = TestHouseNumber.Valid(HouseNumber, FirstName);
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
        [TestClass]
        public class tstCustomer
        {
            [TestMethod]
            public void InstanceOk()
            {
                //instance of the class
                clsCustomerDetails CustomerDetails = new clsCustomerDetails();
                //create some test data to assign to the property 
                Assert.IsNotNull(CustomerDetails);
            }
            [TestMethod]
            public void CardNumber()
            {
                //instance of the class
                clsCustomerDetails CustomerDetails = new clsCustomerDetails();
                //create some test data to assign to the property 
                string TestData = "0236562385697459";
                //assign the data to the property
                CustomerDetails.CardNumber = TestData;
                //test to see that the two values are the same 
                Assert.AreEqual(CustomerDetails.CardNumber, TestData);
            }
            [TestMethod]
            public void AccountNumber()
            {
                //instance of the class
                clsCustomerDetails CustomerDetails = new clsCustomerDetails();
                //create some test data to assign to the property 
                string TestData = "00856324";
                //assign the data to the property
                CustomerDetails.AccountNumber = TestData;
                //test to see that the two values are the same 
                Assert.AreEqual(CustomerDetails.AccountNumber, TestData);
            }
            [TestMethod]
            public void SortCode()
            {
                //instance of the class
                clsCustomerDetails CustomerDetails = new clsCustomerDetails();
                //create some test data to assign to the property 
                string TestData = "004853";
                //assign the data to the property
                CustomerDetails.SortCode = TestData;
                //test to see that the two values are the same 
                Assert.AreEqual(CustomerDetails.SortCode, TestData);
            }
            [TestMethod]
            public void SecurityCode()
            {
                //instance of the class
                clsCustomerDetails CustomerDetails = new clsCustomerDetails();
                //create some test data to assign to the property 
                string TestData = "458";
                //assign the data to the property
                CustomerDetails.SecurityCode = TestData;
                //test to see that the two values are the same 
                Assert.AreEqual(CustomerDetails.SecurityCode, TestData);
            }
            [TestMethod]
            public void ExpiryDate()
            {
                //instance of the class
                clsCustomerDetails CustomerDetails = new clsCustomerDetails();
                //create some test data to assign to the property 
                string TestData = "11/06";
                //assign the data to the property
                CustomerDetails.ExpiryDate = TestData;
                //test to see that the two values are the same 
                Assert.AreEqual(CustomerDetails.ExpiryDate, TestData);
            }
        }
    }
}
