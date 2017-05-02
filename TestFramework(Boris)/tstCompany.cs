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
            ACompany.ContactNo = TestData;
            Assert.AreEqual(ACompany.ContactNo, TestData);
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

        [TestMethod]
        public void FindMethodOK()
        {
            clsCompany ACompany = new clsCompany();
            Boolean Found = false;
           string ContactNo = "0744121212";
           Found = ACompany.Find();
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestContactNoFound()
        {
            clsCompany ACompany = new clsCompany();
            Boolean Found = false;
            Boolean OK = true;
           // string ContactNo = "0744121212";
            Found = ACompany.Find();
            if (ACompany.ContactNo == "0744121212")
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
            Found = ACompany.Find();
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
            Found = ACompany.Find();
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
            Found = ACompany.Find();
            if (ACompany.ContactNo == "0744121212")
            {
                OK = true;
            }
            Assert.IsTrue(OK);

        }




        [TestMethod]
        public void ValidMethodOK()
       {
            clsCompany ACompany = new clsCompany();
            Boolean OK = false;
            Boolean Found = false;
            Found = ACompany.Find();

            string CompanyName = "DMU";
            string Address = "85 Street";
            string Email = "abcdef@dmu.ac.uk";
            string ContactNo = "0744121212";

            OK = ACompany.Valid(CompanyName,Address,Email,ContactNo);
            
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            clsCompany ACompany = new clsCompany();
            Boolean OK = false;

            string Address = "";
            string CompanyName = "DMU";
            string Email = "abcdef@dmu.ac.uk";
            string ContactNo = "0744121212";

            OK = ACompany.Valid(CompanyName, Address, Email, ContactNo);

            Assert.IsFalse(OK);

        }

        [TestMethod]
        public void AddressMin()
        {
            clsCompany ACompany = new clsCompany();
            Boolean OK = false;

            string Address = "85 street";
            string CompanyName = "DMU";
            string Email = "abcdef@dmu.ac.uk";
            string ContactNo = "0744121212";

            OK = ACompany.Valid(CompanyName, Address, Email, ContactNo);

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            clsCompany ACompany = new clsCompany();
            Boolean OK = false;

            string Address = "85 streeet";
            string CompanyName = "DMU";
            string Email = "abcdef@dmu.ac.uk";
            string ContactNo = "33";

            OK = ACompany.Valid(CompanyName, Address, Email, ContactNo);

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void AddressMaxLessOne()
        {
            clsCompany ACompany = new clsCompany();
            Boolean OK = false;

            string Address = "85 streeeet";
            string CompanyName = "DMU";
            string Email = "abcdef@dmu.ac.uk";
            string ContactNo = "0744121212";

            OK = ACompany.Valid(CompanyName, Address, Email, ContactNo);

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void AddressMax()
        {
            clsCompany ACompany = new clsCompany();
            Boolean OK = false;

            string Address = "85 streeeeet";
            string CompanyName = "DMU";
            string Email = "abcdef@dmu.ac.uk";
            string ContactNo = "0744121212";

            OK = ACompany.Valid(CompanyName, Address, Email, ContactNo);

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void AddressMid()
        {
            clsCompany ACompany = new clsCompany();
            Boolean OK = false;

            string Address = "85 streett";
            string CompanyName = "DMU";
            string Email = "abcdef@dmu.ac.uk";
            string ContactNo = "0744121212";

            OK = ACompany.Valid(CompanyName, Address, Email, ContactNo);

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            clsCompany ACompany = new clsCompany();
            Boolean OK = false;

            string Address = "85 street";
            string CompanyName = "DMU";
            string Email = "abcdef@dmu.ac.uk";
            string ContactNo = "0744121212";

            OK = ACompany.Valid(CompanyName, Address, Email, ContactNo);

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void AddressExtremeMax()
        {
            clsCompany ACompany = new clsCompany();
            Boolean OK = false;

            string Address = "";
            Address = Address.PadRight(250, 'a');
            string CompanyName = "DMU";
            string Email = "abcdef@dmu.ac.uk";
            string ContactNo = "0744121212";

            OK = ACompany.Valid(CompanyName, Address, Email, ContactNo);

            Assert.IsFalse(OK);

        }



        [TestMethod]
        public void EmailMinLessOne()
        {
            clsCompany ACompany = new clsCompany();
            Boolean OK = false;

            string Address = "85 Street";
            string CompanyName = "DMU";
            string Email = "";
            string ContactNo = "0744121212";

            OK = ACompany.Valid(CompanyName, Address, Email, ContactNo);

            Assert.IsFalse(OK);

        }

        [TestMethod]
        public void EmailMin()
        {
            clsCompany ACompany = new clsCompany();
            Boolean OK = false;

            string Address = "85 street";
            string CompanyName = "DMU";
            string Email = "abcdef@dmu.ac.uk";
            string ContactNo = "0744121212";

            OK = ACompany.Valid(CompanyName, Address, Email, ContactNo);

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            clsCompany ACompany = new clsCompany();
            Boolean OK = false;

            string Address = "85 streeet";
            string CompanyName = "DMU";
            string Email = "abcdef@dmu.ac.uk";
            string ContactNo = "0744121212";

            OK = ACompany.Valid(CompanyName, Address, Email, ContactNo);

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            clsCompany ACompany = new clsCompany();
            Boolean OK = false;

            string Address = "85 streeeet";
            string CompanyName = "DMU";
            string Email = "abcdef@dmu.ac.uk";
            string ContactNo = "0744121212";

            OK = ACompany.Valid(CompanyName, Address, Email, ContactNo);

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void EmailMax()
        {
            clsCompany ACompany = new clsCompany();
            Boolean OK = false;

            string Address = "85 streeeeet";
            string CompanyName = "DMU";
            string Email = "abcdef@dmu.ac.uk";
            string ContactNo = "33";

            OK = ACompany.Valid(CompanyName, Address, Email, ContactNo);

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void EmailMid()
        {
            clsCompany ACompany = new clsCompany();
            Boolean OK = false;

            string Address = "85 streett";
            string CompanyName = "DMU";
            string Email = "abcdef@dmu.ac.uk";
            string ContactNo = "33";

            OK = ACompany.Valid(CompanyName, Address, Email, ContactNo);

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            clsCompany ACompany = new clsCompany();
            Boolean OK = false;

            string Address = "85 street";
            string CompanyName = "DMU";
            string Email = "abcdef@dmu.ac.uk";
            string ContactNo = "33";

            OK = ACompany.Valid(CompanyName, Address, Email, ContactNo);

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            clsCompany ACompany = new clsCompany();
            Boolean OK = false;

            string Address = "85 Street";
            
            string CompanyName = "DMU";
            string Email = "";
            Email = Email.PadRight(100, 'a');
            string ContactNo = "33";

            OK = ACompany.Valid(CompanyName, Address, Email, ContactNo);

            Assert.IsFalse(OK);

        }

        [TestMethod]
        public void CompanyNameMinLessOne()
        {
            clsCompany ACompany = new clsCompany();
            Boolean OK = false;

            string Address = "85 Street";
            string CompanyName = "";
            string Email = "abcdef@dmu.ac.uk";
            string ContactNo = "33";

            OK = ACompany.Valid(CompanyName, Address, Email, ContactNo);

            Assert.IsFalse(OK);

        }

        [TestMethod]
        public void CompanyNameMin()
        {
            clsCompany ACompany = new clsCompany();
            Boolean OK = false;

            string Address = "85 street";
            string CompanyName = "DMU";
            string Email = "abcdef@dmu.ac.uk";
            string ContactNo = "33";

            OK = ACompany.Valid(CompanyName, Address, Email, ContactNo);

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void CompanyNameMinPlusOne()
        {
            clsCompany ACompany = new clsCompany();
            Boolean OK = false;

            string Address = "85 streeet";
            string CompanyName = "DMU";
            string Email = "abcdef@dmu.ac.uk";
            string ContactNo = "33";

            OK = ACompany.Valid(CompanyName, Address, Email, ContactNo);

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void CompanyNameMaxLessOne()
        {
            clsCompany ACompany = new clsCompany();
            Boolean OK = false;

            string Address = "85 streeeet";
            string CompanyName = "DMU";
            string Email = "abcdef@dmu.ac.uk";
            string ContactNo = "33";

            OK = ACompany.Valid(CompanyName, Address, Email, ContactNo);

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void CompanyNameMax()
        {
            clsCompany ACompany = new clsCompany();
            Boolean OK = false;

            string Address = "85 streeeeet";
            string CompanyName = "DMU";
            string Email = "abcdef@dmu.ac.uk";
            string ContactNo = "33";

            OK = ACompany.Valid(CompanyName, Address, Email, ContactNo);

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void CompanyNameMid()
        {
            clsCompany ACompany = new clsCompany();
            Boolean OK = false;

            string Address = "85 streett";
            string CompanyName = "DMU";
            string Email = "abcdef@dmu.ac.uk";
            string ContactNo = "33";

            OK = ACompany.Valid(CompanyName, Address, Email, ContactNo);

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void CompanyNameMaxPlusOne()
        {
            clsCompany ACompany = new clsCompany();
            Boolean OK = false;

            string Address = "85 street";
            string CompanyName = "DMU";
            string Email = "abcdef@dmu.ac.uk";
            string ContactNo = "33";

            OK = ACompany.Valid(CompanyName, Address, Email, ContactNo);

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void CompanyNameExtremeMax()
        {
            clsCompany ACompany = new clsCompany();
            Boolean OK = false;

            string Address = "85 Street";

            string CompanyName = "";
            CompanyName = CompanyName.PadRight(100, 'a');
            string Email = "abcdef@dmu.ac.uk";

            string ContactNo = "33";

            OK = ACompany.Valid(CompanyName, Address, Email, ContactNo);

            Assert.IsFalse(OK);

        }

        [TestMethod]
        public void ContactNoMinLessOne()
        {
            clsCompany ACompany = new clsCompany();
            Boolean OK = false;

            string Address = "85 Street";
            string CompanyName = "DMU";
            string Email = "abcdef@dmu.ac.uk";
            string ContactNo = "";

            OK = ACompany.Valid(CompanyName, Address, Email, ContactNo);

            Assert.IsFalse(OK);

        }

        [TestMethod]
        public void ContactNoMin()
        {
            clsCompany ACompany = new clsCompany();
            Boolean OK = false;

            string Address = "85 street";
            string CompanyName = "DMU";
            string Email = "abcdef@dmu.ac.uk";
            string ContactNo = "33";

            OK = ACompany.Valid(CompanyName, Address, Email, ContactNo);

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void ContactNoMinPlusOne()
        {
            clsCompany ACompany = new clsCompany();
            Boolean OK = false;

            string Address = "85 streeet";
            string CompanyName = "DMU";
            string Email = "abcdef@dmu.ac.uk";
            string ContactNo = "33";

            OK = ACompany.Valid(CompanyName, Address, Email, ContactNo);

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void ContactNoMaxLessOne()
        {
            clsCompany ACompany = new clsCompany();
            Boolean OK = false;

            string Address = "85 streeeet";
            string CompanyName = "DMU";
            string Email = "abcdef@dmu.ac.uk";
            string ContactNo = "33";

            OK = ACompany.Valid(CompanyName, Address, Email, ContactNo);

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void ContactNoMax()
        {
            clsCompany ACompany = new clsCompany();
            Boolean OK = false;

            string Address = "85 streeeeet";
            string CompanyName = "DMU";
            string Email = "abcdef@dmu.ac.uk";
            string ContactNo = "33";

            OK = ACompany.Valid(CompanyName, Address, Email, ContactNo);

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void ContactNoMid()
        {
            clsCompany ACompany = new clsCompany();
            Boolean OK = false;

            string Address = "85 streett";
            string CompanyName = "DMU";
            string Email = "abcdef@dmu.ac.uk";
            string ContactNo = "33";

            OK = ACompany.Valid(CompanyName, Address, Email, ContactNo);

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void ContactNoMaxPlusOne()
        {
            clsCompany ACompany = new clsCompany();
            Boolean OK = false;

            string Address = "85 street";
            string CompanyName = "DMU";
            string Email = "abcdef@dmu.ac.uk";
            string ContactNo = "";

            OK = ACompany.Valid(CompanyName, Address, Email, ContactNo);

            Assert.IsFalse(OK);

        }

        [TestMethod]
        public void ContactNoExtremeMax()
        {
            clsCompany ACompany = new clsCompany();
            Boolean OK = false;

            string Address = "85 Street";

            string CompanyName = "DMU";
           
            string Email = "abcdef@dmu.ac.uk";

            string ContactNo = "33";
            ContactNo = ContactNo.PadRight(30, 'a');
            OK = ACompany.Valid(CompanyName, Address, Email, ContactNo);

            Assert.IsFalse(OK);

        }

    }

}
      
