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
    public partial class frmThongTin : Form
    {
        DiemDL_BLL bllDDL;
        DiemDi_BLL bllDDi;
        PhuongTien_BLL bllPT;
        LLT_BLL bllLLT;
        LoaiKS_BLL bllLKS;
        KhachSan_BLL bllKS;
        LoaiTour_BLL bllLoaiTour;

        public frmThongTin()
        {
            InitializeComponent();
            bllDDL = new DiemDL_BLL();
            bllPT = new PhuongTien_BLL();
            bllLLT = new LLT_BLL();
            bllLKS = new LoaiKS_BLL();
            bllKS = new KhachSan_BLL();
            bllLoaiTour = new LoaiTour_BLL();
            bllDDi = new DiemDi_BLL();
        }

        private void frmThongTin_Load(object sender, EventArgs e)
        {
            // Load data for all sections
            ShowAllDDi();
            ShowAllDDL();
            ShowAllPhuongTien();
            ShowAllLoaiLuaTuoi();
            ShowAllLoaiKhachSan();
            ShowAllKhachSan();

            // Load ComboBoxes
            DataTable dtLoaiTour1 = bllLoaiTour.GetAllLTour();
            DataTable dtLoaiTour2 = dtLoaiTour1.Copy();

            cmbLTDKH.ValueMember = "MaLTour";
            cmbLTDKH.DisplayMember = "TenLTour";
            cmbLTDKH.DataSource = dtLoaiTour1;

            cmbLTDDL.ValueMember = "MaLTour";
            cmbLTDDL.DisplayMember = "TenLTour";
            cmbLTDDL.DataSource = dtLoaiTour2;

            cmbLoaiKS.ValueMember = "MaLKS";
            cmbLoaiKS.DisplayMember = "TenLKS";
            cmbLoaiKS.DataSource = bllLKS.GetAllLoaiKhachSan();

            // Auto generate ID for new entries
            GenerateNewMaDDL();
        }

        #region Điểm khởi hành
        private void ShowAllDDi()
        {
            DataTable dataTable = bllDDi.GetAllDDiTrongNc();
            dgvDDI.DataSource = dataTable;
        }

        private bool CheckDataDDi()
        {
            if (string.IsNullOrEmpty(txtMaDKH.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã điểm khởi hành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaDKH.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTenDKH.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên điểm khởi hành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenDKH.Focus();
                return false;
            }
            return true;
        }
        private void btnResetDKH_Click(object sender, EventArgs e)
        {
            txtMaDKH.Clear();
            txtMaDKH.Enabled = true;
            txtTenDKH.Clear();
            if (cmbLTDKH.Items.Count > 0) cmbLTDKH.SelectedIndex = 0;
        }

        private void cmbLTDKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLTDKH.SelectedValue == null) return;
            tbl_DiemDi DDI = new tbl_DiemDi();
            DDI.MaLTour = cmbLTDKH.SelectedValue.ToString();
            dgvDDI.DataSource = bllDDi.GetAllDDi(DDI);
        }

        private void btnThemDDI_Click(object sender, EventArgs e)
        {
            if (CheckDataDDi())
            {
                tbl_DiemDi dd = new tbl_DiemDi();
                dd.MaDDI = txtMaDKH.Text;
                dd.TenDDI = txtTenDKH.Text;
                dd.MaLTour = cmbLTDKH.SelectedValue.ToString();
                if (bllDDi.InsertDDi(dd))
                    ShowAllDDi();
                else
                    MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void dgvDDI_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtMaDKH.Enabled = false;
            txtMaDKH.Text = dgvDDI.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value.ToString();
            txtTenDKH.Text = dgvDDI.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value.ToString();
            cmbLTDKH.Text = dgvDDI.Rows[e.RowIndex].Cells["Column15"].Value.ToString();
        }

        private void btnSuaDDi_Click(object sender, EventArgs e)
        {
            if (CheckDataDDi())
            {
                tbl_DiemDi dd = new tbl_DiemDi();
                dd.MaDDI = txtMaDKH.Text;
                dd.TenDDI = txtTenDKH.Text;
                dd.MaLTour = cmbLTDKH.SelectedValue.ToString();
                if (bllDDi.UpdateDDi(dd))
                    ShowAllDDi();
                else
                    MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnXoaDDi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tbl_DiemDi dd = new tbl_DiemDi();
                dd.MaDDI = txtMaDKH.Text;
                if (bllDDi.DeleteDDi(dd))
                    ShowAllDDi();
                else
                    MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        #endregion

        #region Điểm du lịch
        private void ShowAllDDL()
        {
            DataTable dataTable = bllDDL.GetAllDDLTrongNc();
            dgvDDL.DataSource = dataTable;
        }

        private void cmbLTDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLTDDL.SelectedValue == null) return;
            tbl_DiemDL DDL = new tbl_DiemDL();
            DDL.MaLTour = cmbLTDDL.SelectedValue.ToString();
            dgvDDL.DataSource = bllDDL.GetAllDDL(DDL);
        }

        private bool CheckDataDDL()
        {
            if (string.IsNullOrEmpty(txtMaDDL.Text))
            {
                MessageBox.Show("Chưa nhập mã điểm du lịch!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaDDL.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTenDDL.Text))
            {
                MessageBox.Show("Chưa nhập tên điểm du lịch!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenDDL.Focus();
                return false;
            }
            return true;
        }

        private void GenerateNewMaDDL()
        {
            int count = bllDDL.GetSLDDL() + 1;
            string DDL = (count < 10) ? "DDL0" + count : "DDL" + count;
            txtMaDDL.Text = DDL;
        }

        private void btnResetDDL_Click(object sender, EventArgs e)
        {
            txtMaDDL.Enabled = true;
            GenerateNewMaDDL();
            txtTenDDL.Clear();
            if (cmbLTDDL.Items.Count > 0) cmbLTDDL.SelectedIndex = 0;
        }

        private void btnThemDDL_Click(object sender, EventArgs e)
        {
            if (CheckDataDDL())
            {
                tbl_DiemDL ddl = new tbl_DiemDL();
                ddl.MaDDen = txtMaDDL.Text;
                ddl.TenDDen = txtTenDDL.Text;
                ddl.MaLTour = cmbLTDDL.SelectedValue.ToString();
                if (bllDDL.InsertDDL(ddl))
                {
                    ShowAllDDL();
                    btnResetDDL_Click(sender, e); // Reset for next entry
                }
                else
                    MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void dgvDDL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtMaDDL.Enabled = false;
            txtMaDDL.Text = dgvDDL.Rows[e.RowIndex].Cells["Column8"].Value.ToString();
            txtTenDDL.Text = dgvDDL.Rows[e.RowIndex].Cells["Column9"].Value.ToString();
            cmbLTDDL.Text = dgvDDL.Rows[e.RowIndex].Cells["Column16"].Value.ToString();
        }

        private void btnSuaDDL_Click(object sender, EventArgs e)
        {
            if (CheckDataDDL())
            {
                tbl_DiemDL ddl = new tbl_DiemDL();
                ddl.MaDDen = txtMaDDL.Text;
                ddl.TenDDen = txtTenDDL.Text;
                ddl.MaLTour = cmbLTDDL.SelectedValue.ToString();
                if (bllDDL.UpdateDDL(ddl))
                {
                    ShowAllDDL();
                    btnResetDDL_Click(sender, e);
                }
                else
                    MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnXoaDDL_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tbl_DiemDL ddl = new tbl_DiemDL();
                ddl.MaDDen = txtMaDDL.Text;
                if (bllDDL.DeleteDDL(ddl))
                {
                    ShowAllDDL();
                    btnResetDDL_Click(sender, e);
                }
                else
                    MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        #endregion

        #region Phương tiện
        public void ShowAllPhuongTien()
        {
            dgvPT.DataSource = bllPT.GetAllPhuongTien();
        }

        public bool CheckDataPT()
        {
            if (string.IsNullOrEmpty(txtMaPT.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã phương tiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaPT.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTenPT.Text))
            {
                MessageBox.Show("Bạn chưa nhập phương tiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenPT.Focus();
                return false;
            }
            return true;
        }

        private void btnResetPT_Click(object sender, EventArgs e)
        {
            txtMaPT.Clear();
            txtMaPT.Enabled = true;
            txtTenPT.Clear();
        }

        private void btnThemPT_Click(object sender, EventArgs e)
        {
            if (CheckDataPT())
            {
                tbl_PhuongTien pt = new tbl_PhuongTien();
                pt.MaPT = txtMaPT.Text;
                pt.TenPT = txtTenPT.Text;
                if (bllPT.InsertPhuongTien(pt))
                    ShowAllPhuongTien();
                else
                    MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnSuaPT_Click(object sender, EventArgs e)
        {
            if (CheckDataPT())
            {
                tbl_PhuongTien pt = new tbl_PhuongTien();
                pt.MaPT = txtMaPT.Text;
                pt.TenPT = txtTenPT.Text;
                if (bllPT.UpdatePhuongTien(pt))
                    ShowAllPhuongTien();
                else
                    MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnXoaPT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tbl_PhuongTien pt = new tbl_PhuongTien();
                pt.MaPT = txtMaPT.Text;
                if (bllPT.DeletePhuongTien(pt))
                    ShowAllPhuongTien();
                else
                    MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void dgvPT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtMaPT.Enabled = false;
            txtMaPT.Text = dgvPT.Rows[e.RowIndex].Cells["Column10"].Value.ToString();
            txtTenPT.Text = dgvPT.Rows[e.RowIndex].Cells["Column11"].Value.ToString();
        }
        #endregion

        #region Loại lứa tuổi
        public void ShowAllLoaiLuaTuoi()
        {
            dgvLLT.DataSource = bllLLT.GetAllLLT();
        }

        private void btnResetLLT_Click(object sender, EventArgs e)
        {
            txtMaLLT.Clear();
            txtMaLLT.Enabled = true;
            txtTenLLT.Clear();
            txtGiaLLT.Clear();
        }

        public bool CheckDataLLT()
        {
            if (string.IsNullOrEmpty(txtMaLLT.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã loại lứa tuổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaLLT.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTenLLT.Text))
            {
                MessageBox.Show("Bạn chưa nhập lứa tuổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenLLT.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtGiaLLT.Text))
            {
                MessageBox.Show("Bạn chưa nhập giá loại lứa tuổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiaLLT.Focus();
                return false;
            }
            return true;
        }

        private void btnThemLLT_Click(object sender, EventArgs e)
        {
            if (CheckDataLLT())
            {
                tbl_LoaiLT llt = new tbl_LoaiLT();
                llt.MaLLT = txtMaLLT.Text;
                llt.TenLLT = txtTenLLT.Text;
                llt.GiaTienLLT = Convert.ToDecimal(txtGiaLLT.Text);
                if (bllLLT.InsertLoaiLuaTuoi(llt))
                    ShowAllLoaiLuaTuoi();
                else
                    MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnSuaLLT_Click(object sender, EventArgs e)
        {
            if (CheckDataLLT())
            {
                tbl_LoaiLT llt = new tbl_LoaiLT();
                llt.MaLLT = txtMaLLT.Text;
                llt.TenLLT = txtTenLLT.Text;
                llt.GiaTienLLT = Convert.ToDecimal(txtGiaLLT.Text);
                if (bllLLT.UpdateLoaiLuaTuoi(llt))
                    ShowAllLoaiLuaTuoi();
                else
                    MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnXoaLLT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tbl_LoaiLT llt = new tbl_LoaiLT();
                llt.MaLLT = txtMaLLT.Text;
                if (bllLLT.DeleteLoaiLuaTuoi(llt))
                    ShowAllLoaiLuaTuoi();
                else
                    MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void dgvLLT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtMaLLT.Enabled = false;
            txtMaLLT.Text = dgvLLT.Rows[e.RowIndex].Cells["Column12"].Value.ToString();
            txtTenLLT.Text = dgvLLT.Rows[e.RowIndex].Cells["Column13"].Value.ToString();
            txtGiaLLT.Text = dgvLLT.Rows[e.RowIndex].Cells["Column14"].Value.ToString();
        }
        #endregion

        #region Loại khách sạn
        public void ShowAllLoaiKhachSan()
        {
            dgvLKS.DataSource = bllLKS.GetAllLoaiKhachSan();
        }

        private void btnResetLKS_Click(object sender, EventArgs e)
        {
            txtMaLKS.Clear();
            txtMaLKS.Enabled = true;
            txtTenLKS.Clear();
        }

        public bool CheckDataLKS()
        {
            if (string.IsNullOrEmpty(txtMaLKS.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã loại khách sạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaLKS.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTenLKS.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên loại khách sạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenLKS.Focus();
                return false;
            }
            return true;
        }

        private void btnThemLKS_Click(object sender, EventArgs e)
        {
            if (CheckDataLKS())
            {
                tbl_LoaiKS lks = new tbl_LoaiKS();
                lks.MALKS = txtMaLKS.Text;
                lks.TENLKS = txtTenLKS.Text;
                if (bllLKS.InsertLoaiKhachSan(lks))
                    ShowAllLoaiKhachSan();
                else
                    MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnSuaLKS_Click(object sender, EventArgs e)
        {
            if (CheckDataLKS())
            {
                tbl_LoaiKS lks = new tbl_LoaiKS();
                lks.MALKS = txtMaLKS.Text;
                lks.TENLKS = txtTenLKS.Text;
                if (bllLKS.UpdateLoaiKhachSan(lks))
                    ShowAllLoaiKhachSan();
                else
                    MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnXoaLKS_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tbl_LoaiKS lks = new tbl_LoaiKS();
                lks.MALKS = txtMaLKS.Text;
                if (bllLKS.DeleteLoaiKhachSan(lks))
                    ShowAllLoaiKhachSan();
                else
                    MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void dgvLKS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtMaLKS.Enabled = false;
            txtMaLKS.Text = dgvLKS.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
            txtTenLKS.Text = dgvLKS.Rows[e.RowIndex].Cells["Column2"].Value.ToString();
        }
        #endregion

        #region Khách sạn
        public void ShowAllKhachSan()
        {
            dgvKS.DataSource = bllKS.GetAllKhachSan();
        }

        private void btnResetKS_Click(object sender, EventArgs e)
        {
            txtMaKS.Clear();
            txtMaKS.Enabled = true;
            txtTenKS.Clear();
            txtDiaChiKS.Clear();
            txtGiaKS.Clear();
            if (cmbLoaiKS.Items.Count > 0) cmbLoaiKS.SelectedIndex = 0;
        }

        public bool CheckDataKhachSan()
        {
            if (string.IsNullOrEmpty(txtMaKS.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã Khách sạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKS.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTenKS.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên khách sạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKS.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtGiaKS.Text))
            {
                MessageBox.Show("Bạn chưa nhập giá khách sạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiaKS.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDiaChiKS.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ khách sạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChiKS.Focus();
                return false;
            }
            return true;
        }

        private void btnThemKS_Click(object sender, EventArgs e)
        {
            if (CheckDataKhachSan())
            {
                tbl_KhachSan ks = new tbl_KhachSan();
                ks.MAKS = txtMaKS.Text;
                ks.TENKS = txtTenKS.Text;
                ks.GIAKS = txtGiaKS.Text;
                ks.DIACHI = txtDiaChiKS.Text;
                ks.MALKS = cmbLoaiKS.SelectedValue.ToString();
                if (bllKS.InsertKhachSan(ks))
                    ShowAllKhachSan();
                else
                    MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnSuaKS_Click(object sender, EventArgs e)
        {
            if (CheckDataKhachSan())
            {
                tbl_KhachSan ks = new tbl_KhachSan();
                ks.MAKS = txtMaKS.Text;
                ks.TENKS = txtTenKS.Text;
                ks.GIAKS = txtGiaKS.Text;
                ks.DIACHI = txtDiaChiKS.Text;
                ks.MALKS = cmbLoaiKS.SelectedValue.ToString();
                if (bllKS.UpdateKhachSan(ks))
                    ShowAllKhachSan();
                else
                    MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnXoaKS_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tbl_KhachSan ks = new tbl_KhachSan();
                ks.MAKS = txtMaKS.Text;
                if (bllKS.DeleteKhachSan(ks))
                    ShowAllKhachSan();
                else
                    MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void dgvKS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtMaKS.Enabled = false;
            txtMaKS.Text = dgvKS.Rows[e.RowIndex].Cells["Column3"].Value.ToString();
            txtTenKS.Text = dgvKS.Rows[e.RowIndex].Cells["Column4"].Value.ToString();
            txtGiaKS.Text = dgvKS.Rows[e.RowIndex].Cells["Column5"].Value.ToString();
            txtDiaChiKS.Text = dgvKS.Rows[e.RowIndex].Cells["Column6"].Value.ToString();
            cmbLoaiKS.Text = dgvKS.Rows[e.RowIndex].Cells["Column7"].Value.ToString();
        }

        private void txtGiaKS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}