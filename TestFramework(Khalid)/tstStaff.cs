using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace MyTestFramework
{
    /// <summary>
    /// Summary description for tstStaff
    /// </summary>
    [TestClass]
    public class tstStaff
    {
        public tstStaff()
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
            clsStaff TestStaff = new clsStaff();
            Assert.IsNotNull(TestStaff);
        }

        //The following code is to test an int property
        [TestMethod]
        public void StaffId()
        {
            //create an instance of the class we want to create
            clsStaff TestStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "12345";
            //assign the data to the property
            TestStaff.StaffId = TestData;
            // Test to see the values are the same
            Assert.AreEqual(TestStaff.StaffId, TestData);

        }
        
        // this code will test a string property
        [TestMethod]
        public void FirstNamePropertyOk()
        {
            //create an instance of the class we want to create
            clsStaff TestStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Khalid";
            //assign the data to the property
            TestStaff.FirstName = TestData;
            // Test to see the values are the same
            Assert.AreEqual(TestStaff.FirstName, TestData);

        }

        

        // in this method staff Id is checked
        // staff id must be eqaul to 1 to be valid
        // otherwise the valid() method will return false;
        [TestMethod]
        public void StaffIdCheck()
        {
            //create an instance of the class we want to create
            clsStaff TestStaff = new clsStaff();
            Boolean OK;
            //create some test data to assign to the property
            int StaffId = 2;
            //assign the data to the property
            //because I am only checking staff id I will give the correct date
            string DateAdded = "11/01/2017";
            OK = TestStaff.Valid(StaffId, DateAdded);
            Assert.IsFalse(OK);
        }

        // in this method staff date added is check to 
        // see if it less today date.
        // if staff date added is less than today date
        // the valid method will return false
        [TestMethod]
        public void StuffAddedDateCheck_Min()
        {
            //create an instance of the class we want to create
            clsStaff TestStaff = new clsStaff();
      
            Boolean OK;
            //this test is for only date added
            //so I am giving the correct id
            int StaffId = 1;
            string DateAdded = "05/05/2015";
            OK = TestStaff.Valid(StaffId, DateAdded);
            Assert.IsFalse(OK);
        }

        
    }   
}
