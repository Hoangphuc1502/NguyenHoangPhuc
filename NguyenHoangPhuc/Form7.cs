using Microsoft.VisualBasic;
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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string hoten = btName.Text;
            string ngaysinh = dtpDate.Value.ToString("dd/MM/yyyy");
            string gioiTinh = rbMale.Checked ? "Nam" : "Nữ";
            string khoa = cb_Faculty.SelectedItem?.ToString() ?? "Chưa chọn";

            string thongTinSinhVien = $"{listBoxSinhVien.Items.Count + 1}. {hoten}\n" +
                                      $"- Giới tính: {gioiTinh}\n" +
                                      $"- Ngày sinh: {ngaysinh}\n" +
                                      $"- Khoa: {khoa}\n";

            listBoxSinhVien.Items.Add(thongTinSinhVien);

            btName.Clear();
            rbMale.Checked = true;
            cb_Faculty.SelectedIndex = -1;
        }

        private void listBoxSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
