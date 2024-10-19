using System;
using System.Windows.Forms;

namespace NguyenHoangPhuc
{
    public partial class Login : Form
    {
        private string correctUsername = "phuc";
        private string correctPassword = "1111";
        private bool isPasswordShown = false;

        private Label lblTitle;

        public Login()
        {
            InitializeComponent();

            // Thiết lập cho Label tiêu đề
            lblTitle = new Label();
            lblTitle.Text = "Đăng Nhập";
            lblTitle.Font = new Font("Arial", 18, FontStyle.Bold);
            lblTitle.AutoSize = true;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // Đặt vị trí tạm thời của Label lên trên cùng
            lblTitle.Location = new Point(0, 20);

            // Thêm Label vào form
            this.Controls.Add(lblTitle);

            // Thiết lập TextBox cho mật khẩu
            tbPassword.PasswordChar = '*';

            // Đăng ký sự kiện load form để căn giữa chữ
            this.Load += new EventHandler(Login_Load);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Căn giữa Label theo chiều ngang sau khi form được load
            lblTitle.Left = (this.ClientSize.Width - lblTitle.Width) / 2;
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            // Lấy giá trị người dùng nhập
            string enteredUsername = tbUsername.Text;
            string enteredPassword = tbPassword.Text;  // Đúng phải lấy từ tbPassword

            // Kiểm tra tài khoản và mật khẩu
            if (enteredUsername == correctUsername && enteredPassword == correctPassword)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo");

                // Ẩn form đăng nhập hiện tại
                this.Hide();

                // Mở form Menu
                Home homeForm = new Home();
                homeForm.ShowDialog();

                // Sau khi form Menu đóng, đóng luôn form Login
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu.", "Lỗi");
            }
        }
    }
}
