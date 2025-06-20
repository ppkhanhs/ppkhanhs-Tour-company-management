using QL_TOUR;
using System;
using System.Drawing;
using System.Windows.Forms;

// ĐẢM BẢO KHÔNG CÓ DÒNG "using Guna.UI2.WinForms;" Ở ĐÂY

namespace QL_TOUR
{
    public partial class frmMainn : Form
    {
        private Button currentButton;
        private Color activeBackColor = Color.FromArgb(255, 196, 54);
        private Color activeForeColor = Color.White;
        private Color inactiveBackColor = Color.FromArgb(1, 116, 190);
        private Color inactiveForeColor = Color.White;

        public frmMainn()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton(); // Deactivate the previous button
                currentButton = (Button)senderBtn;
                currentButton.BackColor = activeBackColor;
                currentButton.ForeColor = activeForeColor;
            }
        }

        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = inactiveBackColor;
                currentButton.ForeColor = inactiveForeColor;
            }
        }

        private void frmMainn_Load(object sender, EventArgs e)
        {
            // Mở form Home mặc định khi khởi động và kích hoạt nút Trang chủ
            btnTrangChu_Click_1(btnTrangChu, e);
        }

        private void btnTrangChu_Click_1(object sender, EventArgs e)
        {
            this.Size = new Size(1218, 933);
            panelChildForm.Size = new Size(1192, 785);
            this.CenterToScreen();
            ActivateButton(sender);
            openChildForm(new frmHome());
        }

        private void btnTour_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1218, 933);
            panelChildForm.Size = new Size(1192, 785);
            this.CenterToScreen();
            ActivateButton(sender);
            openChildForm(new frmDatTour());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1218, 700);
            panelChildForm.Size = new Size(1192, 552);
            this.CenterToScreen();
            ActivateButton(sender);
            openChildForm(new frmHoaDon());
        }

        private void btnQLTT_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQLThongTin QLTT = new frmQLThongTin();
            QLTT.ShowDialog();
            this.Show(); // Hiển thị lại form Main sau khi form QLTT đóng
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin LoginFrm = new frmLogin();
            LoginFrm.ShowDialog();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}