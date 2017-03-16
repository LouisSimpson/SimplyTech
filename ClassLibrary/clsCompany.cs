using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibrary;
namespace ClassLibrary
{
    public class clsCompany
    {

        public string Address { get; set; }
        public string CompanyName { get; set; }
        public int CompanyNo { get; set; }

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

        public string Email { get; set; }

        public bool Find(int contactNo)
        {
            mContactNo = 33;
            return true;
        }
    }
}
