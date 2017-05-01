using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

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
            string TestData = "Borislav";
            ACompany.CompanyName = TestData;
            Assert.AreEqual(ACompany.CompanyName, TestData);
        }
        [TestMethod]
        public void CompanyNoOK()
        {
            clsCompany ACompany = new clsCompany();
            string TestData = "33";
            ACompany.CompanyNo = TestData;
            Assert.AreEqual(ACompany.CompanyNo, TestData);
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
            string TestData = "0744121212";
            ACompany.ContactNo = TestData;
            Assert.AreEqual(ACompany.ContactNo, TestData);

        }



        //[TestMethod]
        //public void TestAddressFound()
        //{
        //    clsCompany ACompany = new clsCompany();
        //    Boolean Found = false;
        //    Boolean OK = true;
        //    string Address = "33";
        //    Found = ACompany.Find(Address);
        //    if (ACompany.Address != "33")
        //    {
        //        OK = false;
        //    }
        //    Assert.IsTrue(OK);
        //}

        public bool Find(int Address)
        {
            Address = 33;
            return true;
        }

    }


}
