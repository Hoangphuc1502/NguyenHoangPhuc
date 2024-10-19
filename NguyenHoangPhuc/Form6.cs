using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NguyenHoangPhuc
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btTT_Click(object sender, EventArgs e)
        {
            string msg =null;
            int disc = 0;
            if (rbMale.Checked == true)
                msg += "Ông ";
            else if (rbFemale.Checked == true)
                msg += "Bà ";
            if (ckDiscount.Checked == true)
                disc = 5;
            tbResult.Text = msg + tbName.Text + " được giảm " + disc.ToString() + "%" + "\r\n";
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ckDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (ckDiscount.Checked == true)
                tbDiscount.Enabled = true;
            else
                tbDiscount.Enabled = false;
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}