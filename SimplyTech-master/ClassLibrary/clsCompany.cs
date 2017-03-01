using System;
using ClassLibrary;

namespace ClassLibrary
{
    public class clsCompany
    {
        public string CompanyName { get; set; }
        public int CompanyNo { get; set; }
        public int ContactNo { get; set; }
        public string Email { get; set; }

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
        public bool Find(string Address)
        {
            return true;
        }
        public class tstCompany
        {
            private string Address;
        }
    }
}