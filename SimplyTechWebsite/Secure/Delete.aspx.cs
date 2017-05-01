using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class Delete : System.Web.UI.Page
{
    Int32 StockID;
    protected void Page_Load(object sender, EventArgs e)
    {
        StockID = Convert.ToInt32(Session["StockID"]);
    }

    void DeleteStock()
    {
        clsStockCollection StockBook = new clsStockCollection();
        StockBook.ThisStock.Find(StockID);
        StockBook.Delete();
    }

    protected void BtnYes_Click(object sender, EventArgs e)
    {
        DeleteStock();
        Response.Redirect("Default.aspx");
    }
}