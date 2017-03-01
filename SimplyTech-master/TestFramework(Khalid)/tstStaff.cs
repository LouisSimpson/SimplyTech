using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;

namespace Test_Framework
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(StaffMember);
        }

        [TestMethod]
        public void StaffIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //create some test data to assign to the property
            int TestData = 2;
            //assign the data to the property
            StaffMember.StaffId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StaffMember.StaffId, TestData);
        }

        [TestMethod]
        public void TitlePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Mr";
            //assign the data to the property
            StaffMember.Title = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StaffMember.Title, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Khalid";
            //assign the data to the property
            StaffMember.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StaffMember.FirstName, TestData);
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Khalid";
            //assign the data to the property
            StaffMember.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StaffMember.LastName, TestData);
        }

        [TestMethod]
        public void GenderPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Male";
            //assign the data to the property
            StaffMember.Gender = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StaffMember.Gender, TestData);
        }

        [TestMethod]
        public void AddressNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //create some test data to assign to the property
            string TestData = "10";
            //assign the data to the property
            StaffMember.AddressNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StaffMember.AddressNo, TestData);
        }

        [TestMethod]
        public void StreetPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Hight Street";
            //assign the data to the property
            StaffMember.Street = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StaffMember.Street, TestData);
        }

        [TestMethod]
        public void TownPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Leicester";
            //assign the data to the property
            StaffMember.Town = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StaffMember.Town, TestData);
        }

        [TestMethod]
        public void PostCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //create some test data to assign to the property
            string TestData = "LE4 ABC";
            //assign the data to the property
            StaffMember.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StaffMember.PostCode, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Khalid@dmu.ac.uk";
            //assign the data to the property
            StaffMember.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StaffMember.Email, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //create some test data to assign to the property
            string TestData = "HR";
            //assign the data to the property
            StaffMember.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StaffMember.Department, TestData);
        }

        [TestMethod]
        public void SalaryPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //create some test data to assign to the property
            int TestData = 23000;
            //assign the data to the property
            StaffMember.Salary = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StaffMember.Salary, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            StaffMember.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StaffMember.DateAdded, TestData);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            StaffMember.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StaffMember.Active, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = StaffMember.Find(StaffId);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIdFound()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = StaffMember.Find(StaffId);
            //check the Staff ID
            if (StaffMember.StaffId != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestTitleFound()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = StaffMember.Find(StaffId);
            //check the property
            if (StaffMember.Title != "mr")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestFirstNameFound()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = StaffMember.Find(StaffId);
            //check the property
            if (StaffMember.FirstName != "khalid")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastNameFound()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = StaffMember.Find(StaffId);
            //check the property
            if (StaffMember.LastName != "moalin")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestGenderFound()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = StaffMember.Find(StaffId);
            //check the property
            if (StaffMember.Gender != "male")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressNoFound()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = StaffMember.Find(StaffId);
            //check the property
            if (StaffMember.AddressNo != "45")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStreetFound()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = StaffMember.Find(StaffId);
            //check the property
            if (StaffMember.Street != "london close")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTownFound()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = StaffMember.Find(StaffId);
            //check the property
            if (StaffMember.Town != "leicester")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPostCodeFound()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = StaffMember.Find(StaffId);
            //check the property
            if (StaffMember.PostCode != "le40re")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = StaffMember.Find(StaffId);
            //check the property
            if (StaffMember.Email != "khalid@dmu.ac.uk")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestDepartmentFound()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = StaffMember.Find(StaffId);
            //check the property
            if (StaffMember.Department != "HR")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSalaryFound()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = StaffMember.Find(StaffId);
            //check the property
            if (StaffMember.Salary != 10000)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = StaffMember.Find(StaffId);
            //check the property
            if (StaffMember.DateAdded != Convert.ToDateTime("21/02/2017"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = StaffMember.Find(StaffId);
            //check the property
            if (StaffMember.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;  assumed thif field is automaticaly checked by database
            string Title = "Mr";
            string FirstName = "Mow";
            string LastName = "Shino";
            string Gender = "Male";
            string AddressNo = "10";
            string Street = "High Street";
            string Town = "Leicester";
            string PostCode = "LE4ABC";
            string Email = "Mow@dmu.ac.uk";
            string Department = "Accounts";
            Int32 Salary = 23000;
            string DateAdded = DateTime.Now.Date.ToString();

            //invoke the method
            OK = StaffMember.Valid(Title, FirstName, LastName, Gender, AddressNo, Street, Town,
                PostCode, Email, Department, Salary, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TitleMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "";// not ok
            string FirstName = "Mow";
            string LastName = "Shino";
            string Gender = "Male";
            string AddressNo = "10";
            string Street = "High Street";
            string Town = "Leicester";
            string PostCode = "LE4ABC";
            string Email = "Mow@dmu.ac.uk";
            string Department = "Accounts";
            Int32 Salary = 23000;
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = StaffMember.Valid(Title, FirstName, LastName, Gender, AddressNo, Street, Town,
                PostCode, Email, Department, Salary, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TitleMin()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "M";//should be ok
            string FirstName = "Mow";
            string LastName = "Shino";
            string Gender = "Male";
            string AddressNo = "10";
            string Street = "High Street";
            string Town = "Leicester";
            string PostCode = "LE4ABC";
            string Email = "Mow@dmu.ac.uk";
            string Department = "Accounts";
            Int32 Salary = 23000;
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = StaffMember.Valid(Title, FirstName, LastName, Gender, AddressNo, Street, Town,
               PostCode, Email, Department, Salary, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TitleMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "MM";// should pass
            string FirstName = "Mow";
            string LastName = "Shino";
            string Gender = "Male";
            string AddressNo = "10";
            string Street = "High Street";
            string Town = "Leicester";
            string PostCode = "LE4ABC";
            string Email = "Mow@dmu.ac.uk";
            string Department = "Accounts";
            Int32 Salary = 23000;
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = StaffMember.Valid(Title, FirstName, LastName, Gender, AddressNo, Street, Town,
               PostCode, Email, Department, Salary, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TitleMaximum()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "MMMMMM"; //should pass
            string FirstName = "Mow";
            string LastName = "Shino";
            string Gender = "Male";
            string AddressNo = "10";
            string Street = "High Street";
            string Town = "Leicester";
            string PostCode = "LE4ABC";
            string Email = "Mow@dmu.ac.uk";
            string Department = "Accounts";
            Int32 Salary = 23000;
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = StaffMember.Valid(Title, FirstName, LastName, Gender, AddressNo, Street, Town,
               PostCode, Email, Department, Salary, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TitleMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "MMMMM"; //should pass
            string FirstName = "Mow";
            string LastName = "Shino";
            string Gender = "Male";
            string AddressNo = "10";
            string Street = "High Street";
            string Town = "Leicester";
            string PostCode = "LE4ABC";
            string Email = "Mow@dmu.ac.uk";
            string Department = "Accounts";
            Int32 Salary = 23000;
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = StaffMember.Valid(Title, FirstName, LastName, Gender, AddressNo, Street, Town,
               PostCode, Email, Department, Salary, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TitleMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "MMMMMMM"; //should fail
            string FirstName = "Mow";
            string LastName = "Shino";
            string Gender = "Male";
            string AddressNo = "10";
            string Street = "High Street";
            string Town = "Leicester";
            string PostCode = "LE4ABC";
            string Email = "Mow@dmu.ac.uk";
            string Department = "Accounts";
            Int32 Salary = 23000;
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = StaffMember.Valid(Title, FirstName, LastName, Gender, AddressNo, Street, Town,
               PostCode, Email, Department, Salary, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TitleMid()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "MMM"; //should pass
            string FirstName = "Mow";
            string LastName = "Shino";
            string Gender = "Male";
            string AddressNo = "10";
            string Street = "High Street";
            string Town = "Leicester";
            string PostCode = "LE4ABC";
            string Email = "Mow@dmu.ac.uk";
            string Department = "Accounts";
            Int32 Salary = 23000;
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = StaffMember.Valid(Title, FirstName, LastName, Gender, AddressNo, Street, Town,
               PostCode, Email, Department, Salary, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TitleExtremeMaximum()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "";
            Title = Title.PadRight(300, 'M'); //this should fail
            string FirstName = "Mow";
            string LastName = "Shino";
            string Gender = "Male";
            string AddressNo = "10";
            string Street = "High Street";
            string Town = "Leicester";
            string PostCode = "LE4ABC";
            string Email = "Mow@dmu.ac.uk";
            string Department = "Accounts";
            Int32 Salary = 23000;
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = StaffMember.Valid(Title, FirstName, LastName, Gender, AddressNo, Street, Town,
               PostCode, Email, Department, Salary, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";// not ok
            string FirstName = "";
            string LastName = "Shino";
            string Gender = "Male";
            string AddressNo = "10";
            string Street = "High Street";
            string Town = "Leicester";
            string PostCode = "LE4ABC";
            string Email = "Mow@dmu.ac.uk";
            string Department = "Accounts";
            Int32 Salary = 23000;
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = StaffMember.Valid(Title, FirstName, LastName, Gender, AddressNo, Street, Town,
                PostCode, Email, Department, Salary, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void FirstNameMinimum()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";//should be ok
            string FirstName = "A";
            string LastName = "Shino";
            string Gender = "Male";
            string AddressNo = "10";
            string Street = "High Street";
            string Town = "Leicester";
            string PostCode = "LE4ABC";
            string Email = "Mow@dmu.ac.uk";
            string Department = "Accounts";
            Int32 Salary = 23000;
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = StaffMember.Valid(Title, FirstName, LastName, Gender, AddressNo, Street, Town,
               PostCode, Email, Department, Salary, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";// should pass
            string FirstName = "AA";
            string LastName = "Shino";
            string Gender = "Male";
            string AddressNo = "10";
            string Street = "High Street";
            string Town = "Leicester";
            string PostCode = "LE4ABC";
            string Email = "Mow@dmu.ac.uk";
            string Department = "Accounts";
            Int32 Salary = 23000;
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = StaffMember.Valid(Title, FirstName, LastName, Gender, AddressNo, Street, Town,
               PostCode, Email, Department, Salary, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameMaximum()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "";
            FirstName = FirstName.PadRight(50, 'A'); //this should pass
            string LastName = "Shino";
            string Gender = "Male";
            string AddressNo = "10";
            string Street = "High Street";
            string Town = "Leicester";
            string PostCode = "LE4ABC";
            string Email = "Mow@dmu.ac.uk";
            string Department = "Accounts";
            Int32 Salary = 23000;
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = StaffMember.Valid(Title, FirstName, LastName, Gender, AddressNo, Street, Town,
               PostCode, Email, Department, Salary, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr"; //should pass
            string FirstName = "";
            FirstName = FirstName.PadRight(49, 'A'); //this should pass
            string LastName = "Shino";
            string Gender = "Male";
            string AddressNo = "10";
            string Street = "High Street";
            string Town = "Leicester";
            string PostCode = "LE4ABC";
            string Email = "Mow@dmu.ac.uk";
            string Department = "Accounts";
            Int32 Salary = 23000;
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = StaffMember.Valid(Title, FirstName, LastName, Gender, AddressNo, Street, Town,
               PostCode, Email, Department, Salary, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr"; //should fail
            string FirstName = "";
            FirstName = FirstName.PadRight(51, 'A'); //this should fail
            string LastName = "Shino";
            string Gender = "Male";
            string AddressNo = "10";
            string Street = "High Street";
            string Town = "Leicester";
            string PostCode = "LE4ABC";
            string Email = "Mow@dmu.ac.uk";
            string Department = "Accounts";
            Int32 Salary = 23000;
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = StaffMember.Valid(Title, FirstName, LastName, Gender, AddressNo, Street, Town,
               PostCode, Email, Department, Salary, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void firstNameMid()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr"; //should pass
            string FirstName = "";
            FirstName = FirstName.PadRight(25, 'A'); //this should pass
            string LastName = "Shino";
            string Gender = "Male";
            string AddressNo = "10";
            string Street = "High Street";
            string Town = "Leicester";
            string PostCode = "LE4ABC";
            string Email = "Mow@dmu.ac.uk";
            string Department = "Accounts";
            Int32 Salary = 23000;
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = StaffMember.Valid(Title, FirstName, LastName, Gender, AddressNo, Street, Town,
               PostCode, Email, Department, Salary, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void FirstNameExtremeMaximum()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "";
            FirstName = FirstName.PadRight(1000, 'A'); //this should Fail
            string LastName = "Shino";
            string Gender = "Male";
            string AddressNo = "10";
            string Street = "High Street";
            string Town = "Leicester";
            string PostCode = "LE4ABC";
            string Email = "Mow@dmu.ac.uk";
            string Department = "Accounts";
            Int32 Salary = 23000;
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = StaffMember.Valid(Title, FirstName, LastName, Gender, AddressNo, Street, Town,
               PostCode, Email, Department, Salary, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void LastNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";// not ok
            string FirstName = "Adam";
            string LastName = "";
            string Gender = "Male";
            string AddressNo = "10";
            string Street = "High Street";
            string Town = "Leicester";
            string PostCode = "LE4ABC";
            string Email = "Mow@dmu.ac.uk";
            string Department = "Accounts";
            Int32 Salary = 23000;
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = StaffMember.Valid(Title, FirstName, LastName, Gender, AddressNo, Street, Town,
                PostCode, Email, Department, Salary, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void LastNameMinimum()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";//should be ok
            string FirstName = "Adam";
            string LastName = "S";
            string Gender = "Male";
            string AddressNo = "10";
            string Street = "High Street";
            string Town = "Leicester";
            string PostCode = "LE4ABC";
            string Email = "Mow@dmu.ac.uk";
            string Department = "Accounts";
            Int32 Salary = 23000;
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = StaffMember.Valid(Title, FirstName, LastName, Gender, AddressNo, Street, Town,
               PostCode, Email, Department, Salary, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";// should pass
            string FirstName = "Adam";
            string LastName = "SS";
            string Gender = "Male";
            string AddressNo = "10";
            string Street = "High Street";
            string Town = "Leicester";
            string PostCode = "LE4ABC";
            string Email = "Mow@dmu.ac.uk";
            string Department = "Accounts";
            Int32 Salary = 23000;
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = StaffMember.Valid(Title, FirstName, LastName, Gender, AddressNo, Street, Town,
               PostCode, Email, Department, Salary, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void LastNameMaximum()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "";
            LastName = LastName.PadRight(50, 'S'); //this should pass
            string Gender = "Male";
            string AddressNo = "10";
            string Street = "High Street";
            string Town = "Leicester";
            string PostCode = "LE4ABC";
            string Email = "Mow@dmu.ac.uk";
            string Department = "Accounts";
            Int32 Salary = 23000;
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = StaffMember.Valid(Title, FirstName, LastName, Gender, AddressNo, Street, Town,
               PostCode, Email, Department, Salary, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr"; //should pass
            string FirstName = "Adam";
            string LastName = "";
            LastName = LastName.PadRight(49, 'S'); //this should pass
            string Gender = "Male";
            string AddressNo = "10";
            string Street = "High Street";
            string Town = "Leicester";
            string PostCode = "LE4ABC";
            string Email = "Mow@dmu.ac.uk";
            string Department = "Accounts";
            Int32 Salary = 23000;
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = StaffMember.Valid(Title, FirstName, LastName, Gender, AddressNo, Street, Town,
               PostCode, Email, Department, Salary, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr"; //should fail
            string FirstName = "Adam";
            string LastName = "";
            LastName = LastName.PadRight(51, 'S'); //this should pass
            string Gender = "Male";
            string AddressNo = "10";
            string Street = "High Street";
            string Town = "Leicester";
            string PostCode = "LE4ABC";
            string Email = "Mow@dmu.ac.uk";
            string Department = "Accounts";
            Int32 Salary = 23000;
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = StaffMember.Valid(Title, FirstName, LastName, Gender, AddressNo, Street, Town,
               PostCode, Email, Department, Salary, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr"; //should pass
            string FirstName = "Adam";
            string LastName = "";
            LastName = LastName.PadRight(25, 'S'); //this should pass
            string Gender = "Male";
            string AddressNo = "10";
            string Street = "High Street";
            string Town = "Leicester";
            string PostCode = "LE4ABC";
            string Email = "Mow@dmu.ac.uk";
            string Department = "Accounts";
            Int32 Salary = 23000;
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = StaffMember.Valid(Title, FirstName, LastName, Gender, AddressNo, Street, Town,
               PostCode, Email, Department, Salary, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void LastNameExtremeMaximum()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "";
            LastName = LastName.PadRight(2000, 'S'); //this should pass
            string Gender = "Male";
            string AddressNo = "10";
            string Street = "High Street";
            string Town = "Leicester";
            string PostCode = "LE4ABC";
            string Email = "Mow@dmu.ac.uk";
            string Department = "Accounts";
            Int32 Salary = 23000;
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = StaffMember.Valid(Title, FirstName, LastName, Gender, AddressNo, Street, Town,
               PostCode, Email, Department, Salary, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
    }
}
