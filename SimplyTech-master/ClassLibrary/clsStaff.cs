using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_Library
{
    public class clsStaff
    {
        //private data members

        private Int32 mStaffId;
        private string mTitle;
        private string mFirstName;
        private string mLastName;
        private string mGender;
        private string mAddressNo;
        private string mStreet;
        private string mTown;
        private string mPostCode;
        private string mEmail;
        private string mDepartment;
        private Int32 mSalary;
        private DateTime mDateAdded;
        private Boolean mActive;



        public int StaffId
        {
            get
            {
                //return the private data
                return mStaffId;
            }
            set
            {
                //set the value of the private data member
                mStaffId = value;
            }
        }

        public String Title
        {
            get
            {
                //return the private data
                return mTitle;
            }
            set
            {
                //set the value of the private data member
                mTitle = value;
            }
        }

        public String FirstName
        {
            get
            {
                //return the private data
                return mFirstName;
            }
            set
            {
                //set the value of the private data member
                mFirstName = value;
            }
        }


        public String LastName
        {
            get
            {
                //return the private data
                return mLastName;
            }
            set
            {
                //set the value of the private data member
                mLastName = value;
            }
        }

        public String Gender
        {
            get
            {
                //return the private data
                return mGender;
            }
            set
            {
                //set the value of the private data member
                mGender = value;
            }
        }

        public String AddressNo
        {
            get
            {
                //return the private data
                return mAddressNo;
            }
            set
            {
                //set the value of the private data member
                mAddressNo = value;
            }
        }


        public String Street
        {
            get
            {
                //return the private data
                return mStreet;
            }
            set
            {
                //set the value of the private data member
                mStreet = value;
            }
        }


        public String Town
        {
            get
            {
                //return the private data
                return mTown;
            }
            set
            {
                //set the value of the private data member
                mTown = value;
            }
        }


        public String PostCode
        {
            get
            {
                //return the private data
                return mPostCode;
            }
            set
            {
                //set the value of the private data member
                mPostCode = value;
            }
        }


        public String Email
        {
            get
            {
                //return the private data
                return mEmail;
            }
            set
            {
                //set the value of the private data member
                mEmail = value;
            }
        }


        public String Department
        {
            get
            {
                //return the private data
                return mDepartment;
            }
            set
            {
                //set the value of the private data member
                mDepartment = value;
            }
        }


        public Int32 Salary
        {
            get
            {
                //return the private data
                return mSalary;
            }
            set
            {
                //set the value of the private data member
                mSalary = value;
            }
        }


        public DateTime DateAdded
        {
            get
            {
                //return the private data
                return mDateAdded;
            }
            set
            {
                //set the value of the private data member
                mDateAdded = value;
            }
        }


        public Boolean Active
        {
            get
            {
                //return the private data
                return mActive;
            }
            set
            {
                //set the value of the private data member
                mActive = value;
            }
        }



        public bool Find(int StaffId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@StaffId", StaffId);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mTitle = Convert.ToString(DB.DataTable.Rows[0]["Title"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mGender = Convert.ToString(DB.DataTable.Rows[0]["Gender"]);
                mAddressNo = Convert.ToString(DB.DataTable.Rows[0]["AddressNo"]);
                mStreet = Convert.ToString(DB.DataTable.Rows[0]["Street"]);
                mTown = Convert.ToString(DB.DataTable.Rows[0]["Town"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                mSalary = Convert.ToInt32(DB.DataTable.Rows[0]["Salary"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);

                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public bool Valid(string Title, string FirstName, string LastName, string Gender, string AddressNo, string Street, string Town, string PostCode, string Email, string Department, int Salary, string DateAdded)
        {
            //create a Boolean variable to flag the error
            Boolean OK = true;
            //create a temporary variable to store date values
            DateTime DateTemp;

            //if the Title is blank
            if (Title.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the house no is greater than 6 characters
            if (Title.Length > 6)
            {
                //set the flag OK to false
                OK = false;
            }


            //is the This field is blank
            if (FirstName.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the field entry is too long
            if (FirstName.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }

            //is the This field is blank
            if (LastName.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the field entry is too long
            if (LastName.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }

            //is the This field is blank
            if (Gender.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the field entry is too long
            if (Gender.Length > 6)
            {
                //set the flag OK to false
                OK = false;
            }

            //is the This field is blank
            if (AddressNo.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the field entry is too long
            if (AddressNo.Length > 6)
            {
                //set the flag OK to false
                OK = false;
            }

            //is the This field is blank
            if (Street.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the field entry is too long
            if (Street.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }

            //is the This field is blank
            if (Town.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the field entry is too long
            if (Town.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }
            //is the This field is blank
            if (PostCode.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the field entry is too long
            if (PostCode.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }

            //is the This field is blank
            if (Email.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the field entry is too long
            if (Email.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }
            //is the This field is blank
            if (Department.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the field entry is too long
            if (Department.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }


            //try the date validation assuming the data is a valid date
            try
            {
                //copy the DateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(DateAdded);
                //check to see if the date is less than today's date
                if (DateTemp < DateTime.Now.Date)
                {
                    //set the flag OK to false
                    OK = false;
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //set the flag OK to false
                    OK = false;
                }
            }
            //the data was not a date so flag an error
            catch
            {
                //set the flag OK to false
                OK = false;
            }


            //return the value of OK
            return OK;
        }
    }

}
