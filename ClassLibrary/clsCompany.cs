using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibrary;
namespace ClassLibrary
{
    public class clsCompany
    {

        private string mAddress;
        public string Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }


        private string mCompanyName;
        public string CompanyNo
        {
            get
            {
                return mCompanyName;
            }
            set
            {
                mCompanyName = value;
            }
        }



        private string mContactNo;
        public string ContactNo
        {
            get
            {
                return mContactNo;
            }
            set
            {
                mContactNo = value;
            }
        }

        private string mEmail;
        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }

        public bool Active { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyName { get; set; }

        public bool Find()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@contactNo", ContactNo);
            DB.Execute("sproc_tblCompany_FilterBycontactNo");
            if (DB.Count == 1)
            {
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mCompanyName = Convert.ToString(DB.DataTable.Rows[0]["CompanyName"]);
                mContactNo = Convert.ToString(DB.DataTable.Rows[0]["ContactNo"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);

                return true;
            }
            else
            {
                return false;
            }
        }

       // public bool Find (string ContactNo)
       // {
         //   
            
       // }

        public bool Valid(string companyName, string address, string email, string contactNo)
        {
            Boolean OK = true;
            if (address.Length == 0)
            {
                OK = false;
            }

            if (address.Length > 101)
            {
                OK = false;
            }
            if (address.Length < 1)
             {
                 OK = false;
             }

            if (email.Length == 0)
            {
                OK = false;
            }
            if (email.Length > 51)
            {
                OK = false;
            }

            if (companyName.Length == 0)
            {
                OK = false;
            }
            if (companyName.Length > 31)
            {
                OK = false;
            }

            if (contactNo.Length == 0)
            {
                OK = false;
            }
            if (contactNo.Length > 16)
            {
                OK = false;
            }


            return OK;
        }
        
    }
    }


