using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
using clslibrary;
public partial class DeleteOrders : System.Web.UI.Page
{
    Int32 OrderNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get number of order to be deleted
        OrderNo = Convert.ToInt32(Session["OrderNo"]);
    }
    void DeleteOrder()
    {
        clsOrderCollection OrderBook = new clsOrderCollection();
        OrderBook.ThisOrder.Find(OrderNo);
        OrderBook.Delete();
    }

    protected void BtnYes_Click(object sender, EventArgs e)
    {
        //delete order
        DeleteOrder();
        //redirect to main page
        Response.Redirect("DefaultOrder.aspx");

    }

    protected void BtnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("DefaultOrder.aspx");
    }
}