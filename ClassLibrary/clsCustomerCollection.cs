using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        public int Count { get; set; }
        public List<clsCustomerDetails> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }

        }
        //public property for count
        public int count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set
            {
                //
            }
        }

        public clsCustomerDetails ThisCustomers { get; set; }

        List<clsCustomerDetails> mCustomerList = new List<clsCustomerDetails>();



        //constructor for the class
        //public clsCustomerCollection()
        //{
        //    //create the items of the test data
        //    clsCustomerDetails TestItem = new clsCustomerDetails();
        //    //set its properties
        //    TestItem.username = "aneekana";
        //    TestItem.password = "dmu";
        //    TestItem.firstname = "Jonathan";
        //    TestItem.lastname = "Smith";
        //    TestItem.emailaddress = "JonathanSmith@gmail.com";
        //    TestItem.mobilenumber = "07701343822";
        //    TestItem.cardnumber = "0236562385697459";
        //    TestItem.accountnumber = "00856324";
        //    TestItem.sortcode = "004853";
        //    TestItem.securitycode = "454";
        //    TestItem.expirydate = DateTime.Now.Date;
        //    TestItem.addressName = "44A";
        //    TestItem.streetname = "Newarke Close";
        //    TestItem.cityname = "Leicester";
        //    TestItem.postcode = "LE2 7GZ";
        //    //add the item to the test list
        //    mCustomerList.Add(TestItem);
        //    //re initialise the object for some new data
        //    TestItem = new clsCustomerDetails();
        //    //set its propertites
        //    TestItem.username = "aneefana";
        //    TestItem.password = "dfu";
        //    TestItem.firstname = "Jondthan";
        //    TestItem.lastname = "Seith";
        //    TestItem.emailaddress = "JonadhanSmsth@gmail.com";
        //    TestItem.mobilenumber = "07702743822";
        //    TestItem.cardnumber = "0236562386997459";
        //    TestItem.accountnumber = "00856264";
        //    TestItem.sortcode = "007853";
        //    TestItem.securitycode = "494";
        //    TestItem.expirydate = DateTime.Now.Date;
        //    TestItem.addressName = "24A";
        //    TestItem.streetname = "Neearke Close";
        //    TestItem.cityname = "Leocester";
        //    TestItem.postcode = "Ld2 7GZ";
        //    //add the item to the test list
        //    mCustomerList.Add(TestItem);

        //}
        //constructor for the class

        public clsCustomerCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //executre the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get the count of the records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsCustomerDetails AnCustomer = new clsCustomerDetails();
                //read in the fields from the current record
                AnCustomer.username = Convert.ToString(DB.DataTable.Rows[Index]["Username"]);
                AnCustomer.password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                AnCustomer.firstname = Convert.ToString(DB.DataTable.Rows[Index]["Firstname"]);
                AnCustomer.lastname = Convert.ToString(DB.DataTable.Rows[Index]["Lastname"]);
                AnCustomer.emailaddress = Convert.ToString(DB.DataTable.Rows[Index]["Emailaddress"]);
                AnCustomer.mobilenumber = Convert.ToString(DB.DataTable.Rows[Index]["Mobilenumber"]);
                AnCustomer.cardnumber = Convert.ToString(DB.DataTable.Rows[Index]["Cardnumber"]);
                AnCustomer.secruitycode = Convert.ToString(DB.DataTable.Rows[Index]["Securitycode"]);
                AnCustomer.expirydate = Convert.ToDateTime(DB.DataTable.Rows[Index]["Expirydate"]);
                AnCustomer.addressName = Convert.ToString(DB.DataTable.Rows[Index]["AddressName"]);
                AnCustomer.streetname = Convert.ToString(DB.DataTable.Rows[Index]["Streetname"]);
                AnCustomer.cityname = Convert.ToString(DB.DataTable.Rows[Index]["Cityname"]);
                AnCustomer.postcode = Convert.ToString(DB.DataTable.Rows[Index]["postcode"]);
                //add the record to the provate data member
                mCustomerList.Add(AnCustomer);
                //point at the next record
                Index++;





            }
        }





    }
}