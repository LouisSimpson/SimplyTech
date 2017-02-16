using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyClassLibrary
{
    public class clsStaff
    {
        public string StaffId { get; set; }

        public string FirstName { get; set; }

        public object StartDate { get; set; }

        public bool Valid(int StaffId, string DateAdded)
        {
           
            //boolean flag to indicate that all is OK
            Boolean OK = true;
            DateTime temp;

            try
            {
                if (StaffId != 1)
                {
                    OK = false;
                }

                /* if FirstName is blank
                if (FirstName == "")
                {
                    //Flag an error
                    OK = false;
                }
                //if name of the person is more than 50 characters
                if (FirstName.Length > 50)
                {
                    //flag an error
                    OK = false;
                }*/


                temp = Convert.ToDateTime(DateAdded);
                if (temp < DateTime.Now.Date.AddDays(-1))
                {
                    OK = false;
                }
            }
            catch
            {
            }


            //otherwise assume everything is OK
            return OK;
        }

       

    }
}
