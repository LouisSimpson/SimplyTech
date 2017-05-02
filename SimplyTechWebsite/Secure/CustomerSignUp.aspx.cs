using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class Secure_CustomerSignUp : System.Web.UI.Page
{
    Int32 CustomerId;

    public object Acustomer { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        //CustomerId = Convert.ToInt32(Session[CustomerId]);
        if (IsPostBack == false)
        {
            if (CustomerId != -1)
            {
                DisplayACustomer();
            }
        }
    }

    string add()
    {
        ClassLibrary.clsCustomerCollection Acustomer = new ClassLibrary.clsCustomerCollection();
        
            Acustomer.ThisCustomer.firstname = txtFirstName.Text;
            Acustomer.ThisCustomer.lastname = txtLastName.Text;
            Acustomer.ThisCustomer.emailaddress = txtEmailAddress.Text;
            Acustomer.ThisCustomer.mobilenumber = txtContactMobileNumber.Text;
            Acustomer.ThisCustomer.addressName = txtHouseDoorNumber.Text;
            Acustomer.ThisCustomer.streetname = txtStreetName.Text;
            Acustomer.ThisCustomer.cityname = txtCityName.Text;
            Acustomer.ThisCustomer.postcode = txtPostCode.Text;
            Acustomer.ThisCustomer.cardnumber = txtCardNumber.Text;
            Acustomer.ThisCustomer.expirydate = Convert.ToDateTime(txtExpiryDate.Text).Date;
            Acustomer.ThisCustomer.secruitycode = txtSecurityCode.Text;
        Acustomer.ThisCustomer.username = txtUserName.Text;
        Acustomer.ThisCustomer.password = txtPassword.Text;
            string customerid = Acustomer.Add().ToString();

        return customerid;
    }


    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        if (CustomerId == 0)
        {
            
            lblError.Text = add() + " Added Successfully :) xxx";
        }
        else
        {
            lblError.Text = "Error adding";
        }
    }

    private void Update()
    {
        clsCustomerCollection ACustomer = new clsCustomerCollection();
        Boolean Ok = ACustomer.ThisCustomer.Valid(1, txtCityName.Text, txtHouseDoorNumber.Text, txtPostCode.Text, txtStreetName.Text, txtCardNumber.Text, txtEmailAddress.Text, Convert.ToDateTime(txtExpiryDate), txtFirstName.Text, txtLastName.Text, txtContactMobileNumber.Text, txtSecurityCode.Text, txtUserName.Text, txtPassword.Text);
        if (Ok == true)
        {
            ACustomer.ThisCustomer.firstname = txtFirstName.Text;
            ACustomer.ThisCustomer.lastname = txtLastName.Text;
            ACustomer.ThisCustomer.emailaddress = txtEmailAddress.Text;
            ACustomer.ThisCustomer.mobilenumber = txtContactMobileNumber.Text;
            ACustomer.ThisCustomer.addressName = txtHouseDoorNumber.Text;
            ACustomer.ThisCustomer.streetname = txtStreetName.Text;
            ACustomer.ThisCustomer.cityname = txtCityName.Text;
            ACustomer.ThisCustomer.postcode = txtPostCode.Text;
            ACustomer.ThisCustomer.cardnumber = txtCardNumber.Text;
            ACustomer.ThisCustomer.expirydate = Convert.ToDateTime(txtExpiryDate.Text);
            ACustomer.ThisCustomer.secruitycode = txtSecurityCode.Text;
            ACustomer.Update();
        }
        else
        {
            lblError.Text = "there were problems with the data entered";
        }
    }
    void DisplayACustomer()
    {
        clsCustomerCollection ACustomer = new clsCustomerCollection();
        ACustomer.ThisCustomer.Find(CustomerId);
        txtCityName.Text = ACustomer.ThisCustomer.cityname;
        txtHouseDoorNumber.Text = ACustomer.ThisCustomer.addressName;
        txtPostCode.Text = ACustomer.ThisCustomer.postcode;
        txtStreetName.Text = ACustomer.ThisCustomer.streetname;
        txtCardNumber.Text = ACustomer.ThisCustomer.cardnumber;
        txtEmailAddress.Text = ACustomer.ThisCustomer.emailaddress;
        txtExpiryDate.Text = ACustomer.ThisCustomer.expirydate.ToString();
        txtFirstName.Text = ACustomer.ThisCustomer.firstname;
        txtLastName.Text = ACustomer.ThisCustomer.lastname;
        txtContactMobileNumber.Text = ACustomer.ThisCustomer.mobilenumber;
        txtSecurityCode.Text = ACustomer.ThisCustomer.secruitycode;
        txtUserName.Text = ACustomer.ThisCustomer.username;
        txtPassword.Text = ACustomer.ThisCustomer.password;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {

        Response.Redirect("DefaultCustomer.aspx");
    }
}