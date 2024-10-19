using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenHoangPhuc
{
    public partial class Form3 : Form
    {
        decimal workingMemory = 0;
        string opr = "";
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btPlus_Click(object sender, EventArgs e)
        {
            try
            {
                workingMemory = decimal.Parse(textBox1.Text);
                opr = btPlus.Text;
                textBox1.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid number format.");
            }
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            textBox1.Text += bt0.Text;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            textBox1.Text += bt1.Text;

        }

        private void bt2_Click(object sender, EventArgs e)
        {
            textBox1.Text += bt2.Text;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            textBox1.Text += bt3.Text;
        }

        private void btMul_Click(object sender, EventArgs e)
        {
            try
            {
                workingMemory = decimal.Parse(textBox1.Text);
                opr = btMul.Text;
                textBox1.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid number format.");
            }
        }

        private void btcham_Click(object sender, EventArgs e)
        {
            textBox1.Text += btcham.Text;
        }

        private void btEquals_Click(object sender, EventArgs e)
        {
            try
            {
                decimal secondValue = decimal.Parse(textBox1.Text);

                if (opr == "+")
                    textBox1.Text = (workingMemory + secondValue).ToString();
                else if (opr == "*")
                    textBox1.Text = (workingMemory * secondValue).ToString();
                else
                    MessageBox.Show("Unknown operator");

                opr = "";
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid number format.");
            }
        }
    }
}
