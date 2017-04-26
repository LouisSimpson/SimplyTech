using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DefaultOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack == false)
        {
            DisplayOrders();

        }

    }
    void DisplayOrders()
    {
        ClassLibrary.clsOrderCollection Orders = new ClassLibrary.clsOrderCollection();
        ListBoxOrder.DataSource = Orders.OrderList;
        //set name of primary key
        ListBoxOrder.DataValueField = "OrderNo";
        //set data field to display
        ListBoxOrder.DataTextField = "ProductName";
        //blind data to list
        ListBoxOrder.DataBind();
    }

    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderNo"] = -1;
        //redirct to data entry page
        Response.Redirect("AnOrder.aspx");
    }

    protected void BtnDelete_Click(object sender, EventArgs e)
    {

    }

    protected void BtnEdit_Click(object sender, EventArgs e)
    {

    }

    protected void ListBoxStock_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}