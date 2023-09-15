using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string calTotal;
        int num1;
        int num2;
        string option;
        int result;

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            texttotal.Text = texttotal.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            texttotal.Text = texttotal.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            texttotal.Text = texttotal.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            texttotal.Text = texttotal.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            texttotal.Text = texttotal.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            texttotal.Text = texttotal.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            texttotal.Text = texttotal.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            texttotal.Text = texttotal.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            texttotal.Text = texttotal.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            texttotal.Text = texttotal.Text + btn0.Text;
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(texttotal.Text);
            texttotal.Clear();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(texttotal.Text);
            texttotal.Clear();
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(texttotal.Text);
            texttotal.Clear();
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(texttotal.Text);
            texttotal.Clear();
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(texttotal.Text);

            if (option.Equals("+"))
                result = num1 + num2;

            if (option.Equals("-"))
                result = num1 - num2;

            if (option.Equals("*"))
                result = num1 * num2;

            if (option.Equals("/"))
                result = num1 / num2;

            texttotal.Text = result + "";

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            texttotal.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }
    }
}
