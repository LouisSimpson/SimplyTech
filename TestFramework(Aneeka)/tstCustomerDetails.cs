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
        public string TestDate { get; private set; }

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
        public void CustomerIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerDetails TestCustomerId = new clsCustomerDetails();
            //create some test data to assign to the property
            Int32 SomeData = 15;
            //assign the data to the property
            TestCustomerId.customerid = SomeData;
            // Test to see the values are the same
            Assert.AreEqual(TestCustomerId.customerid, SomeData);

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
        public void SecurityCodePropertyOK()
        {
            //instance of the class
            clsCustomerDetails TestSecurityCode = new clsCustomerDetails();
            //create some test data to assign to the property 
            string SomeData = "458"; 
            //assign the data to the property
            TestSecurityCode.secruitycode = SomeData;
            //test to see that the two values are the same 
            Assert.AreEqual(TestSecurityCode.secruitycode, SomeData);
        }
        [TestMethod]
        public void ExpiryDateAddedPropertyOK()
        {
            //instance of the class
            clsCustomerDetails TestExpiryDate = new clsCustomerDetails();
            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            TestExpiryDate.expirydate = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(TestExpiryDate.expirydate, TestData);
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
        public void ValidMethod()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 CustomerId = 1002;
            string UserName = "aneekana";
            string Password = "dmu";
            string FirstName = "Jonathan";
            string LastName = "Smith";
            string EmailAddress = "JonathanSmith@gmail.com";
            string MobileNumber = "07701343822";
            string CardNumber = "0236562385697459";
            string SecurityCode = "454";
            DateTime ExpiryDate = DateTime.Now.Date;
            string AddressName = "44A";
            string AddressStreetName = "Newarke Close";
            string AddressCityName = "Leicester";
            string AddressPostCode = "LE2 7GZ";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void CustomerIdExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 CustomerId = 1;
            string UserName = "aneekana";
            string Password = "dmu";
            string FirstName = "Jonathan";
            string LastName = "Smith";
            string EmailAddress = "JonathanSmith@gmail.com";
            string MobileNumber = "07701343822";
            string CardNumber = "0236562385697459";
            string SecurityCode = "454";
            DateTime ExpiryDate = DateTime.Now.Date;
            string AddressName = "44A";
            string AddressStreetName = "Newarke Close";
            string AddressCityName = "Leicester";
            string AddressPostCode = "LE2 7GZ";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void CustomerIdMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 CustomerId = 102;
            string UserName = "aneekana";
            string Password = "dmu";
            string FirstName = "Jonathan";
            string LastName = "Smith";
            string EmailAddress = "JonathanSmith@gmail.com";
            string MobileNumber = "07701343822";
            string CardNumber = "0236562385697459";
            string SecurityCode = "454";
            DateTime ExpiryDate = DateTime.Now.Date;
            string AddressName = "44A";
            string AddressStreetName = "Newarke Close";
            string AddressCityName = "Leicester";
            string AddressPostCode = "LE2 7GZ";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void CustomerIdMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 CustomerId = 1003;
            string UserName = "aneekana";
            string Password = "dmu";
            string FirstName = "Jonathan";
            string LastName = "Smith";
            string EmailAddress = "JonathanSmith@gmail.com";
            string MobileNumber = "07701343822";
            string CardNumber = "0236562385697459";
            string SecurityCode = "454";
            DateTime ExpiryDate = DateTime.Now.Date;
            string AddressName = "44A";
            string AddressStreetName = "Newarke Close";
            string AddressCityName = "Leicester";
            string AddressPostCode = "LE2 7GZ";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void CustomerIdMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 CustomerId = 10256;
            string UserName = "aneekana";
            string Password = "dmu";
            string FirstName = "Jonathan";
            string LastName = "Smith";
            string EmailAddress = "JonathanSmith@gmail.com";
            string MobileNumber = "07701343822";
            string CardNumber = "0236562385697459";
            string SecurityCode = "454";
            DateTime ExpiryDate = DateTime.Now.Date;
            string AddressName = "44A";
            string AddressStreetName = "Newarke Close";
            string AddressCityName = "Leicester";
            string AddressPostCode = "LE2 7GZ";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void CustomerIdMid()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 CustomerId = 178974;
            string UserName = "aneekana";
            string Password = "dmu";
            string FirstName = "Jonathan";
            string LastName = "Smith";
            string EmailAddress = "JonathanSmith@gmail.com";
            string MobileNumber = "07701343822";
            string CardNumber = "0236562385697459";
            string SecurityCode = "454";
            DateTime ExpiryDate = DateTime.Now.Date;
            string AddressName = "44A";
            string AddressStreetName = "Newarke Close";
            string AddressCityName = "Leicester";
            string AddressPostCode = "LE2 7GZ";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void CustomerIdMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 CustomerId = 10078956;
            string UserName = "aneekana";
            string Password = "dmu";
            string FirstName = "Jonathan";
            string LastName = "Smith";
            string EmailAddress = "JonathanSmith@gmail.com";
            string MobileNumber = "07701343822";
            string CardNumber = "0236562385697459";
            string SecurityCode = "454";
            DateTime ExpiryDate = DateTime.Now.Date;
            string AddressName = "44A";
            string AddressStreetName = "Newarke Close";
            string AddressCityName = "Leicester";
            string AddressPostCode = "LE2 7GZ";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void CustomerIdMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 CustomerId = 10027895;
            string UserName = "aneekana";
            string Password = "dmu";
            string FirstName = "Jonathan";
            string LastName = "Smith";
            string EmailAddress = "JonathanSmith@gmail.com";
            string MobileNumber = "07701343822";
            string CardNumber = "0236562385697459";
            string SecurityCode = "454";
            DateTime ExpiryDate = DateTime.Now.Date;
            string AddressName = "44A";
            string AddressStreetName = "Newarke Close";
            string AddressCityName = "Leicester";
            string AddressPostCode = "LE2 7GZ";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void CustomerIdMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 CustomerId = 100278954;
            string UserName = "aneekana";
            string Password = "dmu";
            string FirstName = "Jonathan";
            string LastName = "Smith";
            string EmailAddress = "JonathanSmith@gmail.com";
            string MobileNumber = "07701343822";
            string CardNumber = "0236562385697459";
            string SecurityCode = "454";
            DateTime ExpiryDate = DateTime.Now.Date;
            string AddressName = "44A";
            string AddressStreetName = "Newarke Close";
            string AddressCityName = "Leicester";
            string AddressPostCode = "LE2 7GZ";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void CustomerIdExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 CustomerId = 1052145214;
            string UserName = "aneekana";
            string Password = "dmu";
            string FirstName = "Jonathan";
            string LastName = "Smith";
            string EmailAddress = "JonathanSmith@gmail.com";
            string MobileNumber = "07701343822";
            string CardNumber = "0236562385697459";
            string SecurityCode = "454";
            DateTime ExpiryDate = DateTime.Now.Date;
            string AddressName = "44A";
            string AddressStreetName = "Newarke Close";
            string AddressCityName = "Leicester";
            string AddressPostCode = "LE2 7GZ";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            Int32 CustomerId = 1002;
            string UserName = "aneekana";
            string Password = "dmu";
            string AddressCityName = "P";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            Int32 CustomerId = 1002;
            string UserName = "aneekana";
            string Password = "dmu";
            string AddressCityName = "Le";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Lei";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";

            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            Int32 CustomerId = 1002;
            string UserName = "aneekana";
            string Password = "dmu";
            string AddressCityName = "Leed";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            Int32 CustomerId = 1002;
            string UserName = "aneekana";
            string Password = "dmu";
            string AddressCityName = "abcdefghijklmnopqrstuvwxyz";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            Int32 CustomerId = 1002;
            string UserName = "aneekana";
            string Password = "dmu";
            string AddressCityName = "Lhunkilophnjutgfertcxsderftyuikjhngtusopledftgyhu";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            Int32 CustomerId = 1002;
            string UserName = "aneekana";
            string Password = "dmu";
            string AddressCityName = "Lhunkilophnjutgfertcxsderftyuikjhngtusopledftgyhud";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            Int32 CustomerId = 1002;
            string UserName = "aneekana";
            string Password = "dmu";
            string AddressCityName = "Lhunkilophnjutgfertcxsderftyuikjhngtusopledftgyhtud";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            Int32 CustomerId = 1002;
            string UserName = "aneekana";
            string Password = "dmu";
            string AddressCityName = "Lhunkilophnjutgfertcxsderftyuikjhngtusopledftgyhudgnhtfedso";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            Int32 CustomerId = 1002;
            string UserName = "aneekana";
            string Password = "dmu";
            string AddressCityName = "Leicester";
            string AddressName = "";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";

            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "3";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";

            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "48";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";

            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "smithhousetghbj";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";

            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "opencourthousenjmikiohdbgstyuudjuiopkmhbjnshgcjsi";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";

            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "opencourthousenjmikiohdbgstyuudkjuiopkmhbjnshgcjsi";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";

            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "opencourthousenjmikiohdbgstyuudkjuiopkmhbjnshgcjsij";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";

            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "opencourthousenjmikiohdbgstyuudjumikgvdfrkjuiopkmhbjnshgcjsi";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";

            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekanas";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";

            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LDE2 7G";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";

            //invoke the method  
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LED2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";

            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LRE2 7GZ8";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";

            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "L2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";

            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "BD12 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";

            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "BD12 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";

            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "DE12 77GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";

            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LEW22 7GZH";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
            
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "New";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
            
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode,  UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "park";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.co.uk";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
            
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode,  UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
            
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            Int32 CustomerId = 1002;
            string UserName = "aneekana";
            string Password = "dmu";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newark";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode,  UserName, Password);
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
            Int32 CustomerId = 1002;
            string UserName = "aneekana";
            string Password = "dmu";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarkes Closes";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            Int32 CustomerId = 1002;
            string UserName = "aneekana";
            string Password = "dmu";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarkes Closes The MidWay St";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarkes Closes The MidWay Str";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
            
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarkes Closes The MidWay Stre";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
            
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarkes Closes The MidWay Street highwa";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
            
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "13478";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
            
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void CardNumberMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "125678909876543";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
            
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void CardNumberMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
            
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "67898765456789875";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
            
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void CardNumberMid()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "12345678";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
            
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void CardNumberMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "123456789789765";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
            
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void CardNumberMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567898765432";
            string EmailAddress = "aneeka"; //@gmail.com
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
            
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "12345678927395784";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
         
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void CardNumberExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "12345678922389457389";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
         
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void EmailAddressExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "an";//@gmail.com
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
           
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void EmailAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneek";//@gmail.com
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
       
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void EmailAddressMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka";//@gmail.com
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
          
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneekas";// @gmail.com
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
         
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneekaednjmksdh";//@gmail.com
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
      
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneekadcfgbhnjmkedxcdhnwikmdh"; //@gmail.com
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
       
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneekadcfgbhnjmkedxcdhnwikmddh"; // @gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
     
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneekadcfgbhnjmkedxcdhnwikmdhdd"; //@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
         
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void EmailAddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
           
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = DateTime.Now.Date.AddMonths(-1);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
        
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void ExpiryDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = DateTime.Now.Date.AddDays(-1); ;
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
         
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void ExpiryDateMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = DateTime.Now.Date;
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
          
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = DateTime.Now.Date.AddDays(1); ;
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
        
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = DateTime.Now.Date.AddYears(2).AddMonths(6); ;
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
           
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = DateTime.Now.Date.AddYears(5).AddDays(-1);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
         
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = DateTime.Now.Date.AddYears(5);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
       
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = DateTime.Now.Date.AddYears(5).AddDays(1);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
      
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void ExpiryDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = DateTime.Now.Date.AddYears(10);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
      
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void FirstNameExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "A";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
         
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Si";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
        
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "max";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
     
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Abcd";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
       
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneujkmhd";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
        
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Anujumghdchbad";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
         
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;

            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Anujumghdchbadb";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
            
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;

            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Anujumghdchbadbh";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
         
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;

            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Anujumghdchbadbhjumkfgtesc";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
            
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void LastNameExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;

            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "N";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
      
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void LastNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;

            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Na";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
           
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;

            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
           
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;

            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naug";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
      
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;

            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Nazyuhnj";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
       
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;

            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "uimkhnjugdfvbjko";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
           
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void LastNameMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;

            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "hymuklidhctudnj";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
            
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;

            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "hjumikjhbgthyjkn";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
        
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void LastNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;

            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Anujumghdchbadbhjumkfgtesc";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
            
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void MobileNumberExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;

            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "0";
            string SecurityCode = "454";
          
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void MobileNumberMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;

            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "0778983476";
            string SecurityCode = "454";
           
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void MobileNumberMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;

            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07906789453";
            string SecurityCode = "454";
           
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;

            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "076345894325";
            string SecurityCode = "454";
       
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void MobileNumberMid()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;

            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "078543";
            string SecurityCode = "454";
            
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void MobileNumberMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;

            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "0790765438";
            string SecurityCode = "454";
       
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void MobileNumberMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;

            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07896654378";
            string SecurityCode = "454";
    
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;

            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "077855436785";
            string SecurityCode = "454";
            
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void MobileNumberExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;

            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "074563778965436";
            string SecurityCode = "454";
            
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void SecurityCodeExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;

            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "4";
            
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void SecurityCodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;

            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "45";
            
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void SecurityCodeMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;

            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
            
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;

            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "4544";
            
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void SecurityCodeMid()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;

            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "44";
           
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void SecurityCodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string UserName = "aneekana";
            string Password = "dmu";
            Int32 CustomerId = 1002;

            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "34";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void SecurityCodeMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 CustomerId = 1002;

            string UserName = "aneekana";
            string Password = "dmu";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "454";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
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
            Int32 CustomerId = 1002;

            string UserName = "aneekana";
            string Password = "dmu";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "4534";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void SecurityCodeExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 CustomerId = 1002;

            string UserName = "aneekana";
            string Password = "dmu";
            string AddressCityName = "Leicester";
            string AddressName = "44A";
            string AddressPostCode = "LE2 7GZ";
            string AddressStreetName = "Newarke Close";
            string CardNumber = "1234567890123456";
            string EmailAddress = "aneeka@gmail.com";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string MobileNumber = "07894561332";
            string SecurityCode = "437854";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode,  UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
       
        [TestMethod]
        public void UserNameExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 CustomerId = 1002;

            string UserName = "a";
            string Password = "dmu";
            string FirstName = "Jonathan";
            string LastName = "Smith";
            string EmailAddress = "JonathanSmith@gmail.com";
            string MobileNumber = "07701343822";
            string CardNumber = "0236562385697459";
            string SecurityCode = "454";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string AddressName = "44A";
            string AddressStreetName = "Newarke Close";
            string AddressCityName = "Leicester";
            string AddressPostCode = "LE2 7GZ";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void UserNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 CustomerId = 1002;

            string UserName = "abc";
            string Password = "dmu";
            string FirstName = "Jonathan";
            string LastName = "Smith";
            string EmailAddress = "JonathanSmith@gmail.com";
            string MobileNumber = "07701343822";
            string CardNumber = "0236562385697459";
            string SecurityCode = "454";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string AddressName = "44A";
            string AddressStreetName = "Newarke Close";
            string AddressCityName = "Leicester";
            string AddressPostCode = "LE2 7GZ";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void UserNameMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 CustomerId = 1002;

            string UserName = "abcd";
            string Password = "dmu";
            string FirstName = "Jonathan";
            string LastName = "Smith";
            string EmailAddress = "JonathanSmith@gmail.com";
            string MobileNumber = "07701343822";
            string CardNumber = "0236562385697459";
            string SecurityCode = "454";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string AddressName = "44A";
            string AddressStreetName = "Newarke Close";
            string AddressCityName = "Leicester";
            string AddressPostCode = "LE2 7GZ";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void UserNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 CustomerId = 1002;

            string UserName = "abcdh";
            string Password = "dmu";
            string FirstName = "Jonathan";
            string LastName = "Smith";
            string EmailAddress = "JonathanSmith@gmail.com";
            string MobileNumber = "07701343822";
            string CardNumber = "0236562385697459";
            string SecurityCode = "454";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string AddressName = "44A";
            string AddressStreetName = "Newarke Close";
            string AddressCityName = "Leicester";
            string AddressPostCode = "LE2 7GZ";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void UserNameMid()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 CustomerId = 1002;

            string UserName = "abcdhu";
            string Password = "dmu";
            string FirstName = "Jonathan";
            string LastName = "Smith";
            string EmailAddress = "JonathanSmith@gmail.com";
            string MobileNumber = "07701343822";
            string CardNumber = "0236562385697459";
            string SecurityCode = "454";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string AddressName = "44A";
            string AddressStreetName = "Newarke Close";
            string AddressCityName = "Leicester";
            string AddressPostCode = "LE2 7GZ";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void UserNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 CustomerId = 1002;

            string UserName = "abcdhui";
            string Password = "dmu";
            string FirstName = "Jonathan";
            string LastName = "Smith";
            string EmailAddress = "JonathanSmith@gmail.com";
            string MobileNumber = "07701343822";
            string CardNumber = "0236562385697459";
            string SecurityCode = "454";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string AddressName = "44A";
            string AddressStreetName = "Newarke Close";
            string AddressCityName = "Leicester";
            string AddressPostCode = "LE2 7GZ";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void UserNameMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 CustomerId = 1002;

            string UserName = "abcdhuit";
            string Password = "dmu";
            string FirstName = "Jonathan";
            string LastName = "Smith";
            string EmailAddress = "JonathanSmith@gmail.com";
            string MobileNumber = "07701343822";
            string CardNumber = "0236562385697459";
            string SecurityCode = "454";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string AddressName = "44A";
            string AddressStreetName = "Newarke Close";
            string AddressCityName = "Leicester";
            string AddressPostCode = "LE2 7GZ";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void UserNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 CustomerId = 1002;

            string UserName = "abcdhuite";
            string Password = "dmu";
            string FirstName = "Jonathan";
            string LastName = "Smith";
            string EmailAddress = "JonathanSmith@gmail.com";
            string MobileNumber = "07701343822";
            string CardNumber = "0236562385697459";
            string SecurityCode = "454";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string AddressName = "44A";
            string AddressStreetName = "Newarke Close";
            string AddressCityName = "Leicester";
            string AddressPostCode = "LE2 7GZ";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode,  UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void UserNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 CustomerId = 1002;

            string UserName = "abdhynuedhdtgbdu";
            string Password = "dmu";
            string FirstName = "Jonathan";
            string LastName = "Smith";
            string EmailAddress = "JonathanSmith@gmail.com";
            string MobileNumber = "07701343822";
            string CardNumber = "0236562385697459";
            string SecurityCode = "454";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string AddressName = "44A";
            string AddressStreetName = "Newarke Close";
            string AddressCityName = "Leicester";
            string AddressPostCode = "LE2 7GZ";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void PasswordExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 CustomerId = 1002;

            string UserName = "aneekana";
            string Password = "d";
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string EmailAddress = "aneeka@customer.co.uk";
            string MobileNumber = "07894561332";
            string CardNumber = "1234567890123456";
            string SecurityCode = "454";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string AddressName = "44A";
            string AddressStreetName = "Newarke Close";
            string AddressCityName = "Leicester";
            string AddressPostCode = "LE2 7GZ";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void PasswordMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 CustomerId = 1002;

            string UserName = "aneekana";
            string Password = "sal";
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string EmailAddress = "aneeka@customer.co.uk";
            string MobileNumber = "07894561332";
            string CardNumber = "1234567890123456";
            string SecurityCode = "454";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string AddressName = "44A";
            string AddressStreetName = "Newarke Close";
            string AddressCityName = "Leicester";
            string AddressPostCode = "LE2 7GZ";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void PasswordMin()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 CustomerId = 1002;

            string UserName = "aneekana";
            string Password = "help";
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string EmailAddress = "aneeka@customer.co.uk";
            string MobileNumber = "07894561332";
            string CardNumber = "1234567890123456";
            string SecurityCode = "454";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string AddressName = "44A";
            string AddressStreetName = "Newarke Close";
            string AddressCityName = "Leicester";
            string AddressPostCode = "LE2 7GZ";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void PasswordMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 CustomerId = 1002;

            string UserName = "aneekana";
            string Password = "lapuh";
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string EmailAddress = "aneeka@customer.co.uk";
            string MobileNumber = "07894561332";
            string CardNumber = "1234567890123456";
            string SecurityCode = "454";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string AddressName = "44A";
            string AddressStreetName = "Newarke Close";
            string AddressCityName = "Leicester";
            string AddressPostCode = "LE2 7GZ";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void PasswordMid()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 CustomerId = 1002;

            string UserName = "aneekana";
            string Password = "dmtgh";
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string EmailAddress = "aneeka@customer.co.uk";
            string MobileNumber = "07894561332";
            string CardNumber = "1234567890123456";
            string SecurityCode = "454";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string AddressName = "44A";
            string AddressStreetName = "Newarke Close";
            string AddressCityName = "Leicester";
            string AddressPostCode = "LE2 7GZ";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void PasswordMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 CustomerId = 1002;

            string UserName = "aneekana";
            string Password = "dmuhunjdf";
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string EmailAddress = "aneeka@customer.co.uk";
            string MobileNumber = "07894561332";
            string CardNumber = "1234567890123456";
            string SecurityCode = "454";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string AddressName = "44A";
            string AddressStreetName = "Newarke Close";
            string AddressCityName = "Leicester";
            string AddressPostCode = "LE2 7GZ";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void PasswordMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 CustomerId = 1002;

            string UserName = "aneekana";
            string Password = "dmuedtgbdr";
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string EmailAddress = "aneeka@customer.co.uk";
            string MobileNumber = "07894561332";
            string CardNumber = "1234567890123456";
            string SecurityCode = "454";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string AddressName = "44A";
            string AddressStreetName = "Newarke Close";
            string AddressCityName = "Leicester";
            string AddressPostCode = "LE2 7GZ";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 CustomerId = 1002;

            string UserName = "aneekana";
            string Password = "dmyhgtrednh";
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string EmailAddress = "aneeka@customer.co.uk";
            string MobileNumber = "07894561332";
            string CardNumber = "1234567890123456";
            string SecurityCode = "454";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string AddressName = "44A";
            string AddressStreetName = "Newarke Close";
            string AddressCityName = "Leicester";
            string AddressPostCode = "LE2 7GZ";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void PasswordExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomerDetails ACustomer = new clsCustomerDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 CustomerId = 1002;

            string UserName = "aneekana";
            string Password = "dmedftghnjmedsu";
            string FirstName = "Aneeka";
            string LastName = "Naz";
            string EmailAddress = "aneeka@customer.co.uk";
            string MobileNumber = "07894561332";
            string CardNumber = "1234567890123456";
            string SecurityCode = "454";
            DateTime ExpiryDate = new DateTime(2019, 05, 25);
            string AddressName = "44A";
            string AddressStreetName = "Newarke Close";
            string AddressCityName = "Leicester";
            string AddressPostCode = "LE2 7GZ";
            //invoke the method
            Ok = ACustomer.Valid(CustomerId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, CardNumber, EmailAddress, ExpiryDate, FirstName, LastName, MobileNumber, SecurityCode, UserName, Password);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        

    }
}


