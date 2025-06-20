using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

// ĐẢM BẢO KHÔNG CÓ DÒNG "using Guna.UI2.WinForms;" Ở ĐÂY

namespace QL_TOUR
{
    public partial class frmTour : Form
    {
        Tour_BLL bllTour;
        LoaiKS_BLL bllLT;
        LoaiTour_BLL bllLoaiTour;
        PhuongTien_BLL bllPhuongTien;
        DiemDi_BLL bllDiemDi;
        DiemDL_BLL bllDiemDen;
        LoaiKS_BLL bllLKS;

        public frmTour()
        {
            InitializeComponent();
            bllTour = new Tour_BLL();
            bllLT = new LoaiKS_BLL();
            bllLoaiTour = new LoaiTour_BLL();
            bllPhuongTien = new PhuongTien_BLL();
            bllDiemDi = new DiemDi_BLL();
            bllDiemDen = new DiemDL_BLL();
            bllLKS = new LoaiKS_BLL();
        }

        private void frmTour_Load(object sender, EventArgs e)
        {
            loadcmb();
            CloseBox();
            ShowAllTour();
            ResetInf();
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        #region Control State Management
        void ResetBox()
        {
            txtMaTour.Clear();
            txtTenTour.Clear();
            txtMoTa.Clear();
            numSL.Value = 0;
            dtpNgayDi.Value = DateTime.Now;
            dtpNgayKT.Value = DateTime.Now;
            if (cmbLoaiTour.Items.Count > 0) cmbLoaiTour.SelectedIndex = 0;
            if (cmbPT.Items.Count > 0) cmbPT.SelectedIndex = 0;
            if (cmbDiemDi.Items.Count > 0) cmbDiemDi.SelectedIndex = 0;
            if (cmbKS.Items.Count > 0) cmbKS.SelectedIndex = 0;
            txtGiaTour.Clear();
            imgLocation1 = null;
            imgLocation2 = null;
            imgLocation3 = null;
            imgLocation4 = null;
            picHinh1.Image = null;
            picHinh2.Image = null;
            picHinh3.Image = null;
            picHinh4.Image = null;
        }

        void OpenBox()
        {
            txtTenTour.ReadOnly = false;
            txtMoTa.ReadOnly = false;
            numSL.Enabled = true;
            dtpNgayDi.Enabled = true;
            dtpNgayKT.Enabled = true;
            cmbLoaiTour.Enabled = true;
            cmbPT.Enabled = true;
            cmbDiemDi.Enabled = true;
            cmbDDen.Enabled = true;
            cmbKS.Enabled = true;
            txtGiaTour.Enabled = true;
            btnAnh1.Enabled = true;
            btnHinh2.Enabled = true;
            btnHinh3.Enabled = true;
            btnHinh4.Enabled = true;
        }

        void CloseBox()
        {
            txtTenTour.ReadOnly = true;
            txtMoTa.ReadOnly = true;
            numSL.Enabled = false;
            dtpNgayDi.Enabled = false;
            dtpNgayKT.Enabled = false;
            cmbLoaiTour.Enabled = false;
            cmbPT.Enabled = false;
            cmbDiemDi.Enabled = false;
            cmbKS.Enabled = false;
            cmbDDen.Enabled = false;
            txtGiaTour.ReadOnly = true;
            btnAnh1.Enabled = false;
            btnHinh2.Enabled = false;
            btnHinh3.Enabled = false;
            btnHinh4.Enabled = false;
        }

        void ResetInf()
        {
            lblTenTour.Text = "Tên Tour";
            lblMoTa.Text = "Mô tả";
            lblGiaTour.Text = "Giá Tour";
            picHinh1.Image = null;
            picHinh2.Image = null;
            picHinh3.Image = null;
            picHinh4.Image = null;
            lblTGKH.Text = "TG khởi hành";
            lblNoiKH.Text = "Nơi khởi hành";
            lblSoNgay.Text = "Số ngày";
            lblSlot.Text = "Số lượng";
            lblTGnho.Text = "Thời gian";
            lblPT.Text = "Phương tiện";
            lblDiemDen.Text = "Điểm đến";
            lblKS.Text = "Khách sạn";
            lblMaTour.Text = "Mã Tour";
        }
        #endregion

        #region Data Validation
        private bool checkData(bool isNew)
        {
            string notice = "";
            if (string.IsNullOrEmpty(txtTenTour.Text)) notice += "\nChưa nhập tên Tour!";
            if (string.IsNullOrEmpty(txtMoTa.Text)) notice += "\nChưa nhập mô tả!";
            if (numSL.Value == 0) notice += "\nSố lượng phải lớn hơn 0!";
            if (string.IsNullOrEmpty(txtGiaTour.Text)) notice += "\nChưa nhập giá Tour!";
            if (dtpNgayKT.Value.Date <= dtpNgayDi.Value.Date) notice += "\nNgày kết thúc phải lớn hơn ngày khởi hành!";

            if (isNew) // Only check for new images when adding a new tour
            {
                if (imgLocation1 == null) notice += "\nChưa thêm ảnh 1!";
                if (imgLocation2 == null) notice += "\nChưa thêm ảnh 2!";
                if (imgLocation3 == null) notice += "\nChưa thêm ảnh 3!";
                if (imgLocation4 == null) notice += "\nChưa thêm ảnh 4!";
            }

            if (!string.IsNullOrEmpty(notice))
            {
                MessageBox.Show(notice.Trim(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        #endregion

        #region CRUD Buttons
        bool checkThemSua = false; // true = Thêm, false = Sửa
        private void btnThem_Click(object sender, EventArgs e)
        {
            checkThemSua = true;
            ResetBox();
            ResetInf();
            OpenBox();

            int nextId = bllTour.GetMaTour() + 1;
            txtMaTour.Text = "T" + nextId.ToString("D2");

            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTour.Text))
            {
                MessageBox.Show("Vui lòng chọn một tour để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            checkThemSua = false;
            OpenBox();
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!checkData(checkThemSua)) return;

            tbl_Tour tour = new tbl_Tour();
            tour.MaTour = txtMaTour.Text;
            tour.TenTour = txtTenTour.Text;
            tour.MoTa = txtMoTa.Text;
            tour.SoLuongConLai = Convert.ToInt32(numSL.Value);
            tour.NgayDiTour = dtpNgayDi.Value;
            tour.NgayKetThuc = dtpNgayKT.Value;
            tour.GiaTour = Convert.ToDecimal(txtGiaTour.Text);
            tour.MaLTour = cmbLoaiTour.SelectedValue.ToString();
            tour.MaPT = cmbPT.SelectedValue.ToString();
            tour.MaDDi = cmbDiemDi.SelectedValue.ToString();
            tour.MaDDen = cmbDDen.SelectedValue.ToString();
            tour.MaLKS = cmbKS.SelectedValue.ToString();

            // Handle images
            tour.Anh1 = GetImageData(imgLocation1, picHinh1);
            tour.Anh2 = GetImageData(imgLocation2, picHinh2);
            tour.Anh3 = GetImageData(imgLocation3, picHinh3);
            tour.Anh4 = GetImageData(imgLocation4, picHinh4);

            bool result = false;
            if (checkThemSua) // Add new
            {
                result = bllTour.InsertTour(tour);
            }
            else // Update
            {
                result = bllTour.Update(tour);
            }

            if (result)
            {
                MessageBox.Show(checkThemSua ? "Thêm thành công!" : "Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowAllTour();
                CloseBox();
                btnLuu.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = false; // Disable after save
                btnXoa.Enabled = false; // Disable after save
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTour.Text))
            {
                MessageBox.Show("Chưa chọn Tour", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tbl_Tour tour = new tbl_Tour();
                tour.MaTour = txtMaTour.Text;

                if (bllTour.DeleteTour(tour))
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllTour();
                    ResetBox();
                    ResetInf();
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
        #endregion

        #region Image Handling
        string imgLocation1, imgLocation2, imgLocation3, imgLocation4;

        private void btnAnh1_Click(object sender, EventArgs e)
        {
            imgLocation1 = OpenImageDialog(picHinh1);
        }

        private void btnHinh2_Click(object sender, EventArgs e)
        {
            imgLocation2 = OpenImageDialog(picHinh2);
        }

        private void btnHinh3_Click(object sender, EventArgs e)
        {
            imgLocation3 = OpenImageDialog(picHinh3);
        }

        private void btnHinh4_Click(object sender, EventArgs e)
        {
            imgLocation4 = OpenImageDialog(picHinh4);
        }

        private string OpenImageDialog(PictureBox pb)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pb.ImageLocation = dialog.FileName;
                return dialog.FileName;
            }
            return null;
        }

        private byte[] GetImageData(string newImagePath, PictureBox pb)
        {
            if (!string.IsNullOrEmpty(newImagePath)) // If a new image was selected
            {
                return File.ReadAllBytes(newImagePath);
            }
            else if (pb.Image != null) // If no new image, use the existing one
            {
                using (var ms = new MemoryStream())
                {
                    pb.Image.Save(ms, pb.Image.RawFormat);
                    return ms.ToArray();
                }
            }
            return null; // No image
        }

        private Image GetImageFromBytes(byte[] imageBytes)
        {
            if (imageBytes == null || imageBytes.Length == 0) return null;
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);
            }
        }
        #endregion

        #region UI Events & Data Loading
        private void loadcmb()
        {
            cmbLoaiTour.ValueMember = "MaLTour";
            cmbLoaiTour.DisplayMember = "TenLTour";
            cmbLoaiTour.DataSource = bllLoaiTour.GetAllLTour();

            cmbSortLT.ValueMember = "MaLTour";
            cmbSortLT.DisplayMember = "TenLTour";
            cmbSortLT.DataSource = bllLoaiTour.GetAllLTour().Copy();

            cmbPT.ValueMember = "MaPT";
            cmbPT.DisplayMember = "TenPT";
            cmbPT.DataSource = bllPhuongTien.GetAllPhuongTien();

            cmbDiemDi.ValueMember = "MaDDi";
            cmbDiemDi.DisplayMember = "TenDDi";
            cmbDiemDi.DataSource = bllDiemDi.GetAllDDiTrongNc();

            cmbDDen.ValueMember = "MaDDen";
            cmbDDen.DisplayMember = "TenDDen";
            cmbDDen.DataSource = bllDiemDen.GetAllDDLTrongNc();

            cmbKS.ValueMember = "MaLKS";
            cmbKS.DisplayMember = "TenLKS";
            cmbKS.DataSource = bllLKS.GetAllLoaiKhachSan();
        }

        public void ShowAllTour()
        {
            if (cmbSortLT.SelectedValue == null) return;
            tbl_Tour tour = new tbl_Tour();
            tour.MaLTour = cmbSortLT.SelectedValue.ToString();
            dgvTour.DataSource = bllTour.GetLocTour(tour);
        }

        private void dgvTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            CloseBox();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;

            // Load data into input fields first
            loadClick();

            // Then load data into display panels
            tbl_Tour tour = new tbl_Tour();
            tour.MaTour = dgvTour.SelectedRows[0].Cells["Column8"].Value.ToString();
            DataTable dttable = bllTour.GetTTTour(tour);
            if (dttable != null && dttable.Rows.Count > 0)
            {
                DataRow row = dttable.Rows[0];
                lblTenTour.Text = row["TENTOUR"].ToString();
                lblMoTa.Text = row["MOTA"].ToString();
                lblGiaTour.Text = string.Format("{0:N0} đ/khách", row["GIATOUR"]);

                picHinh1.Image = GetImageFromBytes((byte[])row["ANH1"]);
                picHinh2.Image = GetImageFromBytes((byte[])row["ANH2"]);
                picHinh3.Image = GetImageFromBytes((byte[])row["ANH3"]);
                picHinh4.Image = GetImageFromBytes((byte[])row["ANH4"]);

                lblTGKH.Text = Convert.ToDateTime(row["NGAYDITOUR"]).ToString("dd/MM/yyyy");
                lblNoiKH.Text = row["TENDDI"].ToString();
                lblSoNgay.Text = row["TG"].ToString() + " ngày";
                lblSlot.Text = row["SOLUONGCONLAI"].ToString();
                int soDem = Convert.ToInt32(row["TG"]) - 1;
                lblTGnho.Text = $"{lblSoNgay.Text} {soDem} đêm";
                lblPT.Text = row["TENPT"].ToString();
                lblDiemDen.Text = row["TENDDEN"].ToString();
                lblKS.Text = row["TENLKS"].ToString();
                lblMaTour.Text = row["MATOUR"].ToString();
            }
        }

        private void loadClick()
        {
            if (dgvTour.SelectedRows.Count == 0) return;
            string maTour = dgvTour.SelectedRows[0].Cells["Column8"].Value.ToString();

            tbl_Tour Tour = new tbl_Tour();
            Tour.MaTour = maTour;
            DataTable dataTable2 = bllTour.GetAllTour2(Tour);
            if (dataTable2 != null && dataTable2.Rows.Count > 0)
            {
                DataRow row = dataTable2.Rows[0];
                txtMaTour.Text = row["MATOUR"].ToString();
                txtTenTour.Text = row["TENTOUR"].ToString();
                txtMoTa.Text = row["MOTA"].ToString();
                numSL.Value = Convert.ToDecimal(row["SOLUONGCONLAI"]);
                dtpNgayDi.Value = Convert.ToDateTime(row["NGAYDITOUR"]);
                dtpNgayKT.Value = Convert.ToDateTime(row["NGAYKETTHUC"]);
                cmbLoaiTour.SelectedValue = row["MALTOUR"];
                cmbPT.SelectedValue = row["MAPT"];
                cmbDiemDi.SelectedValue = row["MADDI"];
                cmbDDen.SelectedValue = row["MADDEN"];
                cmbKS.SelectedValue = row["MALKS"];
                txtGiaTour.Text = row["GIATOUR"].ToString();
            }
        }

        private void cmbLoaiTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLoaiTour.SelectedValue == null) return;
            if (cmbLoaiTour.SelectedValue.ToString() == "LT01") // Tour trong nước
            {
                cmbDDen.DataSource = bllDiemDen.GetAllDDLTrongNc();
            }
            else // Tour ngoài nước
            {
                cmbDDen.DataSource = bllDiemDen.GetAllDDLNgoaiNc();
            }
        }

        private void cmbSortLT_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAllTour();
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                txtTimKiem.Text = "Tìm Tour ...";
                txtTimKiem.ForeColor = Color.Silver;
                ShowAllTour();
            }
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm Tour ...")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text) || txtTimKiem.Text == "Tìm Tour ...")
            {
                ShowAllTour();
                return;
            }
            tbl_Tour tour = new tbl_Tour();
            tour.MaTour = txtTimKiem.Text;
            tour.TenTour = txtTimKiem.Text;
            dgvTour.DataSource = bllTour.SearchTour(tour);
        }

        private void txtGiaTour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}