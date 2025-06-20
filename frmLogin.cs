using System;
using System.Windows.Forms;

// ĐẢM BẢO KHÔNG CÓ DÒNG "using Guna.UI2.WinForms;" Ở ĐÂY

namespace QL_TOUR
{
    public partial class frmLogin : Form
    {
        User_BLL bllUser;
        public frmLogin()
        {
            InitializeComponent();
            bllUser = new User_BLL();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // Sử dụng ký tự hình tròn đặc để che mật khẩu
            txtMK.PasswordChar = '\u25CF';
        }

        private void AttemptLogin()
        {
            if (string.IsNullOrEmpty(txtTenDN.Text) || string.IsNullOrEmpty(txtMK.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tbl_User user = new tbl_User();
            user.UserName = txtTenDN.Text;
            user.Password = txtMK.Text;

            string quyen = bllUser.PhQuyen(user);

            if (quyen == "Admin")
            {
                frmMainn mainFrm = new frmMainn();
                mainFrm.lblXinChao.Text = "Xin chào: " + txtTenDN.Text;
                mainFrm.Show();
                this.Hide();
            }
            else if (quyen == "User")
            {
                frmMainn mainFrm = new frmMainn();
                mainFrm.lblXinChao.Text = "Xin chào: " + txtTenDN.Text;
                mainFrm.btnQLTT.Enabled = false; // Vô hiệu hóa nút quản lý thông tin cho User
                mainFrm.Show();
                this.Hide();
            }
            else // "Fail"
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtMK.PasswordChar = '\0'; // Hiện mật khẩu
            }
            else
            {
                txtMK.PasswordChar = '\u25CF'; // Che mật khẩu
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AttemptLogin();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}