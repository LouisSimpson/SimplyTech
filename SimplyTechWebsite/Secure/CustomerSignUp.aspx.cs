using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Secure_CustomerSignUp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    void add()
    {
        ClassLibrary.clsCustomerCollection Acustomer = new ClassLibrary.clsCustomerCollection();
        Boolean Ok = Acustomer.ThisCustomer.Valid(1, txtCityName.Text, txtHouseDoorNumber.Text, txtPostCode.Text, txtStreetName.Text, txtCardNumber.Text, txtEmailAddress.Text, DateTime expiryDate, txtFirstName.Text, txtLastName.Text, txtContactMobileNumber.Text, txtSecurityCode.Text, txtUserName.Text, txtPassword.Text);
        if (Ok ==true)
        {
            Acustomer.ThisCustomer.firstname = txtFirstName.Text;
            Acustomer.ThisCustomer.lastname = txtLastName.Text;
            Acustomer.ThisCustomer.emailaddress = txtEmailAddress.Text;
            Acustomer.ThisCustomer.mobilenumber = txtContactMobileNumber.Text;
            Acustomer.ThisCustomer.addressName = txtHouseDoorNumber.Text;
            Acustomer.ThisCustomer.streetname = txtStreetName.Text;
            Acustomer.ThisCustomer.cityname = txtCityName.Text;
            Acustomer.ThisCustomer.postcode = txtPostCode.Text;
            Acustomer.ThisCustomer.cardnumber = txtCardNumber.Text;
            Acustomer.ThisCustomer.expirydate = Convert.ToDateTime(txtExpiryDate.Text);
            Acustomer.ThisCustomer.secruitycode = txtSecurityCode.Text;
            Acustomer.Add();
        }
        else
        {
            lblError.Text = "There were problems with the data you entered";
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
    }
}