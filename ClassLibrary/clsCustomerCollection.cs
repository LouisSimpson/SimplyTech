using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        public int Count { get; set; }
        public List<clsCustomerDetails> mCustomerList = new List<clsCustomerDetails>();


        clsCustomerDetails mThisCustomer = new clsCustomerDetails();

        //public property for ThisCustomer
        public clsCustomerDetails ThisCustomer
        {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
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

        public clsCustomerCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //executre the stored procedure
            DB.Execute("sproc_Customer_SelectAll");
            //get the count of the records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsCustomerDetails AnCustomer = new clsCustomerDetails();
                //read in the fields from the current record
                AnCustomer.customerid = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnCustomer.username = Convert.ToString(DB.DataTable.Rows[Index]["UserName"]);
                AnCustomer.password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                AnCustomer.firstname = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AnCustomer.lastname = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AnCustomer.emailaddress = Convert.ToString(DB.DataTable.Rows[Index]["EmailAddress"]);
                AnCustomer.mobilenumber = Convert.ToString(DB.DataTable.Rows[Index]["MobileNumber"]);
                AnCustomer.cardnumber = Convert.ToString(DB.DataTable.Rows[Index]["CardNumber"]);
                AnCustomer.secruitycode = Convert.ToString(DB.DataTable.Rows[Index]["SecurityCode"]);
                AnCustomer.expirydate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ExpiryDate"]);
                AnCustomer.addressName = Convert.ToString(DB.DataTable.Rows[Index]["AddressName"]);
                AnCustomer.streetname = Convert.ToString(DB.DataTable.Rows[Index]["AddressStreetName"]);
                AnCustomer.cityname = Convert.ToString(DB.DataTable.Rows[Index]["AddressCityName"]);
                AnCustomer.postcode = Convert.ToString(DB.DataTable.Rows[Index]["AddressPostCode"]);
                //add the record to the provate data member
                mCustomerList.Add(AnCustomer);
                //point at the next record
                Index++;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            {
                DB.AddParameter("@UserName", mThisCustomer.username);
                DB.AddParameter("@Password", mThisCustomer.password);
                DB.AddParameter("@AddressCityName", mThisCustomer.cityname);
                DB.AddParameter("@AddressName", mThisCustomer.addressName);
                DB.AddParameter("@AddressPostCode", mThisCustomer.postcode);
                DB.AddParameter("@AddressStreetName", mThisCustomer.streetname);
                DB.AddParameter("@CardNumber", mThisCustomer.cardnumber);
                DB.AddParameter("@EmailAddress", mThisCustomer.emailaddress);
                DB.AddParameter("@ExpiryDate", mThisCustomer.expirydate);
                DB.AddParameter("@FirstName", mThisCustomer.firstname);
                DB.AddParameter("@LastName", mThisCustomer.lastname);
                DB.AddParameter("@MobileNumber", mThisCustomer.mobilenumber);
                DB.AddParameter("@SecurityCode", mThisCustomer.secruitycode);

                return DB.Execute("sproc_tblCustomer_Add");
            }


           
        }

        public void Delete()
        {
            //deletes the record pointed to by the thiscustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@UserName", mThisCustomer.username);
            DB.AddParameter("@Password", mThisCustomer.password);
            DB.AddParameter("@AddressCityName", mThisCustomer.cityname);
            DB.AddParameter("@AddressName", mThisCustomer.addressName);
            DB.AddParameter("@AddressPostCode", mThisCustomer.postcode);
            DB.AddParameter("@AddressStreetName", mThisCustomer.streetname);
            DB.AddParameter("@CardNumber", mThisCustomer.cardnumber);
            DB.AddParameter("@EmailAddress", mThisCustomer.emailaddress);
            DB.AddParameter("@ExpiryDate", mThisCustomer.expirydate);
            DB.AddParameter("@FirstName", mThisCustomer.firstname);
            DB.AddParameter("@LastName", mThisCustomer.lastname);
            DB.AddParameter("@MobileNumber", mThisCustomer.mobilenumber);
            DB.AddParameter("@SecurityCode", mThisCustomer.secruitycode);
            //execute the stored procedure
            DB.Execute("sproc_Customer_Delete");
        }
    }
}

