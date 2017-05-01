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
        Int32 OrderNo;
        //if a record has been selected from the list
        if(ListBoxOrder.SelectedIndex != -1)
        {
            OrderNo = Convert.ToInt32(ListBoxOrder.SelectedValue);
            //store data in session object
            Session["OrderNo"] = OrderNo;
            //redirect to delete page
            Response.Redirect("DeleteOrders.aspx");
        }
        else //no record selected
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void BtnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderNo;
        if (ListBoxOrder.SelectedIndex != -1)
        {
            OrderNo = Convert.ToInt32(ListBoxOrder.SelectedValue);
            Session["OrderNo"] = OrderNo;
            //redirect to edit page
            Response.Redirect("AnOrder.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to Edit from the list.";
        }

        }
            

    protected void ListBoxStock_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}