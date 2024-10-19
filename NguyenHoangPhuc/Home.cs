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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btQL_Click(object sender, EventArgs e)
        {
            QL quanly = new QL();
            quanly.Show();
        }

        private void btBT_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
