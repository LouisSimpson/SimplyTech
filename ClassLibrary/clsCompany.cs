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
        public string CompanyName
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



        private int mContactNo;
        public int ContactNo
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

        public bool Find(int contactNo)
        {
            mContactNo = 33;
            return true;
        }
    }
}
