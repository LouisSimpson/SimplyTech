using System;

namespace ClassLibrary
{
    public class clsCustomerDetails
    {
        public string AccountNumber { get; set; }
        public string CardNumber { get; set; }
        public int customerid { get; set; }
        public string ExpiryDate { get; set; }
        public string firstname { get; set; }
        public string SecurityCode { get; set; }
        public string SortCode { get; set; }

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
    