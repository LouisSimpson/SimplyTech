using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStock();
        }
    }

    void DisplayStock()
    {
        ClassLibrary.clsStockCollection Stock = new ClassLibrary.clsStockCollection();
        ListBoxStock.DataSource = Stock.StockList;
        ListBoxStock.DataValueField = "StockID";
        ListBoxStock.DataTextField = "ItemName";
        ListBoxStock.DataBind();
    }

    protected void ListBoxStock_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        Session["StockID"] = -1;
        Response.Redirect("AnStock.aspx");

    }

    protected void BtnDelete_Click(object sender, EventArgs e)
    {
        Int32 StockID;
        if (ListBoxStock.SelectedIndex != -1)
        {
            StockID = Convert.ToInt32(ListBoxStock.SelectedValue);
            Session["StockID"] = StockID;
            Response.Redirect("Delete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
        }

    protected void BtnEdit_Click(object sender, EventArgs e)
    {
        Int32 StockID;

        if(ListBoxStock.SelectedIndex != -1)
        {
            StockID = Convert.ToInt32(ListBoxStock.SelectedValue);
            Session["StockID"] = StockID;
            Response.Redirect("AnStock.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}
