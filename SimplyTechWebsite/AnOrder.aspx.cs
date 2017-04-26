using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class AnOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
        
    {
      
          
        clsOrderCollection OrderBook = new clsOrderCollection();
        //validate the data on the web form 
        Boolean OK = OrderBook.ThisOrder.Valid(txtDateOrdered.Text, txtProductName.Text, txtQuantity.Text, txtPrice.Text);
        //if data is ok add to obect
        if (OK == true)
        {
            OrderBook.ThisOrder.DateOrdered = Convert.ToDateTime(txtDateOrdered.Text);
            OrderBook.ThisOrder.ProductName = txtDateOrdered.Text;
            OrderBook.ThisOrder.QuantityNo = Convert.ToInt32(txtQuantity.Text);
            OrderBook.ThisOrder.OrderPrice = Convert.ToDecimal(txtPrice.Text);
            OrderBook.Add();
        }
        else
        {
            //REPORT ERROR
            lblError.Text = "There were problems with the order details entered";
        }

        }

    protected void BtnOK_Click(object sender, EventArgs e)
    {
        Add();
        //redirect back to main page when complete
        Response.Redirect("home.aspx"); 
    }

    private void Add()
    {
        throw new NotImplementedException();
    }

    protected void BtnCancel_Click(object sender, EventArgs e)
    {

    }
}
