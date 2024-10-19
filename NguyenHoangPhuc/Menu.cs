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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btCau1_Click(object sender, EventArgs e)
        {
            Form1 fr01 = new Form1();
            fr01.Show();
        }

        private void btCau2_Click(object sender, EventArgs e)
        {
            Form2 fr02 = new Form2();
            fr02.Show();
        }

        private void btCau3_Click(object sender, EventArgs e)
        {
            Form3 fr03 = new Form3();
            fr03.Show();
        }

        private void btCau4_Click(object sender, EventArgs e)
        {
            Form4 fr04 = new Form4();
            fr04.Show();
        }

        private void btCau5_Click(object sender, EventArgs e)
        {
            Form5 fr05 = new Form5();
            fr05.Show();
        }

        private void btCau6_Click(object sender, EventArgs e)
        {
            Form6 fr06 = new Form6();
            fr06.Show();
        }

        private void btCau7_Click(object sender, EventArgs e)
        {
            Form7 fr07 = new Form7();
            fr07.Show();
        }

        private void btCau8_Click(object sender, EventArgs e)
        {
            Form8 fr08 = new Form8();
            fr08.Show();
        }

        private void btCau9_Click(object sender, EventArgs e)
        {
            Form9 fr09 = new Form9();
            fr09.Show();
        }

        private void btQL_Click(object sender, EventArgs e)
        {
            QL quanly = new QL();
            quanly.Show();
        }
    }
}
