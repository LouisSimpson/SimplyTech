using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        public bool Active { get; set; }
        public List<clsCustomerCollection> CustomerList { get; set; }
        public string AccountNumber { get; set; }
        public string CardNumber { get; set; }
        public string AddressCityName { get; set; }
        public string AddressName { get; set; }
        public string EmailAddress { get; set; }
        public System.DateTime ExpiryDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string AddressPostCode { get; set; }
        public string SecurityCode { get; set; }
        public string SortCode { get; set; }
        public string AddressStreetName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Count { get; set; }
    }
}