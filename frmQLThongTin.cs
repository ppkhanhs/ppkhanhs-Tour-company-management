using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace QL_TOUR
{
    public partial class frmQLThongTin : Form
    {
        public frmQLThongTin()
        {
            InitializeComponent();
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

        private void frmQLThongTin_Load(object sender, EventArgs e)
        {
            frmTour_Click(sender, e);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            openChildForm(new frmNhanVien());
        }

        private void btnQLDV_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThongTin());
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            openChildForm(new frmKhachHang());
        }

        private void frmTour_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTour());
        }

        private void frmQLThongTin_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMainn Main = new frmMainn();
            Main.Show();
        }
    }
}