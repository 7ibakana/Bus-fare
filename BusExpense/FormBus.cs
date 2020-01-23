using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusExpense
{
    public partial class FormBus : Form
    {
        public FormBus()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double busFare = 2.0;

            int trips;

            if (Int32.TryParse(txtTrips.Text, out trips))
            {
                double total = busFare * trips;
                txtTotal.Text = "$" + total;
            }
            else
            {
                MessageBox.Show("Enter only numbers", "Error");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}