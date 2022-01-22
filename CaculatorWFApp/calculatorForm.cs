using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaculatorWFApp
{
    public partial class calculatorForm : Form
    {
        public calculatorForm()
        {
            InitializeComponent();
        }

        private void firstNumbertextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int x,y, z;
            x=Convert.ToInt32(firstNumbertextBox.Text);
            y=Convert.ToInt32(secondNumberTextBox.Text);
            z = x + y;
            resultTextBox.Text = z.ToString();
           
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            int x, y, z;
            x = Convert.ToInt32(firstNumbertextBox.Text);
            y = Convert.ToInt32(secondNumberTextBox.Text);
            z = x * y;
            resultTextBox.Text = z.ToString();
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            int x, y, z;
            x = Convert.ToInt32(firstNumbertextBox.Text);
            y = Convert.ToInt32(secondNumberTextBox.Text);
            z = x - y;
            resultTextBox.Text = z.ToString();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            int x, y, z;
            x = Convert.ToInt32(firstNumbertextBox.Text);
            y = Convert.ToInt32(secondNumberTextBox.Text);
            z = x / y;
            resultTextBox.Text = z.ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            firstNumbertextBox.Clear();
            secondNumberTextBox.Clear();
            resultTextBox.Clear();
        }
    }
}
