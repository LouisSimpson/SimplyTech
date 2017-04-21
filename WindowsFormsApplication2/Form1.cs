using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;


namespace stock
{
    public partial class Form1 : Form
    {
       // stockCollection Stock;

        public Form1()
        {
            InitializeComponent();
        }

        void FillListBox()
        {

        }

       /* public void AddStock()
        {
            Stock.AddStock("Nvidia GTX 1080 8GB", "10", "600", "6");
        }*/

        void DisplayStock()
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockDBFileDataSet1.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.stockDBFileDataSet1.Stock);
            DisplayStock();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
          
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxstockName.Text = listBox1.SelectedValue.ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
        }
    }
}
