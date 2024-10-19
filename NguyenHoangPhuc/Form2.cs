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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.btThoat.Anchor = ((AnchorStyles)((AnchorStyles.Bottom| AnchorStyles.Right)));
            this.tbKetQua.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right)));
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Caculator";
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSoX.Text);
            int y = int.Parse(tbSoY.Text);
            int kq = x + y;
            tbKetQua.Text = tbKetQua.Text + x.ToString() + " + "+ y.ToString() +"="+ kq.ToString()+"\r\n";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSoX.Text);
            int y = int.Parse(tbSoY.Text);
            int kq = x * y;
            tbKetQua.Text = tbKetQua.Text + x.ToString() + " * " + y.ToString() + "=" + kq.ToString() + "\r\n";
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"C:\C#\Caculator.txt", true);
            sw.Write(tbKetQua.Text);
            sw.Close();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
