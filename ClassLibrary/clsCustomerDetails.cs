using System;

namespace ClassLibrary
{
    public class clsCustomerDetails
    {
        public string accountnumber { get; set; }
        public string cardnumber { get; set; }
        public string cityname { get; set; }
        public int customerid { get; set; }
        public string addressName { get; set; }
        public string emailaddress { get; set; }
        public string expirydate { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string mobilenumber { get; set; }
        public string postcode { get; set; }
        public string securitycode { get; set; }
        public string sortcode { get; set; }
        public string streetname { get; set; }

        public bool Valid(string accountNumber, string addressCityName, string addressName, string addressPostCode, string addressStreetName, string cardNumber, int customerID, string emailAddress, DateTime expiryDate, string firstName, string lastName, string mobileNumber, int securityCode, string sortCode)
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
            //Address PostCode validation
            if (addressPostCode. Length < 6)
            {
                OK = false;
            }
            else if (addressPostCode. Length > 8)
            {
                OK = false;
            }
            //Address Street Name Validation
            if (addressStreetName.Length < 3)
            {
                 OK = false;
            }
            else if (addressStreetName.Length > 30)
            {
                 OK = false;
            }
          
            //return variable
            return OK;
        }
    }
}
    