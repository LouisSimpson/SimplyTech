using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibrary
{
    [TestClass]
    public class tstCompany
    {

        [TestMethod]
        public void InstanceOK()
        {
            clsCompany ACompany = new clsCompany();
            Assert.IsNotNull(ACompany);
        }

        [TestMethod]
        public void CompanyNameOK()
        {
            clsCompany ACompany = new clsCompany();
            string TestData = "DMU";
            ACompany.CompanyName = TestData;
            Assert.AreEqual(ACompany.CompanyName, TestData);
        }


        [TestMethod]
        public void AddressOK()
        {
            clsCompany ACompany = new clsCompany();
            string TestData = "85 street";
            ACompany.Address = TestData;
            Assert.AreEqual(ACompany.Address, TestData);
        }

        [TestMethod]
        public void EmailOK()
        {
            clsCompany ACompany = new clsCompany();
            string TestData = "abcdef@dmu.ac.uk";
            ACompany.Email = TestData;
            Assert.AreEqual(ACompany.Email, TestData);
        }

        [TestMethod]
        public void ContactNoOK()
        {
            clsCompany ACompany = new clsCompany();
            int TestData = 0744121212;
            ACompany.ContactNo = TestData;
            Assert.AreEqual(ACompany.ContactNo, TestData);

        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsCompany ACompany = new clsCompany();
            Boolean Found = false;
            int ContactNo = 33;
            Found = ACompany.Find(ContactNo);
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestContactNoFound()
        {
            clsCompany ACompany = new clsCompany();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ContactNo = 33;
            Found = ACompany.Find(ContactNo);
            if (ACompany.ContactNo != 33)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }


        [TestMethod]
        public void TestEmailFound()
        {
            clsCompany ACompany = new clsCompany();
            Boolean Found = false;
            Boolean OK = true;
            string Email = "abcdef@dmu.ac.uk";
            Found = ACompany.Find(33);
            if (ACompany.Email == "abcdef@dmu.ac.uk")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestAddressFound()
        {
            clsCompany ACompany = new clsCompany();
            Boolean Found = false;
            Boolean OK = true;
            //string mAddress = "85 Street";
            Found = ACompany.Find(33);
            if (ACompany.Address == "85 Street")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestCompanyNameFound()
        {
            clsCompany ACompany = new clsCompany();
            Boolean Found = false;
            Boolean OK = true;
            //string CompanyName = "DMU";
            Found = ACompany.Find(33);
            if (ACompany.CompanyName == "DMU")
            {
                OK = true;
            }
            Assert.IsTrue(OK);

        }


    }

}

