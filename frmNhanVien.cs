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
    public partial class frmNhanVien : Form
    {
        NhanVien_BLL bllNV;
        public frmNhanVien()
        {
            InitializeComponent();
            bllNV = new NhanVien_BLL();
        }

        public void ShowAllNhanVien()
        {
            DataTable dataTable = bllNV.GetAllNhanVien();
            DataGridViewNhanVien.DataSource = dataTable;
        }

        public bool CheckDataNV()
        {
            if (string.IsNullOrEmpty(txtMANV.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMANV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTENNV.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTENNV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDT.Focus();
                return false;
            }

            if ((dtpNGVL.Value.Year - dtpNGSINH.Value.Year) < 18)
            {
                MessageBox.Show("Nhân viên phải đủ 18 tuổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(txtCMND_CCCD.Text))
            {
                MessageBox.Show("Bạn chưa nhập CMND/CCCD.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCMND_CCCD.Focus();
                return false;
            }
            return true;
        }

        void OpenBox()
        {
            txtTENNV.ReadOnly = false;
            dtpNGSINH.Enabled = true;
            txtSDT.ReadOnly = false;
            txtCMND_CCCD.ReadOnly = false;
            dtpNGVL.Enabled = true;
        }

        void CloseBox()
        {
            txtMANV.ReadOnly = true;
            txtTENNV.ReadOnly = true;
            dtpNGSINH.Enabled = false;
            txtSDT.ReadOnly = true;
            txtCMND_CCCD.ReadOnly = true;
            dtpNGVL.Enabled = false;
        }

        void ResetBox()
        {
            txtMANV.Clear();
            txtTENNV.Clear();
            dtpNGSINH.Value = DateTime.Now;
            txtSDT.Clear();
            txtCMND_CCCD.Clear();
            dtpNGVL.Value = DateTime.Now;
        }

        bool checkThemSua = false;

        private void btnThem_Click(object sender, EventArgs e)
        {
            checkThemSua = true;
            ResetBox();
            OpenBox();

            string MaNV;
            int count = bllNV.GetSLNV() + 1;
            if (count < 10)
                MaNV = "NV0" + count.ToString();
            else
                MaNV = "NV" + count.ToString();
            txtMANV.Text = MaNV;

            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnTroVe.Enabled = true;
            btnThem.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!CheckDataNV()) return;

            tbl_NhanVien nv = new tbl_NhanVien();
            nv.MANV = txtMANV.Text;
            nv.TENNV = txtTENNV.Text;
            nv.NGSINH = dtpNGSINH.Value;
            nv.SDT = txtSDT.Text;
            nv.CMND_CCCD = txtCMND_CCCD.Text;
            nv.NGVL = dtpNGVL.Value;

            if (checkThemSua)
            {
                if (bllNV.InsertNhanVien(nv))
                {
                    ShowAllNhanVien();
                    CloseBox();
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLuu.Enabled = false;
                    btnThem.Enabled = true;
                    btnTroVe.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtTENNV.Focus();
                }
            }
            else
            {
                if (bllNV.UpdateNhanVien(nv))
                {
                    ShowAllNhanVien();
                    CloseBox();
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLuu.Enabled = false;
                    btnThem.Enabled = true;
                    btnSua.Enabled = false;
                    btnTroVe.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtTENNV.Focus();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            checkThemSua = false;
            OpenBox();

            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnTroVe.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMANV.Text))
            {
                MessageBox.Show("Chưa chọn nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa nhân viên này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tbl_NhanVien nv = new tbl_NhanVien();
                nv.MANV = txtMANV.Text;
                if (bllNV.DeleteNhanVien(nv))
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllNhanVien();
                    ResetBox();
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy thao tác đang thực hiện?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ResetBox();
                CloseBox();
                btnThem.Enabled = true;
                btnLuu.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnTroVe.Enabled = false;
            }
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            ShowAllNhanVien();
            CloseBox();
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnTroVe.Enabled = false;
        }

        private void DataGridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                CloseBox();

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnLuu.Enabled = false;
                btnXoa.Enabled = true;
                btnTroVe.Enabled = false;

                DataGridViewRow row = DataGridViewNhanVien.Rows[e.RowIndex];
                txtMANV.Text = row.Cells["Column1"].Value.ToString();
                txtTENNV.Text = row.Cells["Column2"].Value.ToString();
                dtpNGSINH.Value = Convert.ToDateTime(row.Cells["Column3"].Value);
                txtSDT.Text = row.Cells["Column4"].Value.ToString();
                txtCMND_CCCD.Text = row.Cells["Column5"].Value.ToString();
                dtpNGVL.Value = Convert.ToDateTime(row.Cells["Column6"].Value);
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCMND_CCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}