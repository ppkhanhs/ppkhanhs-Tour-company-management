using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace QL_TOUR
{
    public partial class frmKhachHang : Form
    {
        KhachHang_BLL bllKH;
        public frmKhachHang()
        {
            InitializeComponent();
            bllKH = new KhachHang_BLL();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public void ShowAllKH()
        {
            DataTable dataTable = bllKH.GetAllKH();
            dgvKH.DataSource = dataTable;
        }

        private bool checkData()
        {
            string notice = "";

            if (string.IsNullOrEmpty(txtSDT.Text))
            {
                notice += "Chưa nhập số điện thoại\n";
                txtSDT.Focus();
            }

            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                notice += "Chưa nhập địa chỉ\n";
                txtDiaChi.Focus();
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                notice += "Chưa nhập Email\n";
                txtEmail.Focus();
            }

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(txtEmail.Text, pattern))
            {
                notice += "Nhập sai định dạng Email\n";
                txtEmail.Focus();
            }

            if (string.IsNullOrEmpty(txtTenKH.Text))
            {
                notice += "Chưa nhập tên\n";
                txtTenKH.Focus();
            }

            if (!string.IsNullOrEmpty(notice))
            {
                MessageBox.Show(notice, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                tbl_KhachHang KhachHang = new tbl_KhachHang();
                KhachHang.MaKH = txtMaKH.Text;
                KhachHang.TenKH = txtTenKH.Text;
                KhachHang.SDT = txtSDT.Text;
                KhachHang.DiaChi = txtDiaChi.Text;
                KhachHang.Email = txtEmail.Text;

                if (bllKH.UpdateKhachHang(KhachHang))
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllKH();
                }

                else
                {
                    MessageBox.Show("Lỗi! Không thể cập nhật khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtMaKH.Focus();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKH.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tbl_KhachHang KhachHang = new tbl_KhachHang();
                KhachHang.MaKH = dgvKH.SelectedRows[0].Cells[0].Value.ToString();

                if (bllKH.DeleteKhachHang(KhachHang))
                {
                    btnXoa.Enabled = false;
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllKH();
                }

                else
                    MessageBox.Show("Đã có lỗi xảy ra! Không thể xóa khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            ShowAllKH();
            btnXoa.Visible = true;
            btnXoa.Enabled = false;
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnXoa.Enabled = true;
                DataGridViewRow row = dgvKH.Rows[e.RowIndex];

                txtMaKH.Text = row.Cells["Column1"].Value.ToString();
                txtTenKH.Text = row.Cells["Column2"].Value.ToString();
                txtSDT.Text = row.Cells["Column3"].Value.ToString();
                txtEmail.Text = row.Cells["Column4"].Value.ToString();
                txtDiaChi.Text = row.Cells["Column5"].Value.ToString();

                txtMaKH.Enabled = false;
            }
        }
    }
}