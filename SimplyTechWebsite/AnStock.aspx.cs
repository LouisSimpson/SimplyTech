using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class AnStock : System.Web.UI.Page
{
    Int32 StockID;
    protected void Page_Load(object sender, EventArgs e)
    {
        StockID = Convert.ToInt32(Session["StockID"]);
        if(IsPostBack == false)
        {
           

            if (StockID != -1)
            {
                DisplayStock();
            }

        }
    }

    void Add()
     {
         clsStockCollection StockBook = new clsStockCollection();
         Boolean OK = StockBook.ThisStock.ValidExists(TextBoxName.Text, TextBoxDesc.Text, TextBoxLevel.Text, TextBoxPrice.Text);

         if(OK == true)
         {
             StockBook.ThisStock.ItemName = TextBoxName.Text;
             StockBook.ThisStock.StockDescription = TextBoxDesc.Text;
             StockBook.ThisStock.StockLevel = Convert.ToInt32(TextBoxLevel.Text);
             StockBook.ThisStock.StockPrice = Convert.ToDecimal(TextBoxPrice.Text);

             StockBook.Add();

         }

         else
         {
             lblError.Text = "There were problems with the data entered";
         }
     }

    void Update()
    {
        clsStockCollection StockBook = new clsStockCollection();
        Boolean OK = StockBook.ThisStock.ValidExists(TextBoxName.Text, TextBoxDesc.Text, TextBoxLevel.Text, TextBoxPrice.Text);

        if (OK == true)
        {
            StockBook.ThisStock.Find(StockID);
            StockBook.ThisStock.ItemName = TextBoxName.Text;
            StockBook.ThisStock.StockDescription = TextBoxDesc.Text;
            StockBook.ThisStock.StockLevel = Convert.ToInt32(TextBoxLevel.Text);
            StockBook.ThisStock.StockPrice = Convert.ToDecimal(TextBoxPrice.Text);

            StockBook.Update();

        }

        else
        {
            lblError.Text = "There were problems with the data entered";
        }
    }

    protected void ButtonOK_Click(object sender, EventArgs e)
    {
       if (StockID == -1)
        {
            Add();
        }
        else
        {
            Update();
        }
        Response.Redirect("Default.aspx");
    }

    protected void ButtonCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }

    void DisplayStock()
    {
        clsStockCollection StockBook = new clsStockCollection();
        StockBook.ThisStock.Find(StockID);
        TextBoxName.Text = StockBook.ThisStock.ItemName;
        TextBoxDesc.Text = StockBook.ThisStock.StockDescription;
       TextBoxLevel.Text = StockBook.ThisStock.StockLevel.ToString();
        TextBoxPrice.Text = StockBook.ThisStock.StockPrice.ToString();
        
    }
}