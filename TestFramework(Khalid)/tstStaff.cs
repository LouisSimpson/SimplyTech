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
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "SS";// should pass
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
            LastName = LastName.PadRight(51, 'S'); //this should not pass
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
            LastName = LastName.PadRight(2000, 'S'); //this should not pass
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
        public void GenderMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Awale";
            string Gender = "";// this should not be ok
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
        public void GenderMinimum()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "M";// should be ok
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
        public void GenderMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";// should pass
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "MM";// should be ok
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
        public void GenderMaximum()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Maleee";// should be ok, max of 6 char
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
        public void GenderMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr"; //should pass
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Malee";// should be ok
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
        public void GenderMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr"; //should fail
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "FemaleA";// should not be ok
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
        public void GenderMid()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr"; //should pass
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Mal";// should be ok
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
        public void GenderExtremeMaximum()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "";
            Gender = Gender.PadRight(100, 'F'); //this should not pass
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
        public void AddressNoMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Awale";
            string Gender = "Male";
            string AddressNo = "";// this should not be ok
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
        public void AddressNoMinimum()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Male";
            string AddressNo = "1";// should be ok
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
        public void AddressNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Male";
            string AddressNo = "11";// should be ok
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
        public void AddressNoMaximum()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Maleee";
            string AddressNo = "111AAA";// should be ok, max of 6 char
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
        public void AddressNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr"; //should pass
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Male";
            string AddressNo = "111AB";// should be ok
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
        public void AddressNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Female";
            string AddressNo = "1234567";// should not be ok
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
        public void AddressNoMid()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr"; //should pass
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Male";
            string AddressNo = "123";// should be ok
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
        public void AddressNoExtremeMaximum()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Male";
            string AddressNo = "";
            AddressNo = AddressNo.PadRight(500, '1'); //this should not pass
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
        public void StreetMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Awale";
            string Gender = "Male";
            string AddressNo = "22";
            string Street = "";// this should not be ok
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
        public void StreetMinimum()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Male";
            string AddressNo = "35";
            string Street = "H";// should be ok
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
        public void StreetMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Male";
            string AddressNo = "22";
            string Street = "RD";// should be ok
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
        public void StreetMaximum()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Maleee";
            string AddressNo = "111";
            string Street = "";
            Street = Street.PadRight(50, 'B'); //this should pass
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
        public void StreetMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr"; //should pass
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Male";
            string AddressNo = "24A";
            string Street = "";// should be ok
            Street = Street.PadRight(49, 'B'); //this should pass
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
        public void StreetMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Female";
            string AddressNo = "123";
            string Street = "";// should not be ok
            Street = Street.PadRight(51, 'B'); //this should not pass
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
        public void StreetMid()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr"; //should pass
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Male";
            string AddressNo = "123";
            string Street = "";// should be ok
            Street = Street.PadRight(25, 'B'); //this should pass
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
        public void StreetExtremeMaximum()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Male";
            string AddressNo = "8";
            string Street = "";
            Street = Street.PadRight(800, 'B'); //this should not pass
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
        public void TownMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Awale";
            string Gender = "Male";
            string AddressNo = "22";
            string Street = "Leicester RD";
            string Town = "";// this should not be ok
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
        public void TownMinimum()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Male";
            string AddressNo = "35";
            string Street = "Homeland avenue";
            string Town = "L";// should be ok
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
        public void TownMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Male";
            string AddressNo = "22";
            string Street = "Hight Street";
            string Town = "LE";// should be ok
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
        public void TownMaximum()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Maleee";
            string AddressNo = "111";
            string Street = "Birth view";
            string Town = "";
            Town = Town.PadRight(50, 'B'); //this should pass
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
        public void TownMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr"; //should pass
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Male";
            string AddressNo = "24A";
            string Street = "Malabar Rd";// should be ok
            string Town = "";
            Town = Town.PadRight(49, 'B'); //this should pass
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
        public void TownMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Female";
            string AddressNo = "123";
            string Street = "Malabar Rd";
            string Town = "";// should not be ok
            Town = Town.PadRight(51, 'B'); //this should not be ok
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
        public void TownMid()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr"; //should pass
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Male";
            string AddressNo = "123";
            string Street = "Malabar Rd";
            string Town = "";
            Town = Town.PadRight(25, 'B'); //this should pass
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
        public void TownExtremeMaximum()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Male";
            string AddressNo = "8";
            string Street = "Malabar RD";
            string Town = "";
            Town = Town.PadRight(2400, 'B'); //this should not pass
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
        public void PostCodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Awale";
            string Gender = "Male";
            string AddressNo = "22";
            string Street = "Leicester RD";
            string Town = "London";
            string PostCode = "";// this should not be ok
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
        public void PostCodeMinimum()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Male";
            string AddressNo = "35";
            string Street = "Homeland avenue";
            string Town = "London";
            string PostCode = "L";// should be ok
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
        public void PostCodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Male";
            string AddressNo = "22";
            string Street = "Hight Street";
            string Town = "London";
            string PostCode = "LE";// should be ok
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
        public void PostCodeMaximum()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Maleee";
            string AddressNo = "111";
            string Street = "Birth view";
            string Town = "London";
            string PostCode = "LE4ABC";//should be on
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
        public void PostCodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr"; //should pass
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Male";
            string AddressNo = "24A";
            string Street = "Malabar Rd";
            string Town = "London";
            string PostCode = "LE4AB";// should be ok
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
        public void PostCodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Female";
            string AddressNo = "123";
            string Street = "Malabar Rd";
            string Town = "London";
            string PostCode = "LE4ABCD";//this should not be ok
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
        public void PostCodeMid()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr"; //should pass
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Male";
            string AddressNo = "123";
            string Street = "Malabar Rd";
            string Town = "London";
            string PostCode = "LE4";//this should pass
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
        public void PostCodeExtremeMaximum()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Male";
            string AddressNo = "8";
            string Street = "Malabar RD";
            string Town = "London";
            string PostCode = "";
            PostCode = PostCode.PadRight(502, 'B'); //this should not pass
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
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Awale";
            string Gender = "Male";
            string AddressNo = "22";
            string Street = "Leicester RD";
            string Town = "Kirbly";
            string PostCode = "LE4ABC";
            string Email = "";// this should not be ok
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
        public void EmailMinimum()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Male";
            string AddressNo = "35";
            string Street = "Homeland avenue";
            string Town = "London";
            string PostCode = "LE4ABC";
            string Email = "M";// should be ok
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
        public void EmalMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Male";
            string AddressNo = "22";
            string Street = "Hight Street";
            string Town = "Leicester";
            string PostCode = "LE4ABC";
            string Email = "Mo";// should be ok
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
        public void EmailMaximum()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Maleee";
            string AddressNo = "111";
            string Street = "Birth view";
            string Town = "London";
            string PostCode = "LE4ABC";
            string Email = "";
            Email = Email.PadRight(50, 'B'); //this should pass
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
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr"; //should pass
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Male";
            string AddressNo = "24A";
            string Street = "Malabar Rd";// should be ok
            string Town = "Leicester";
            string PostCode = "LE4ABC";
            string Email = "";
            Email = Email.PadRight(49, 'B'); //this should pass
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
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Female";
            string AddressNo = "123";
            string Street = "Malabar Rd";
            string Town = "Leicester";
            string PostCode = "LE4ABC";
            string Email = "";
            Email = Email.PadRight(51, 'B'); //this should not be ok
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
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr"; //should pass
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Male";
            string AddressNo = "123";
            string Street = "Malabar Rd";
            string Town = "London";
            string PostCode = "LE4ABC";
            string Email = "";
            Email = Email.PadRight(25, 'B'); //this should pass
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
        public void EmailExtremeMaximum()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Male";
            string AddressNo = "8";
            string Street = "Malabar RD";
            string Town = "London";
            string PostCode = "LE4ABC";
            string Email = "";
            Email = Email.PadRight(400, 'B'); //this should not pass
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
        public void DepartmentMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Awale";
            string Gender = "Male";
            string AddressNo = "22";
            string Street = "Leicester RD";
            string Town = "Kirbly";
            string PostCode = "LE4ABC";
            string Email = "Suley@dmu.ac.uk";
            string Department = "";// this should not be ok
            Int32 Salary = 23000;
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = StaffMember.Valid(Title, FirstName, LastName, Gender, AddressNo, Street, Town,
                PostCode, Email, Department, Salary, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DepartmentMinimum()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Male";
            string AddressNo = "35";
            string Street = "Homeland avenue";
            string Town = "London";
            string PostCode = "LE4ABC";
            string Email = "suley@dmu.ac.uk";
            string Department = "A";// should be ok
            Int32 Salary = 23000;
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = StaffMember.Valid(Title, FirstName, LastName, Gender, AddressNo, Street, Town,
               PostCode, Email, Department, Salary, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DepartmentMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Male";
            string AddressNo = "22";
            string Street = "Hight Street";
            string Town = "Leicester";
            string PostCode = "LE4ABC";
            string Email = "suley@dmu.ac.uk";
            string Department = "Ac";// should be ok
            Int32 Salary = 23000;
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = StaffMember.Valid(Title, FirstName, LastName, Gender, AddressNo, Street, Town,
               PostCode, Email, Department, Salary, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DepartmentMaximum()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Maleee";
            string AddressNo = "111";
            string Street = "Birth view";
            string Town = "London";
            string PostCode = "LE4ABC";
            string Email = "suley@dmu.ac.uk";
            string Department = "";
            Department = Department.PadRight(50, 'B'); //this should pass
            Int32 Salary = 23000;
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = StaffMember.Valid(Title, FirstName, LastName, Gender, AddressNo, Street, Town,
               PostCode, Email, Department, Salary, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DepartmentMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr"; //should pass
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Male";
            string AddressNo = "24A";
            string Street = "Malabar Rd";// should be ok
            string Town = "Leicester";
            string PostCode = "LE4ABC";
            string Email = "suley@dmu.ac.uk";
            string Department = "";
            Department = Department.PadRight(49, 'B'); //this should pass
            Int32 Salary = 23000;
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = StaffMember.Valid(Title, FirstName, LastName, Gender, AddressNo, Street, Town,
               PostCode, Email, Department, Salary, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void DepartmentMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Female";
            string AddressNo = "123";
            string Street = "Malabar Rd";
            string Town = "Leicester";
            string PostCode = "LE4ABC";
            string Email = "suley@dmu.ac.uk";
            string Department = "";
            Department = Department.PadRight(51, 'B'); //this should not be ok
            Int32 Salary = 23000;
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = StaffMember.Valid(Title, FirstName, LastName, Gender, AddressNo, Street, Town,
               PostCode, Email, Department, Salary, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DepartmentMid()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr"; //should pass
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Male";
            string AddressNo = "123";
            string Street = "Malabar Rd";
            string Town = "London";
            string PostCode = "LE4ABC";
            string Email = "suley@dmu.ac.uk";
            string Department = "Accounts";
            Department = Department.PadRight(25, 'B'); //this should pass
            Int32 Salary = 23000;
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = StaffMember.Valid(Title, FirstName, LastName, Gender, AddressNo, Street, Town,
               PostCode, Email, Department, Salary, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void DepartmentExtremeMaximum()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Smith";
            string Gender = "Male";
            string AddressNo = "8";
            string Street = "Malabar RD";
            string Town = "London";
            string PostCode = "LE4ABC";
            string Email = "suley@dmu.ac.uk";
            string Department = "Accounts";
            Department = Department.PadRight(1000, 'B'); //this should not pass
            Int32 Salary = 23000;
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = StaffMember.Valid(Title, FirstName, LastName, Gender, AddressNo, Street, Town,
               PostCode, Email, Department, Salary, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Awale";
            string Gender = "Male";
            string AddressNo = "22";
            string Street = "Leicester RD";
            string Town = "Kirbly";
            string PostCode = "LE4ABC";
            string Email = "Suley@dmu.ac.uk";
            string Department = "Warehouse";
            Int32 Salary = 23000;
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            OK = StaffMember.Valid(Title, FirstName, LastName, Gender, AddressNo, Street, Town,
                PostCode, Email, Department, Salary, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Awale";
            string Gender = "Male";
            string AddressNo = "22";
            string Street = "Leicester RD";
            string Town = "Kirbly";
            string PostCode = "LE4ABC";
            string Email = "Suley@dmu.ac.uk";
            string Department = "Warehouse";
            Int32 Salary = 23000;
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            OK = StaffMember.Valid(Title, FirstName, LastName, Gender, AddressNo, Street, Town,
                PostCode, Email, Department, Salary, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Awale";
            string Gender = "Male";
            string AddressNo = "22";
            string Street = "Leicester RD";
            string Town = "Kirbly";
            string PostCode = "LE4ABC";
            string Email = "Suley@dmu.ac.uk";
            string Department = "Warehouse";
            Int32 Salary = 23000;
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            OK = StaffMember.Valid(Title, FirstName, LastName, Gender, AddressNo, Street, Town,
                PostCode, Email, Department, Salary, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DateAddedExtremeDate()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Awale";
            string Gender = "Male";
            string AddressNo = "22";
            string Street = "Leicester RD";
            string Town = "Kirbly";
            string PostCode = "LE4ABC";
            string Email = "Suley@dmu.ac.uk";
            string Department = "Warehouse";
            Int32 Salary = 23000;
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(999);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            OK = StaffMember.Valid(Title, FirstName, LastName, Gender, AddressNo, Street, Town,
                PostCode, Email, Department, Salary, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DateAddedInvalidDate()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            // Int32 StaffId = 123;
            string Title = "Mr";
            string FirstName = "Adam";
            string LastName = "Awale";
            string Gender = "Male";
            string AddressNo = "22";
            string Street = "Leicester RD";
            string Town = "Kirbly";
            string PostCode = "LE4ABC";
            string Email = "Suley@dmu.ac.uk";
            string Department = "Warehouse";
            Int32 Salary = 23000;
            string DateAdded = " first octobar two thousand five";
            //invoke the method
            OK = StaffMember.Valid(Title, FirstName, LastName, Gender, AddressNo, Street, Town,
                PostCode, Email, Department, Salary, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
    }
}
