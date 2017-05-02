using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]
    public class tstCompanyCollection
    {
        public object AllCompanies { get; set; }
        public object TestList { get; set; }
        public object CompanyList { get; set; }
        public object ThisCompany { get; set; }
       // public object AllAddresses { get;  set; }

        [TestMethod]
        public void TestMethod1()
        {

        }
        [TestMethod]
        public void InstanceOK()
        {
            clsCompanyCollection AllCompanies = new clsCompanyCollection();
            Assert.IsNotNull(AllCompanies);
        }

        [TestMethod]
        public void CompanyListOK()
        {
            clsCompanyCollection AllCompanies = new clsCompanyCollection();
            List<clsCompany> TestList = new List<clsCompany>();
            clsCompany TestItem = new clsCompany();
            TestItem.Active = true;
            TestItem.CompanyName = "DMU";
            TestItem.CompanyAddress = "85 street";
            TestItem.Email = "abcdef@dmu.ac.uk";
            TestItem.ContactNo = "33";
            TestList.Add(TestItem);
            AllCompanies.CompanyList = TestList;
            Assert.AreEqual(AllCompanies.CompanyList, GetTestList(TestList));

        }

        private static List<clsCompany> GetTestList(List<clsCompany> TestList)
        {
            return TestList;
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            clsCompanyCollection AllCompanies = new clsCompanyCollection();
            Int32 SomeCount = 33;
            AllCompanies.Count = SomeCount;
            Assert.AreEqual(AllCompanies.Count, SomeCount);
        }

        [TestMethod]
        public void ThisCompanyPropertyOK()
        {
            clsCompanyCollection AllCompanies = new clsCompanyCollection();
            clsCompany TestCompany = new clsCompany();
            TestCompany.Active = true;
            TestCompany.CompanyName = "DMU";
            TestCompany.CompanyAddress = "85 street";
            TestCompany.Email = "abcdef@dmu.ac.uk";
            TestCompany.ContactNo = "33";
            AllCompanies.ThisCompany = TestCompany;
            Assert.AreEqual(AllCompanies.ThisCompany,TestCompany);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsCompanyCollection AllCompanies = new clsCompanyCollection();
            List<clsCompany> TestList = new List<clsCompany>();
            clsCompany TestItem = new clsCompany();
            TestItem.Active = true;
            TestItem.CompanyName = "DMU";
            TestItem.CompanyAddress = "85 street";
            TestItem.Email = "abcdef@dmu.ac.uk";
            TestItem.ContactNo = "33";
            TestList.Add(TestItem);
            AllCompanies.CompanyList = TestList;
            Assert.AreEqual(AllCompanies.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoRecordsPresent()
       {
            clsCompanyCollection AllCompanies = new clsCompanyCollection();
            Assert.AreEqual(AllCompanies.Count, 2);
        }
       

        [TestMethod]
        public void AddMethodOK()
        {
            clsCompanyCollection AllCompanies = new clsCompanyCollection();
            clsCompany TestItem = new clsCompany();
            string PrimaryKey = "0744121212";
            TestItem.Active = true;
            TestItem.CompanyName = "DMU";
            TestItem.CompanyAddress = "85 street";
            TestItem.Email = "abcdef@dmu.ac.uk";
            TestItem.ContactNo = "33";
            AllCompanies.ThisCompany = TestItem;
            PrimaryKey = AllCompanies.Add();
            TestItem.ContactNo = PrimaryKey;
            AllCompanies.ThisCompany.Find(PrimaryKey);
            Assert.AreEqual(AllCompanies.ThisCompany, TestItem);
        
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsCompanyCollection AllCompanies = new clsCompanyCollection();
            clsCompany TestItem = new clsCompany();
            string PrimaryKey = "0744121212";
            TestItem.Active = true;
            TestItem.CompanyName = "DMU";
            TestItem.CompanyAddress = "85 street";
            TestItem.Email = "abcdef@dmu.ac.uk";
            TestItem.ContactNo = "33";
            AllCompanies.ThisCompany = TestItem;
            PrimaryKey = AllCompanies.Add();
            TestItem.ContactNo = PrimaryKey;
            AllCompanies.ThisCompany.Find(PrimaryKey);
            AllCompanies.Delete();
            Boolean Found = AllCompanies.ThisCompany.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsCompanyCollection AllCompanies = new clsCompanyCollection();
            clsCompany TestItem = new clsCompany();
            string PrimaryKey = "0744121212";
            TestItem.Active = true;
            TestItem.CompanyName = "DMU";
            TestItem.CompanyAddress = "85 street";
            TestItem.Email = "abcdef@dmu.ac.uk";
            TestItem.ContactNo = "0744121212";
            AllCompanies.ThisCompany = TestItem;
            PrimaryKey = AllCompanies.Add();
            TestItem.ContactNo = PrimaryKey;
            TestItem.Active = false ;
            TestItem.CompanyName = "CEX";
            TestItem.CompanyAddress = "111 street";
            TestItem.Email = "CEX@gmail.com";
            TestItem.ContactNo = "33";
            AllCompanies.ThisCompany = TestItem;
            AllCompanies.Update();
            AllCompanies.ThisCompany.Find(PrimaryKey);
            Assert.AreEqual(AllCompanies.ThisCompany, TestItem);

        }
    }
}
  
