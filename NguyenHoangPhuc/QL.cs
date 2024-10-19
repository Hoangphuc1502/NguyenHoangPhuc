using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace NguyenHoangPhuc
{
    public partial class QL : Form
    {
        BindingList<HocSinh> dsHocSinh = new BindingList<HocSinh>();  // Thay List bằng BindingList
        public QL()
        {
            InitializeComponent();
            dgvHocSinh.AutoGenerateColumns = true;

            // Gán BindingList trực tiếp vào DataSource
            dgvHocSinh.DataSource = dsHocSinh;

            // Liên kết sự kiện cho các nút
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
        }

        private void ClearTextBoxes()
        {
            txtEmail.Text = "";
            txtMaHS.Text = "";
            txtSoDT.Text = "";
            txtHoTen.Text = "";
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu Mã học sinh đã được nhập
            if (string.IsNullOrWhiteSpace(txtMaHS.Text))
            {
                MessageBox.Show("Vui lòng nhập mã học sinh.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra nếu mã học sinh đã tồn tại trong danh sách
            bool isDuplicate = dsHocSinh.Any(hs => hs.MaHS == txtMaHS.Text);

            if (isDuplicate)
            {
                MessageBox.Show("Mã học sinh đã tồn tại! Vui lòng nhập mã khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Tạo một đối tượng học sinh mới
                HocSinh hs = new HocSinh
                {
                    MaHS = txtMaHS.Text,
                    HoTen = txtHoTen.Text,
                    Email = txtEmail.Text,
                    SoDT = txtSoDT.Text
                };

                // Thêm học sinh vào danh sách
                dsHocSinh.Add(hs);  // Thêm trực tiếp vào BindingList

                // Xóa các ô nhập liệu
                ClearTextBoxes();
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            bool found = false;
            foreach (HocSinh hs in dsHocSinh)
            {
                if (hs.MaHS == txtMaHS.Text)
                {
                    hs.HoTen = txtHoTen.Text;
                    hs.Email = txtEmail.Text;
                    hs.SoDT = txtSoDT.Text;
                    found = true;  // Đánh dấu là đã tìm thấy học sinh
                    break;
                }
            }

            if (found)
            {
                dgvHocSinh.Refresh();  // Cập nhật lại DataGridView
                ClearTextBoxes();    // Xóa các ô nhập
            }
            else
            {
                MessageBox.Show("Không tìm thấy học sinh với mã này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            HocSinh hsToDelete = dsHocSinh.FirstOrDefault(hs => hs.MaHS == txtMaHS.Text);
            if (hsToDelete != null)
            {
                dsHocSinh.Remove(hsToDelete);  // Xóa học sinh khỏi BindingList
                ClearTextBoxes();
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void QL_Load(object sender, EventArgs e)
        {

        }

        private void txtMaHS_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class HocSinh
    {
        public string MaHS { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
        public string SoDT { get; set; }
    }
}
