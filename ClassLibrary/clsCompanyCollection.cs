using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCompanyCollection
    {
        public object ThisCompany { get; set; }
        public int Count { get; set; }
        public List<clsCompany> CompanyList { get; set; }
        public object mThisCompany { get; set; }

                         
           public class clsCompanyCollection1

        {
            List<clsCompany> mCompanyList = new List<clsCompany>();
            clsCompany mThisCompany = new clsCompany();
            private clsCompany mThisAddress;

            public clsCompany ThisCompany
            {
                get
                {
                    return mThisCompany;
                }
                set
                {
                    mThisAddress = value;
                }

           }
           
            
            public int Add()
            {
                clsDataConnection DB = new clsDataConnection();
                DB.AddParameter("@CompanyName", mThisAddress.CompanyName);
                DB.AddParameter("@Address", mThisAddress.CompanyAddress);
                DB.AddParameter("@Email", mThisAddress.Email);
                DB.AddParameter("@ContactNo", mThisAddress.ContactNo);
                return DB.Execute("sproc_tblCompany_Insert");
            }

            public void Delete()
            {
                clsDataConnection DB = new clsDataConnection();
                DB.AddParameter("@ContactNo", mThisCompany.ContactNo);
                DB.Execute("sproc_tblCompany_Delete");
            }

            public void Update()
            {
                clsDataConnection DB = new clsDataConnection();
                DB.AddParameter("@CompanyName", mThisAddress.CompanyName);
                DB.AddParameter("@Address", mThisAddress.CompanyAddress);
                DB.AddParameter("@Email", mThisAddress.Email);
                DB.AddParameter("@ContactNo", mThisAddress.ContactNo);
                DB.Execute("sproc_tblCompany_Update");
            }
            public clsCompanyCollection1()
            {
                Int32 Index = 0;
                Int32 RecordCount = 0;
                clsDataConnection DB = new clsDataConnection();
                DB.Execute("sproc_tblCompany_SelectAll");
                RecordCount = DB.Count;
                while (Index < RecordCount)
                {
                    clsCompany mCompany = new clsCompany();
                    mCompany.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                    mCompany.CompanyName = Convert.ToString(DB.DataTable.Rows[Index]["DMU"]);
                    mCompany.CompanyAddress = Convert.ToString(DB.DataTable.Rows[Index]["85 street"]);
                    mCompany.Email = Convert.ToString(DB.DataTable.Rows[Index]["abcdef@dmu.ac.uk"]);
                    mCompany.ContactNo = Convert.ToString(DB.DataTable.Rows[Index]["0744121212"]);
                    mCompanyList.Add(mCompany);
                    Index++;

                }
            }
             //clsCompany SomeCompany = new clsCompany();
           // SomeCompany.Find(3);


             //clsCompanyCollection AllCompanies = new clsCompanyCollection();
           // AllCompanies.ThisCompany.Find();
            //  AllCompanies.Delete();
            
           //  clsCompanyCollection AllCompanies = new clsCompanyCollection ();
            //AllCompanies.ThisCompany.Find(3);
            //AllCompanies.ThisCompany.CompanyName = "CEX";
            // AllCompanies.Update();

            // clsCompanyCollection AllCompanies = new clsCompanyCollection();
            //AllCompanies.ThisCompany.Active = true;
            // AllCompanies.ThisCompany.CompanyName = "CEX";
            // AllCompanies.ThisCompany.ContactNo = "0116";
            //AllCompanies.ThisCompany.Email = "cex@gmail.com";
            // AllCompanies.ThisCompany.CompanyAddress = "77 street";
            // AllAddresses.Add();


            public List<clsCompany> CompanyList
            {
                get
                {
                    return mCompanyList;
                }
                set
                {
                    mCompanyList = value;
                }
            }

            public int Count
            {
                get
                {
                    return mCompanyList.Count;
                }
                set
                {
                    //
                }


            }

            

            }

        public string Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
    }


  

