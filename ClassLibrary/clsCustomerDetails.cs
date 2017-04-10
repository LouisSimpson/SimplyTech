using System;

namespace ClassLibrary
{
    public class clsCustomerDetails
    {
        public string accountnumber { get; set; }
        public string cardnumber { get; set; }
        public string cityname { get; set; }
        public string addressName { get; set; }
        public string emailaddress { get; set; }
        public DateTime expirydate { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string mobilenumber { get; set; }
        public string postcode { get; set; }
        public string securitycode { get; set; }
        public string sortcode { get; set; }
        public string streetname { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public bool Valid(string accountNumber, string addressCityName, string addressName, string addressPostCode, string addressStreetName, string cardNumber, string emailAddress, DateTime expiryDate, string firstName, string lastName, string mobileNumber, string securityCode, string sortCode, string userName, string password)
        {
            //declare a variable to pass as return
            bool OK = true;

            //Account Number validation
            if (accountNumber.Length != 8)
            {
                OK = false;
            }
            //End of Account number

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

    