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
            double busFare = 2.0; //declaring the busFare variable to double a 2.0 fare

            int trips; //Declaring trips variable as an integer

            if (Int32.TryParse(txtTrips.Text, out trips)) //if string is converted to int succeeds in the trips text and returns the calculation in the trips variable then do the math
            {
                double total = busFare * trips; //the bus fare which is 2.0 multiply by the amount in trips to get the total which could be a very large number
                txtTotal.Text = "$" + total; //the $ sign plus the total is the text that will appear in the txtTotal text box
            }
            else //if whats entered is not an integer then
            {
                MessageBox.Show("Enter only numbers", "Error"); //Display the messagebox with the error as follows
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}