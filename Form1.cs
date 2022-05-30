using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class SimpleCalculator : Form
    {
        public SimpleCalculator()
        {
            InitializeComponent();
        }

        private void SimpleCalculator_Load(object sender, EventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt16(num1_txtbox.Text);
            int num2 = Convert.ToInt16(num2_txtbox.Text);
            int sum = num1 + num2;
            result_txtbox.Text = sum.ToString();
        }

        private void subtract_btn_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt16(num1_txtbox.Text);
            int num2 = Convert.ToInt16(num2_txtbox.Text);
            int difference = num1 - num2;
            result_txtbox.Text = difference.ToString();
        }

        private void multiply_btn_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt16(num1_txtbox.Text);
            int num2 = Convert.ToInt16(num2_txtbox.Text);
            int product = num1 * num2;
            result_txtbox.Text = product.ToString();
        }

        private void divide_btn_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt16(num1_txtbox.Text);
            int num2 = Convert.ToInt16(num2_txtbox.Text);
            int quotient = num1 / num2;
            result_txtbox.Text = quotient.ToString();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            num1_txtbox.Clear();
            num2_txtbox.Clear();
            result_txtbox.Text = "";
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
