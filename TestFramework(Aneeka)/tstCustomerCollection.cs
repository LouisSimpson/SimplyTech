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
            TestItem.secruitycode = "454";
            TestItem.expirydate = DateTime.Now.Date;
            TestItem.addressName = "44A";
            TestItem.streetname = "Newarke Close";
            TestItem.cityname = "Leicester";
            TestItem.postcode = "LE2 7GZ";
            //add the items to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            ACustomer.mCustomerList = TestList;
            //test to see if the valid method works
            Assert.AreEqual(ACustomer.mCustomerList, TestList);
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
            TestItem.customerid = 5;
            TestItem.username = "aneekana";
            TestItem.password = "dmu";
            TestItem.firstname = "Jonathan";
            TestItem.lastname = "Smith";
            TestItem.emailaddress = "JonathanSmith@gmail.com";
            TestItem.mobilenumber = "07701343822";
            TestItem.cardnumber = "0236562385697459";
            TestItem.secruitycode = "454";
            TestItem.expirydate = DateTime.Now.Date;
            TestItem.addressName = "44A";
            TestItem.streetname = "Newarke Close";
            TestItem.cityname = "Leicester";
            TestItem.postcode = "LE2 7GZ";
            //add the items to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            ACustomer.mCustomerList = TestList;
            //test to see if the valid method works
            Assert.AreEqual(ACustomer.mCustomerList.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection ACustomer = new clsCustomerCollection();
            //create the item of test data
            clsCustomerDetails TestItem = new clsCustomerDetails();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.customerid = 5;
            TestItem.username = "Upesh";
            TestItem.password = "Chavda";
            TestItem.firstname = "Upesh";
            TestItem.lastname = "Chavda";
            TestItem.emailaddress = "upeshchavda@sky.com";
            TestItem.mobilenumber = "07754885553";
            TestItem.cardnumber = "02365153439";
            TestItem.secruitycode = "454";
            TestItem.expirydate = DateTime.Now.Date;
            TestItem.addressName = "44A";
            TestItem.streetname = "Newarke Close";
            TestItem.cityname = "Leicester";
            TestItem.postcode = "LE2 7GZ";
            //set this ThisCustomer to the test data
            ACustomer.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = ACustomer.Add();
            //set the primary key of the test data
            TestItem.customerid = PrimaryKey;
            //find the record
            ACustomer.ThisCustomer.Find(PrimaryKey);
            //test to see if the two values are the same
            Assert.AreEqual(ACustomer.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void DeleteCustomerID()
        {
            //create an instance of the class we want to create
            clsCustomerCollection ACustomer = new clsCustomerCollection();
            //create the item of test data
            clsCustomerDetails TestItem = new clsCustomerDetails();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.customerid = 5;
            TestItem.username = "Upesh";
            TestItem.password = "Chavda";
            TestItem.firstname = "Upesh";
            TestItem.lastname = "Chavda";
            TestItem.emailaddress = "upeshchavda@sky.com";
            TestItem.mobilenumber = "07754885553";
            TestItem.cardnumber = "02365153439";
            TestItem.secruitycode = "454";
            TestItem.expirydate = DateTime.Now.Date;
            TestItem.addressName = "44A";
            TestItem.streetname = "Newarke Close";
            TestItem.cityname = "Leicester";
            TestItem.postcode = "LE2 7GZ";
            //set this ThisCustomer to the test data
            ACustomer.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = ACustomer.Add();
            //set the primary key of the test data
            TestItem.customerid = PrimaryKey;
            ACustomer.Delete();
            Boolean found = ACustomer.ThisCustomer.Find(PrimaryKey);
            Assert.IsFalse(found);
        }

        [TestMethod]
        public void UpdateMethodOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection ACustomer = new clsCustomerCollection();
            //create the item of test data
            clsCustomerDetails TestItem = new clsCustomerDetails();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.username = "Upesh";
            TestItem.password = "Chavda";
            TestItem.firstname = "Upesh";
            TestItem.lastname = "Chavda";
            TestItem.emailaddress = "upeshchavda@sky.com";
            TestItem.mobilenumber = "07754885553";
            TestItem.cardnumber = "02365153439";
            TestItem.secruitycode = "454";
            TestItem.expirydate = DateTime.Now.Date;
            TestItem.addressName = "44A";
            TestItem.streetname = "Newarke Close";
            TestItem.cityname = "Leicester";
            TestItem.postcode = "LE2 7GZ";
            //set ThisCustomer to the test data
            ACustomer.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = ACustomer.Add();
            //set the primary key
            TestItem.customerid = PrimaryKey;
            //modify the test data
            TestItem.username = "Upsh";
            TestItem.password = "Chaedda";
            TestItem.firstname = "Updfh";
            TestItem.lastname = "Chavsaa";
            TestItem.emailaddress = "udbghjkhavda@sky.com";
            TestItem.mobilenumber = "07754395553";
            TestItem.cardnumber = "02365147439";
            TestItem.secruitycode = "414";
            TestItem.expirydate = DateTime.Now.Date;
            TestItem.addressName = "48A";
            TestItem.streetname = "Newarke street";
            TestItem.cityname = "Leiceeghnner";
            TestItem.postcode = "LE2 6GP";
            //set the record based on the new test data
            ACustomer.ThisCustomer = TestItem;
            //update the record
            ACustomer.Update();
            //find the record
            ACustomer.ThisCustomer.Find(PrimaryKey);
            //test to see ThisCustomer matches the test data
            Assert.AreEqual(ACustomer.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void FilterByCustomerIdMethodOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection ACustomer = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomer = new clsCustomerCollection();
            //apply a blank string (should return all records);
            FilteredCustomer.FilterByCustomerID(0);
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Count, FilteredCustomer.Count);
        }
        [TestMethod]
        public void FilterByCustomerIdNoneFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomer = new clsCustomerCollection();
            //apply a blank string (should return all records);
            FilteredCustomer.FilterByCustomerID(0);
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredCustomer.Count);
        }
        [TestMethod]
        public void FilterByCustomerIdTestDataFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomer = new clsCustomerCollection();
            //var to store outcome
            Boolean Ok = true;
            //apply a customer id that doesnt exist
            FilteredCustomer.FilterByCustomerID(12);
            //check that the correct number of records are found
            if (FilteredCustomer.Count < 1)
            {
                if (FilteredCustomer.mCustomerList[0].customerid != 12)
                {
                    Ok = false;
                }
            }
            else
            {
                Ok = false;
            }
            //test to see that the two values are the same
            Assert.IsTrue(Ok);
        }

    }
}
