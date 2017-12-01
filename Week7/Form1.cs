using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoop1_Click(object sender, EventArgs e)
        {
            // Remove the instructions from the label
            lblMessage1.Text = "";

            // use a loop to display #'s from 100 to 120 on our label
            // for loop structure: Start #, Condition for Continuing, Increment
            // counter++ is the same as counter = counter + 1
            for (Int32 counter = 100; counter <= 120; counter++)
            {
                // add the current # on to the end of the label text
                lblMessage1.Text += counter + " ";
            }

        }

        private void btnWhileLoop_Click(object sender, EventArgs e)
        {
            // Remove the instructions from the label
            lblMessage1.Text = "";

            // use a while loop to display from 100 to 120
            // set a start number of 100
            Int32 counter = 100;

            while (counter <= 120)
            {
                // add the current # on to the end of the label text
                lblMessage1.Text += counter + " ";

                // add 1 to the counter
                counter++;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // clear the message label
            lblSum.Text = "";

            // capture x and y and try to convert the to numeric variables
            // Assume the form is complete
            bool ok = true;

            // check if the X input is numeric
            if (Int32.TryParse(txtX.Text, out Int32 x) == false)
            {
                lblSum.Text = "Enter a number for x. ";
                ok = false;
            }
            else if (x < 0)  // x is a negative number
            {
                lblSum.Text = "Enter a positive number for x. ";
                ok = false;
            }

            // check if the Y input is numeric
            if (Int32.TryParse(txtY.Text, out Int32 y) == false)
            {
                lblSum.Text += "Enter a number for y.";
                ok = false;
            }
            else if (y < 0)
            {
                lblSum.Text += "Enter a positive number for y. ";
                ok = false;
            }

            // send x and y to the AddNumbers method & display the result
            if (ok == true) { 
                Int32 result = AddNumbers(x,y);
                lblSum.Text = Convert.ToString(result);
            }
        }

        // method accepts 2 integer inputs and returns another integer back
        private Int32 AddNumbers(Int32 x, Int32 y)
        {
            // add the 2 input parameter values together 
            Int32 sum = x + y;

            // send back the result
            return sum;
        }
    }
}
