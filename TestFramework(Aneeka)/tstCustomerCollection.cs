using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace TestFramework_Aneeka_
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection NewPage = new clsCustomerCollection();
            //test to see if it exists
            Assert.IsNotNull(NewPage);
        }
        [TestMethod]
        public void CustomerListOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection ACustomer = new clsCustomerCollection();
            //create some test data to assign to the tests
            List<clsCustomerCollection> TestList = new List<clsCustomerCollection>();
            //add an item to the list
            //create the item of test data
            clsCustomerCollection TestItem = new clsCustomerCollection();
            //set its properties
            TestItem. Active = true;
            TestItem. UserName = "aneekana";
            TestItem. Password = "dmu";
            TestItem. FirstName = "Jonathan";
            TestItem. LastName = "Smith";
            TestItem. EmailAddress = "JonathanSmith@gmail.com";
            TestItem. MobileNumber = "07701343822";
            TestItem. CardNumber = "0236562385697459";
            TestItem. AccountNumber = "00856324";
            TestItem. SortCode = "004853";
            TestItem. SecurityCode = "454";
            TestItem. ExpiryDate = DateTime.Now.Date;
            TestItem. AddressName = "44A";
            TestItem. AddressStreetName = "Newarke Close";
            TestItem. AddressCityName = "Leicester";
            TestItem. AddressPostCode = "LE2 7GZ";
            //add the items to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            ACustomer.CustomerList = TestList;
            //test to see if the valid method works
            Assert.AreEqual(ACustomer.CustomerList, TestList);
        }
        [TestMethod]
        public void CountPropertyOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection ACustomer = new clsCustomerCollection();
            //create soem test data to assign to the property 
            Int32 SomeCount = 0;
            //assign the data to the property 
            ACustomer.Count = SomeCount;
            //test to see if the two values are the same
            Assert.AreEqual(ACustomer.Count, SomeCount);
        }
        [TestMethod]
        public void ListAndCountOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection ACustomer = new clsCustomerCollection();
            //create some test data to assign to the tests
            List<clsCustomerCollection> TestList = new List<clsCustomerCollection>();
            //add an item to the list
            //create the item of test data
            clsCustomerCollection TestItem = new clsCustomerCollection();
            //set its properties
            TestItem.Active = true;
            TestItem.UserName = "aneekana";
            TestItem.Password = "dmu";
            TestItem.FirstName = "Jonathan";
            TestItem.LastName = "Smith";
            TestItem.EmailAddress = "JonathanSmith@gmail.com";
            TestItem.MobileNumber = "07701343822";
            TestItem.CardNumber = "0236562385697459";
            TestItem.AccountNumber = "00856324";
            TestItem.SortCode = "004853";
            TestItem.SecurityCode = "454";
            TestItem.ExpiryDate = DateTime.Now.Date;
            TestItem.AddressName = "44A";
            TestItem.AddressStreetName = "Newarke Close";
            TestItem.AddressCityName = "Leicester";
            TestItem.AddressPostCode = "LE2 7GZ";
            //add the items to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            ACustomer.CustomerList = TestList;
            //test to see if the valid method works
            Assert.AreEqual(ACustomer.CustomerList, TestList.Count);
        }
    }

    }
