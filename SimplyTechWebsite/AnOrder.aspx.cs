using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class AnOrder : System.Web.UI.Page
{
    Int32 OrderNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderNo = Convert.ToInt32(Session["OrderNo"]);
        if (IsPostBack==false)
        {
            DisplayOrder();
            if (OrderNo !=-1)
            {
                DisplayOrder();
            }
        }
    }

 
    
    void Add()
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
    void Update()
    {

        clsOrderCollection OrderBook = new clsOrderCollection();
    //validate the data on the web form 
    Boolean OK = OrderBook.ThisOrder.Valid(txtDateOrdered.Text, txtProductName.Text, txtQuantity.Text, txtPrice.Text);
        //if data is ok add to obect
        if (OK == true)
        {
            OrderBook.ThisOrder.Find(OrderNo);
            OrderBook.ThisOrder.DateOrdered = Convert.ToDateTime(txtDateOrdered.Text);
            OrderBook.ThisOrder.ProductName = txtDateOrdered.Text;
            OrderBook.ThisOrder.QuantityNo = Convert.ToInt32(txtQuantity.Text);
            OrderBook.ThisOrder.OrderPrice = Convert.ToDecimal(txtPrice.Text);
            //UPDATE RECORD
            OrderBook.Update();
        }
        else
        {
            //REPORT ERROR
            lblError.Text = "There were problems with the order details entered";
        }

    }

    

    protected void BtnOK_Click(object sender, EventArgs e)
    {
        if (OrderNo == -1)
        {
            Add();
        }
        else
        {
            Update();
        }
        //redirect back to main page when complete
        Response.Redirect("DefaultOrder.aspx");
    }


    protected void BtnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("DefaultOrder.aspx");
    }
    void DisplayOrder()
    {
        clsOrderCollection OrderBook = new clsOrderCollection();
        //find record to update
        OrderBook.ThisOrder.Find(OrderNo);
        //display data for record
        txtDateOrdered.Text = OrderBook.ThisOrder.DateOrdered.ToString();
        txtProductName.Text = OrderBook.ThisOrder.ProductName;
        txtQuantity.Text = OrderBook.ThisOrder.ToString();
        txtPrice.Text = OrderBook.ThisOrder.ToString();

    }
}

