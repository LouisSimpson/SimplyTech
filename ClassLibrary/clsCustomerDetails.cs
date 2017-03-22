using System;

namespace ClassLibrary
{
    public class clsCustomerDetails
    {
        public string accountnumber { get; set; }
        public string cardnumber { get; set; }
        public string cityname { get; set; }
        public int customerid { get; set; }
        public string doornumber { get; set; }
        public string emailaddress { get; set; }
        public string expirydate { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string mobilenumber { get; set; }
        public string postcode { get; set; }
        public string securitycode { get; set; }
        public string sortcode { get; set; }
        public string streetname { get; set; }

        public bool Valid(int houseNumber, string firstName)
        {
            {
                //create a boolean to flag error
                Boolean Ok = true;
                if (firstName.Length == 0)
                {
                    //Set the flag to ok
                    Ok = false;
                }
                if (firstName.Length > 16)
                {
                    //flag error
                    Ok = false;
                }
                {
                    //retuen ok
                    return Ok;
                }
              }
        }
}
}
    