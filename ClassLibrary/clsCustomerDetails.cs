using System;

namespace ClassLibrary
{
    public class clsCustomerDetails
    {
        private Int32 mCustomerId;
        private string mcardnumber;
        private string mcityname;
        private string maddressName;
        private string memailaddress;
        private DateTime mexpirydate;
        private string mfirstname;
        private string mlastname;
        private string mmobilenumber;
        private string mpostcode;
        private string msecuritycode;
        private string mstreetname;
        private string musername;
        private string mpassword;

        public string cardnumber
        {

            get
            {
                return mcardnumber;
            }
            set
            {
                mcardnumber = value;
            }
        }

        public string cityname
        {
            get
            {
                return mcityname;
            }

            set
            {
                mcityname = value;
            }
        }

        public string addressName
        {
            get
            {
                return maddressName;
            }
            set
            {
                maddressName = value;
            }
        }

        public string emailaddress
        {
            get
            {
                return memailaddress;
            }
            set
            {
                memailaddress = value;
            }
        }
        public DateTime expirydate
        {
            get
            {
                return mexpirydate;
            }
            set
            {
                mexpirydate = value;
            }
        }
        public string firstname
        {
            get
            {
                return mfirstname;
            }
            set
            {
                mfirstname = value;
            }
        }
        public string lastname
        {
            get
            {
                return mlastname;
            }
            set
            {
                mlastname = value;
            }
        }
        public string mobilenumber
        {
            get
            {
                return mmobilenumber;
            }
            set
            {
                mmobilenumber = value;
            }
        }
        public string postcode
        {
            get
            {
                return mpostcode;
            }
            set
            {
                mpostcode = value;
            }
        }
        public string secruitycode
        {
            get
            {
                return msecuritycode;
            }
            set
            {
                msecuritycode = value;
            }
        }
        public string streetname
        {
            get
            {
                return mstreetname;
            }
            set
            {
                mstreetname = value;
            }
        }
        public string username
        {
            get
            {
                return musername;
            }
            set
            {
                musername = value;
            }
        }
        public string password
        {
            get
            {
                return mpassword;
            }
            set
            {
                mpassword = value;
            }
        }

        public Int32 customerid
        {
            get
            {
                return mCustomerId;
            }
            set
            {
                mCustomerId = value;
            }
        }

        public bool Valid(int CustomerId, string addressCityName, string addressName, string addressPostCode, string addressStreetName, string cardNumber, string emailAddress, DateTime expiryDate, string firstName, string lastName, string mobileNumber, string securityCode, string userName, string password)
        {
            //declare a variable to pass as return
            bool OK = true;

            //customer id validation
            if (CustomerId < 4)
            {
                OK = false;
            }
            else if (CustomerId > 8)
            {
                OK = false;
            }
            //end of customer id validation 

            //city name validation 
            if (addressCityName.Length < 3)
            {
                OK = false;
            }
            else if (addressCityName.Length > 50)
            {
                OK = false;
            }
            //end of city name

            //address name validation 
            if (addressName.Length < 1)
            {
                OK = false;
            }
            else if (addressName.Length > 30)
            {
                OK = false;
            }
            //end of address name validation 

            //Address PostCode validation
            if (addressPostCode.Length < 4)
            {
                OK = false;
            }
            else if (addressPostCode.Length > 8)
            {
                OK = false;
            }
            //end of address postcode validation 

            //Address Street Name Validation
            if (addressStreetName.Length < 5)
            {
                OK = false;
            }
            else if (addressStreetName.Length > 30)
            {
                OK = false;
            }
            //end of address street name validation 

            // card number validation 
            if (cardNumber.Length != 16)
            {
                OK = false;
            }
            //end of card number validation 

            // email address validation
            if (emailAddress.Length < 6)
            {
                OK = false;
            }
            else if (emailAddress.Length > 30)
            {
                OK = false;
            }
            //end of email address validation 

            //First Name validation 
            if (firstName.Length < 2)
            {
                OK = false;
            }
            else if (firstName.Length > 15)
            {
                OK = false;
            }
            //end of first name validation 

            //Last Name validation 
            if (lastName.Length < 2)
            {
                OK = false;
            }
            else if (lastName.Length > 15)
            {
                OK = false;
            }
            //end of last name validation 


            // mobile number validation 
            if (mobileNumber.Length != 11)
            {
                OK = false;
            }
            //end of mobile number validation

            //Security Code number validation 
            if (securityCode.Length != 3)
            {
                OK = false;
            }
            //end of Security Code number validation 

            //user name validation
            if (userName.Length < 3)
            {
                OK = false;
            }
            else if (userName.Length > 8)
            {
                OK = false;
            }
            //end of user name validation 

            //password validation 
            if (password.Length < 3)
            {
                OK = false;
            }
            else if (password.Length > 10)
            {
                OK = false;
            }
            //end of password validation 

            //expiry date validation
            if (expiryDate.Date < DateTime.Now.Date.AddYears(-5))
            {
                OK = false;
            }
            else if (expiryDate.Date > DateTime.Now.Date.AddYears(5))
            {
                OK = false;
            }

            //return variable
            return OK;
        }

        public bool Find(int CustomerId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerId", CustomerId);
            DB.Execute("sproc_Customer_FilterByCustomerID");
            //if one record is found (there should be either one or zero
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                musername = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mpassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mfirstname = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mlastname = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                memailaddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                mmobilenumber = Convert.ToString(DB.DataTable.Rows[0]["MobileNumber"]);
                mcardnumber = Convert.ToString(DB.DataTable.Rows[0]["CardNumber"]);
                msecuritycode = Convert.ToString(DB.DataTable.Rows[0]["SecurityCode"]);
                mexpirydate = Convert.ToDateTime(DB.DataTable.Rows[0]["ExpiryDate"]);
                maddressName = Convert.ToString(DB.DataTable.Rows[0]["AddressName"]);
                mstreetname = Convert.ToString(DB.DataTable.Rows[0]["AddressStreetName"]);
                mcityname = Convert.ToString(DB.DataTable.Rows[0]["AddressCityName"]);
                mpostcode = Convert.ToString(DB.DataTable.Rows[0]["AddressPostCode"]);
                //return that everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return true;
            }



            ////set the private data members to the test data value
            //mCustomerId = 1002;
            //musername = "aneekana";
            //mpassword = "dmu";
            //mfirstname = "Aneeka";
            //mlastname = "Naz";
            //memailaddress = "aneeka@gmail.com";
            //mmobilenumber = "07894561332";
            //mcardnumber = "1234567890123456";
            //msecuritycode = "454";
            //mexpirydate = Convert.ToDateTime("2019/ 05/ 25");
            //maddressName = "44A";
            //mstreetname = "Newarke Close";
            //mcityname = "abcdefghijklmnopqrstuvwxyz";
            //mpostcode = "LE2 7GZ";
            //return true;

        }
    }


}
