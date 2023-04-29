using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/**************************************
 * Name: Johan Rivera
 * Date: 28 APRIL 2023
 * Description: A program using user-created method
 *              for the math function Square and Cube
 * Assistance:
 *************************************/

namespace Exponents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void xGoButton_Click(object sender, EventArgs e)
        {
            // STORAGE
            double n1, Result1, Result2;

            // INPUT

            n1 = Convert.ToInt32(xInputTextBox.Text);


            // PROCESS

            /* calculate the square of the number and add it to the output - 
            * do this with a method call that allows you to pass the number
            * and then receive the answer */
            Result1 = Math.Pow(n1, 2);
            Console.WriteLine(Result1);



            /* calculate the cube of the number and add it to the output - 
             * do this by creating a methd as in the squaring example above */
            Result2 = Math.Pow(n1, 3);
            Console.WriteLine(Result2);

            // OUTPUT
            // set the output to visible
            xOutputLabel.Visible = true;
            xOutputLabel.Text = ("Squared = " + Result1) + (" Cubed = " + Result2);
            

            // turn the Go button off
            xGoButton.Enabled = false;
        }

        
        private void xResetButton_Click(object sender, EventArgs e)
        {
            // the input and output text should be emptied
            xInputTextBox.Clear();
            
            // turn the output to invisible
            xOutputLabel.Visible = false;

            // turn the Go button back on
            xGoButton.Enabled = true;
        }

        private void xInputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
