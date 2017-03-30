using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock
{
    public partial class Form1 : Form
    {
        stockCollection Stock;

        public Form1()
        {
            InitializeComponent();
        }

       /* public void AddStock()
        {
            Stock.AddStock("Nvidia GTX 1080 8GB", "10", "600", "6");
        }*/

        public void DisplayStock()
        {
            textBoxstockName.Text = Stock.GetStockstockName();
            textBoxstockLevel.Text = Stock.GetStockstockLevel();
            textBoxstockPrice.Text = Stock.GetStockstockPrice();
            textBoxstockLocation.Text = Stock.GetStockstockLocation();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // create a stock object

            Stock = new stock.stockCollection();
            //AddStock();

            // show data on form
            DisplayStock();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Stock.StepToNextStock();
            // update display
            DisplayStock();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            Stock.StepToPreviousStock();
            // update display
            DisplayStock();
        }
    }
}
