using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Secure_CustomerLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    bool login(string UserName, string Password)
    {
        ClassLibrary.clsCustomerCollection custcollection = new ClassLibrary.clsCustomerCollection();
        bool logintrue = custcollection.login(UserName, Password);
        if (logintrue == true)
        {
            return true;
        }
        else {
            return false;
                }
    }

    protected void BtnConfirm_Click(object sender, EventArgs e)
    {
        ClassLibrary.clsCustomerCollection custcollect = new ClassLibrary.clsCustomerCollection();
        lblError.Text = "HELP";
        //store data in varaibales
        string UserName = TxtLogin.Text;
        string Password = txtPassword.Text;

        try
        {
            bool logintrue = custcollect.login(UserName, Password);
            if (logintrue == true)
            {
                Response.Redirect("CustomerHome.aspx");

            }
            else
            {
                lblError.Text = "Login Failed";
            }
        }
        catch
        {
            lblError.Text = "Your login was unsuccessful. Try again.";
        }

    }
}