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
        //the following are my tests for customer details 
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
            clsCustomerDetails TestCardNumber = new clsCustomerDetails();
            //create some test data to assign to the property 
            string SomeData = "0236562385697459";
            //assign the data to the property
            TestCardNumber.cardnumber = SomeData;
            //test to see that the two values are the same 
            Assert.AreEqual(TestCardNumber.cardnumber, SomeData);
        }
        [TestMethod]
        public void AccountNumber()
        {
            //instance of the class
            clsCustomerDetails TestAccountNumber = new clsCustomerDetails();
            //create some test data to assign to the property 
            string SomeData = "00856324";
            //assign the data to the property
            TestAccountNumber.accountnumber = SomeData;
            //test to see that the two values are the same 
            Assert.AreEqual(TestAccountNumber.accountnumber, SomeData);
        }
        [TestMethod]
        public void SortCode()
        {
            //instance of the class
            clsCustomerDetails TestSortCode = new clsCustomerDetails();
            //create some test data to assign to the property 
            string SomeData = "004853";
            //assign the data to the property
            TestSortCode.sortcode = SomeData;
            //test to see that the two values are the same 
            Assert.AreEqual(TestSortCode.sortcode, SomeData);
        }
        [TestMethod]
        public void SecurityCode()
        {
            //instance of the class
            clsCustomerDetails TestSecurityCode = new clsCustomerDetails();
            //create some test data to assign to the property 
            string SomeData = "458";
            //assign the data to the property
            TestSecurityCode.securitycode = SomeData;
            //test to see that the two values are the same 
            Assert.AreEqual(TestSecurityCode.securitycode, SomeData);
        }
        [TestMethod]
        public void ExpiryDate()
        {
            //instance of the class
            clsCustomerDetails TestExpiryDate = new clsCustomerDetails();
            //create some test data to assign to the property 
            string SomeData = "11/06";
            //assign the data to the property
            TestExpiryDate.expirydate = SomeData;
            //test to see that the two values are the same 
            Assert.AreEqual(TestExpiryDate.expirydate, SomeData);
        }
        [TestMethod]
        public void MobileNumber()
        {
            //instance of the class
            clsCustomerDetails TestMobileNumber = new clsCustomerDetails();
            //create some test data to assign to the property 
            string SomeData = "07701343822";
            //assign the data to the property
            TestMobileNumber.mobilenumber = SomeData;
            //test to see that the two values are the same 
            Assert.AreEqual(TestMobileNumber.mobilenumber, SomeData);
        }
        [TestMethod]
        public void AddressDoorNumber()
        {
            //instance of the class
            clsCustomerDetails TestAddressDoorNumber = new clsCustomerDetails();
            //create some test data to assign to the property 
            string SomeData = "460";
            //assign the data to the property
            TestAddressDoorNumber.doornumber = SomeData;
            //test to see that the two values are the same 
            Assert.AreEqual(TestAddressDoorNumber.doornumber, SomeData);
        }
        [TestMethod]
        public void AddressStreetName()
        {
            //instance of the class
            clsCustomerDetails TestAddressStreetName = new clsCustomerDetails();
            //create some test data to assign to the property 
            string SomeData = "smith field drive";
            //assign the data to the property
            TestAddressStreetName.streetname = SomeData;
            //test to see that the two values are the same 
            Assert.AreEqual(TestAddressStreetName.streetname, SomeData);
        }
        [TestMethod]
        public void AddressCityName()
        {
            //instance of the class
            clsCustomerDetails TestAddressCityName = new clsCustomerDetails();
            //create some test data to assign to the property 
            string SomeData = "Leicester";
            //assign the data to the property
            TestAddressCityName.cityname= SomeData;
            //test to see that the two values are the same 
            Assert.AreEqual(TestAddressCityName.cityname, SomeData);
        }
        [TestMethod]
        public void AddressPostCode()
        {
            //instance of the class
            clsCustomerDetails TestAddressPostCode = new clsCustomerDetails();
            //create some test data to assign to the property 
            string SomeData = "LE4 7UH";
            //assign the data to the property
            TestAddressPostCode.postcode = SomeData;
            //test to see that the two values are the same 
            Assert.AreEqual(TestAddressPostCode.postcode, SomeData);
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
      }
    }
}
