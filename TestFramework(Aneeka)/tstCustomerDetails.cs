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
        public void CustomerIDPropertyOK()
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
        public void FirstNamePropertyOK()
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
        public void LastNamePropertyOK()
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
        public void EmailAddressPropertyOK()
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
        public void CardNumberPropertyOK()
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
        public void AccountNumberPropertyOK()
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
        public void SortCodePropertyOK()
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
        public void SecurityCodePropertyOK()
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
        public void ExpiryDatePropertyOK()
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
        public void MobileNumberPropertyOK()
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
        public void AddressNamePropertyOKr()
        {
            //instance of the class
            clsCustomerDetails TestAddressName = new clsCustomerDetails();
            //create some test data to assign to the property 
            string SomeData = "460";
            //assign the data to the property
            TestAddressName.addressName = SomeData;
            //test to see that the two values are the same 
            Assert.AreEqual(TestAddressName.addressName, SomeData);
        }
        [TestMethod]
        public void AddressStreetNamePropertyOK()
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
        public void AddressCityNamePropertyOK()
        {
            //instance of the class
            clsCustomerDetails TestAddressCityName = new clsCustomerDetails();
            //create some test data to assign to the property 
            string SomeData = "Leicester";
            //assign the data to the property
            TestAddressCityName.cityname = SomeData;
            //test to see that the two values are the same 
            Assert.AreEqual(TestAddressCityName.cityname, SomeData);
        }
        [TestMethod]
        public void AddressPostCodePropertyOK()
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
        public void UserNamePropertyOK()
        {
            //instance of the class
            clsCustomerDetails TestUserName = new clsCustomerDetails();
            //create some test data to assign to the property 
            string SomeData = "aneekanaz";
            //assign the data to the property
            TestUserName.username = SomeData;
            //test to see that the two values are the same 
            Assert.AreEqual(TestUserName.username, SomeData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            //instance of the class
            clsCustomerDetails TestPassword = new clsCustomerDetails();
            //create some test data to assign to the property 
            string SomeData = "dmu";
            //assign the data to the property
            TestPassword.password = SomeData;
            //test to see that the two values are the same 
            Assert.AreEqual(TestPassword.password, SomeData);
        }
        [TestMethod]
        public void Valid()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            string UserName = "aneekanaz";
            string Password = "dmu";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void AccountNumberExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "123";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void AccountNumberMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "1234567";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void AccountNumberMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void AccountNumberMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "123456789";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void AccountNumberMid()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void AccountNumberMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "1234567";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void AccountNumberMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void AccountNumberMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "123456789";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void AccountNumberExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "123456789012";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void AddresscityNameExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "P";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void AddresscityNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "123456789012";
            string AddressCityName = "Le";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void AddresscityNameMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Lei";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddresscityNameMinplusOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leed";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddresscityNameMid()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "abcdefghijklmnopqrstuvwxyz";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddresscityNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Lhunkilophnjutgfertcxsderftyuikjhngtusopledftgyhu";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddresscityNameMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Lhunkilophnjutgfertcxsderftyuikjhngtusopledftgyhud";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddresscityNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "123456789012";
            string AddressCityName = "Lhunkilophnjutgfertcxsderftyuikjhngtusopledftgyhtud";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void AddresscityNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "123456789012";
            string AddressCityName = "Lhunkilophnjutgfertcxsderftyuikjhngtusopledftgyhudgnhtfedso";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void AddressNameExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void AddressNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void AddressNameMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "3";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddressNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string Addressname = "48";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, Addressname, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddressNameMid()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "smithhousetghbj";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddressNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "opencourthousenjmikiohdbgstyuudjuiopkmhbjnshgcjsi";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddressNameMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "opencourthousenjmikiohdbgstyuudkjuiopkmhbjnshgcjsi";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddressNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "opencourthousenjmikiohdbgstyuudkjuiopkmhbjnshgcjsij";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void AddressNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "opencourthousenjmikiohdbgstyuudjumikgvdfrkjuiopkmhbjnshgcjsi";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void AddressPostCodeExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void AddressPostCodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LDE2 7G";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void ValiAddressPostCodeMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LED2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddressPostCodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LRE2 7GZ8";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void AddressPostCodeMid()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "L2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddressPostCodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "BD12 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddressPostCodeMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "BD12 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddressPostCodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "DE12 77GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void AddressPostCodeExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LEW22 7GZH";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void AddressStreetNameExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "New";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddressStreetNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "park";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddressStreetNameMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddressStreetNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newark";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddressStreetNameMid()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarkes Closes";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddressStreetNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarkes Closes The MidWay St";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddressStreetNameMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarkes Closes The MidWay Str";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddressStreetNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarkes Closes The MidWay Stre";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void AddressStreetNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarkes Closes The MidWay Street highwa";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void CardNumberExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void CardNumberMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void CardNumberMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void CardNumberMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void CardNumberMid()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void CardNumberMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void CardNumberMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void CardNumberMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void CardNumberExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void CustomerIDExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void CustomerIDMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void CustomerIDMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void CustomerIDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void CustomerIDMid()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void CustomerIDMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void CustomerIDMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void CustomerIDMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void CustomerIDExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void EmailAddressExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void EmailAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void EmailAddressMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void EmailAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void EmailAddressMid()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void EmailAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void EmailAddressMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void EmailAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void EmailAddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void ExpiryDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void ExpiryDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void ExpiryDateMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void ExpiryDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void ExpiryDateMid()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void ExpiryDateMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void ExpiryDateMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void ExpiryDateMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void ExpiryDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void FirstNameExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void LastNameExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void LastNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void LastNameMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void LastNameMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void LastNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void MobileNumberExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void MobileNumberMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void MobileNumberMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void MobileNumberMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void MobileNumberMid()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void MobileNumberMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void MobileNumberMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void MobileNumberMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void MobileNumberExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void SecurityCodeExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void SecurityCodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void SecurityCodeMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void SecurityCodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void SecurityCodeMid()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void SecurityCodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void SecurityCodeMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void SecurityCodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void SecurityCodeExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void SortCodeExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void SortCodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void SortCodeMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void SortCodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void SortCodeMid()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void SortCodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void SortCodeMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void SortCodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void SortCodeExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string AccountNumber = "12345678";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            int CustomerID = 1001;
            string EmailAddress = "aneeka@customer.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            int SecurityCode = 454;
            string SortCode = "124596";
            //invoke the method
            Ok = ACustomer.Valid(AccountNumber, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, CustomerID, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, SortCode);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }


    }
}


