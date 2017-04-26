using System;

namespace ClassLibrary
{
    public class clsCustomerDetails
    {
        private Int32 mcustomerid;
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

        public string cardnumber {

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
                return mcustomerid; 
            }
            set
            {
                mcustomerid = value;
            }
        }

        public bool Valid(int customerId, string addressCityName, string addressName, string addressPostCode, string addressStreetName, string cardNumber, string emailAddress, DateTime expiryDate, string firstName, string lastName, string mobileNumber, string securityCode, string userName, string password)
        {
            //declare a variable to pass as return
            bool OK = true;

            //customer id validation
            if (customerId < 3)
            {
                OK = false;
            }
            else if (customerId > 8)
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
            else if (addressName.Length > 50)
            {
                OK = false;
            }
            //end of address name validation 

            //Address PostCode validation
            if (addressPostCode.Length < 6)
            {
                OK = false;
            }
            else if (addressPostCode.Length > 8)
            {
                OK = false;
            }
            //end of address postcode validation 

            //Address Street Name Validation
            if (addressStreetName.Length < 3)
            {
                OK = false;
            }
            else if (addressStreetName.Length > 30)
            {
                OK = false;
            }
            //end of address street name validation 

            // card number validation 
            if (cardNumber. Length !=16)
            {
                OK = false;
            }
            //end of card number validation 

            // email address validation
            if (emailAddress. Length < 6)
            {
                OK = false;
            }
            else if (emailAddress.Length > 30)
            {
                OK = false;
            }
            //end of email address validation 

            //First Name validation 
            if (firstName. Length <2)
            {
                OK = false;
            }
            else if (firstName. Length > 15)
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
            if (securityCode. Length != 3)
            {
                OK = false;
            }
            //end of Security Code number validation 

            //user name validation
            if (userName. Length <3)
            {
                OK = false;
            }
            else if (userName. Length > 8)
            {
                OK = false;
            }
            //end of user name validation 

            //password validation 
            if (password. Length < 3)
            {
                OK = false;
            }
            else if (password. Length > 10)
            {
                OK = false; 
            }
            //end of password validation 

            //expiry date validation
            if (expiryDate.Date < DateTime.Now.Date)
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

}

   
}

    