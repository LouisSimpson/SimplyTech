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
            List<clsCustomerDetails> TestList = new List<clsCustomerDetails>();
            //add an item to the list
            //create the item of test data
            clsCustomerDetails TestItem = new clsCustomerDetails();
            //set its properties

            TestItem.username = "aneekana";
            TestItem.password = "dmu";
            TestItem.firstname = "Jonathan";
            TestItem.lastname = "Smith";
            TestItem.emailaddress = "JonathanSmith@gmail.com";
            TestItem.mobilenumber = "07701343822";
            TestItem.cardnumber = "0236562385697459";
            TestItem.securitycode = "454";
            TestItem.expirydate = DateTime.Now.Date;
            TestItem.addressName = "44A";
            TestItem.streetname = "Newarke Close";
            TestItem.cityname = "Leicester";
            TestItem.postcode = "LE2 7GZ";
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
            Int32 SomeCount = 2;
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
            List<clsCustomerDetails> TestList = new List<clsCustomerDetails>();
            //add an item to the list
            //create the item of test data
            clsCustomerDetails TestItem = new clsCustomerDetails();
            //set its properties
            TestItem.username = "aneekana";
            TestItem.password = "dmu";
            TestItem.firstname = "Jonathan";
            TestItem.lastname = "Smith";
            TestItem.emailaddress = "JonathanSmith@gmail.com";
            TestItem.mobilenumber = "07701343822";
            TestItem.cardnumber = "0236562385697459";
            TestItem.securitycode = "454";
            TestItem.expirydate = DateTime.Now.Date;
            TestItem.addressName = "44A";
            TestItem.streetname = "Newarke Close";
            TestItem.cityname = "Leicester";
            TestItem.postcode = "LE2 7GZ";
            //add the items to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            ACustomer.CustomerList = TestList;
            //test to see if the valid method works
            Assert.AreEqual(ACustomer.CustomerList, TestList.Count);
        }

        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //test to see if the two values are the same
            Assert.AreEqual(AllCustomer.Count, 2);
        }

    }
}
