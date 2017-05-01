using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //display the username
        lblUserInfo.Text = "The current user is " + User.Identity.Name;
        //test for admin rights
        if (User.IsInRole("admin")== true)
        {
            lblUserInfo.Text = lblUserInfo.Text + " The user is an admin";
        }
        else
        {
            lblUserInfo.Text = lblUserInfo.Text + " The user is not an admin";
        }


    }
}