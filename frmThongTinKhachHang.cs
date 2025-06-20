using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Microsoft.Reporting.WinForms;


namespace QL_TOUR
{
    public partial class frmThongTinKhachHang : Form
    {
        KhachHang_BLL bllKhachHang;
        NhanVien_BLL bllNhanVien;
        Tour_BLL bllTour;
        HoaDon_BLL bllHoaDon;
        LLT_BLL bllLLT;
        TTTV_BLL bllTTTV;
        Report_BLL bllReport;

        public frmThongTinKhachHang()
        {
            InitializeComponent();
            bllKhachHang = new KhachHang_BLL();
            bllLLT = new LLT_BLL();
            bllTTTV = new TTTV_BLL();
            bllNhanVien = new NhanVien_BLL();
            bllHoaDon = new HoaDon_BLL();
            bllTour = new Tour_BLL();
            bllReport = new Report_BLL();
        }

        public bool CheckData()
        {
            string notice = "";

            if (string.IsNullOrEmpty(txtHoTen.Text))
            {
                notice += "Chưa nhập họ tên!\n";
                txtHoTen.Focus();
            }

            if (string.IsNullOrEmpty(txtSDT.Text))
            {
                notice += "Chưa nhập SĐT!\n";
                txtSDT.Focus();
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                notice += "Chưa nhập Email!\n";
                txtEmail.Focus();
            }

            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                notice += "Chưa nhập địa chỉ\n";
                txtDiaChi.Focus();
            }

            if (!string.IsNullOrEmpty(notice))
            {
                MessageBox.Show(notice, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void btnTaoKH_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (Regex.IsMatch(txtEmail.Text, pattern))
                {
                    txtTenTV.Focus();
                    txtHoTen.Enabled = false;
                    txtSDT.Enabled = false;
                    txtEmail.Enabled = false;
                    txtDiaChi.Enabled = false;

                    txtTenTV.Enabled = true;
                    cmbGT.Enabled = true;
                    dtpNgaySinh.Enabled = true;

                    tbl_KhachHang KhachHang = new tbl_KhachHang();
                    string MaKH;
                    int soKH = bllKhachHang.GeTSoKHDangCo() + 1;
                    MaKH = "KH" + soKH.ToString("D2"); // Format thành 2 chữ số
                    KhachHang.MaKH = MaKH;
                    KhachHang.TenKH = txtHoTen.Text;
                    KhachHang.SDT = txtSDT.Text;
                    KhachHang.Email = txtEmail.Text;
                    KhachHang.DiaChi = txtDiaChi.Text;
                    if (bllKhachHang.InsertKhachHang(KhachHang))
                    {
                        lblTenKH.Text = txtHoTen.Text;
                        MessageBox.Show("Tạo khách hàng mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Email không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            if (CheckLLT1() == 0)
            {
                MessageBox.Show("Phải có ít nhất 1 người lớn trong đoàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            tbl_Tour Tour = new tbl_Tour();
            Tour.MaTour = lblMaTour.Text;

            tbl_HoaDon HoaDon = new tbl_HoaDon();
            HoaDon.SoHD = lblSoHD.Text;
            HoaDon.MaTour = lblMaTour.Text;
            if (cmbTenNV.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            HoaDon.MaNV = cmbTenNV.SelectedValue.ToString();

            int soKH = bllKhachHang.GeTSoKHDangCo();
            string MaKH = "KH" + soKH.ToString("D2");
            HoaDon.MaKH = MaKH;
            HoaDon.NgayLapHoaDon = Convert.ToDateTime(lblNgayTaoHD.Text);

            DataTable dtGiaLLT = bllLLT.GetAllLLT();
            decimal giaNL = Convert.ToDecimal(dtGiaLLT.Rows[0][2]);
            decimal giaTE = Convert.ToDecimal(dtGiaLLT.Rows[1][2]);
            decimal giaTN = Convert.ToDecimal(dtGiaLLT.Rows[2][2]);
            decimal giaEB = Convert.ToDecimal(dtGiaLLT.Rows[3][2]);
            decimal giaTourGoc = Convert.ToDecimal(bllTour.GetTTTour(Tour).Rows[0]["GIATOUR"]);

            HoaDon.ThanhTienHoaDon = (CheckLLT1() * giaNL) + (CheckLLT2() * giaTE) + (CheckLLT3() * giaTN) + (CheckLLT4() * giaEB) + giaTourGoc;

            if (bllHoaDon.InsertHoaDon(HoaDon))
            {
                tbl_KhachHang kh = new tbl_KhachHang();
                kh.MaKH = MaKH;
                bllTour.UpdatesltOUR(Tour, kh);

                frmReportHD BillFrm = new frmReportHD();
                BillFrm.Report = new tbl_Report();
                BillFrm.Report.SoHD = lblSoHD.Text;
                BillFrm.Report.MaKH = MaKH;

                ReportDataSource datasource = new ReportDataSource("DataSet1", bllReport.getReport(BillFrm.Report).Tables[0]);
                BillFrm.reportHD.LocalReport.DataSources.Clear();
                BillFrm.reportHD.LocalReport.DataSources.Add(datasource);
                BillFrm.reportHD.LocalReport.Refresh();
                this.Close();

                BillFrm.Show();
            }
        }


        private int CheckLLT1()
        {
            int a = 0;
            for (int i = 0; i < dgvTTKH.Rows.Count; i++)
            {
                if (dgvTTKH.Rows[i].Cells[4].Value?.ToString() == "Người lớn")
                {
                    a++;
                }
            }
            return a;
        }

        private int CheckLLT2()
        {
            int b = 0;
            for (int i = 0; i < dgvTTKH.Rows.Count; i++)
            {
                if (dgvTTKH.Rows[i].Cells[4].Value?.ToString() == "Trẻ em")
                {
                    b++;
                }
            }
            return b;
        }

        private int CheckLLT3()
        {
            int c = 0;
            for (int i = 0; i < dgvTTKH.Rows.Count; i++)
            {
                if (dgvTTKH.Rows[i].Cells[4].Value?.ToString() == "Trẻ nhỏ")
                {
                    c++;
                }
            }
            return c;
        }

        private int CheckLLT4()
        {
            int d = 0;
            for (int i = 0; i < dgvTTKH.Rows.Count; i++)
            {
                if (dgvTTKH.Rows[i].Cells[4].Value?.ToString() == "Em bé")
                {
                    d++;
                }
            }
            return d;
        }

        private void LoadDaTa()
        {
            cmbTenNV.ValueMember = "MaNV";
            cmbTenNV.DisplayMember = "TenNV";
            cmbTenNV.DataSource = bllNhanVien.GetAllNhanVien();

            int soHD = bllHoaDon.GetSoHD() + 1;
            lblSoHD.Text = "HD" + soHD.ToString("D2");

            lblNgayTaoHD.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblTenKH.Text = txtHoTen.Text;

            tbl_Tour Tour = new tbl_Tour();
            Tour.MaTour = lblMaTour.Text;
            DataTable dtTour = bllTour.GetTTTour(Tour);
            if (dtTour != null && dtTour.Rows.Count > 0)
            {
                lblGiaTour.Text = string.Format("{0:#,##0} đ", decimal.Parse(dtTour.Rows[0]["GIATOUR"].ToString()));
            }

        }

        private void frmThongTinKhachHang_Load(object sender, EventArgs e)
        {
            LoadDaTa();
            cmbLLT.ValueMember = "MALLT";
            cmbLLT.DisplayMember = "TENLLT";
            cmbLLT.DataSource = bllLLT.GetAllLLT();
            if (cmbLLT.Items.Count > 0) cmbLLT.SelectedIndex = 3;
            if (cmbGT.Items.Count > 0) cmbGT.SelectedIndex = 0;

            txtTenTV.Enabled = false;
            cmbGT.Enabled = false;
            dtpNgaySinh.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenTV.Text))
            {
                MessageBox.Show("Chưa nhập họ tên thành viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgvTTKH.Rows.Count >= Convert.ToInt32(lblSlot.Text))
            {
                MessageBox.Show("Không đủ số lượng chỗ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            int soKH = bllKhachHang.GeTSoKHDangCo();
            string MaKH = "KH" + soKH.ToString("D2");

            tbl_TTTV TTTV = new tbl_TTTV();
            TTTV.MaKH = MaKH;
            TTTV.MaLLT = cmbLLT.SelectedValue.ToString();
            TTTV.TenTV = txtTenTV.Text;
            TTTV.GioiTinh = cmbGT.Text;
            TTTV.NgaySinh = dtpNgaySinh.Value;

            if (bllTTTV.InsertTTTV(TTTV))
            {
                dgvTTKH.DataSource = bllTTTV.GetTTTV(TTTV);
                txtTenTV.Clear();
                if (cmbGT.Items.Count > 0) cmbGT.SelectedIndex = 0;
                dtpNgaySinh.Value = DateTime.Now;
                SetGiaTien();
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            int age = DateTime.Now.Year - dtpNgaySinh.Value.Year;
            if (dtpNgaySinh.Value.Date > DateTime.Now.Date) age--;

            if (age < 0)
            {
                MessageBox.Show("Ngày sinh không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpNgaySinh.Value = DateTime.Now;
                return;
            }

            if (age <= 2) cmbLLT.SelectedIndex = 3; // Em bé
            else if (age <= 4) cmbLLT.SelectedIndex = 2; // Trẻ nhỏ
            else if (age <= 11) cmbLLT.SelectedIndex = 1; // Trẻ em
            else cmbLLT.SelectedIndex = 0; // Người lớn
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvTTKH.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn thành viên để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(txtTenTV.Text))
            {
                MessageBox.Show("Chưa nhập họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int soKH = bllKhachHang.GeTSoKHDangCo();
            string MaKH = "KH" + soKH.ToString("D2");

            tbl_TTTV TTTV = new tbl_TTTV();
            TTTV.MaTV = dgvTTKH.SelectedRows[0].Cells["Column1"].Value.ToString();
            TTTV.MaKH = MaKH;
            TTTV.MaLLT = cmbLLT.SelectedValue.ToString();
            TTTV.TenTV = txtTenTV.Text;
            TTTV.GioiTinh = cmbGT.Text;
            TTTV.NgaySinh = dtpNgaySinh.Value;

            if (bllTTTV.UpdateTTTV(TTTV))
            {
                dgvTTKH.DataSource = bllTTTV.GetTTTV(TTTV);
                txtTenTV.Clear();
                if (cmbGT.Items.Count > 0) cmbGT.SelectedIndex = 0;
                dtpNgaySinh.Value = DateTime.Now;
                SetGiaTien();
            }
        }

        private void dgvTTKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTTKH.Rows[e.RowIndex];
                txtTenTV.Text = row.Cells["Column2"].Value.ToString();
                cmbGT.Text = row.Cells["Column3"].Value.ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["Column4"].Value);
                cmbLLT.Text = row.Cells["Column5"].Value.ToString();
            }
        }

        private void SetGiaTien()
        {
            tbl_Tour Tour = new tbl_Tour();
            Tour.MaTour = lblMaTour.Text;
            lblSLTong.Text = dgvTTKH.Rows.Count.ToString();

            DataTable dtGiaLLT = bllLLT.GetAllLLT();
            decimal giaNL = Convert.ToDecimal(dtGiaLLT.Rows[0][2]);
            decimal giaTE = Convert.ToDecimal(dtGiaLLT.Rows[1][2]);
            decimal giaTN = Convert.ToDecimal(dtGiaLLT.Rows[2][2]);
            decimal giaEB = Convert.ToDecimal(dtGiaLLT.Rows[3][2]);
            decimal giaTourGoc = Convert.ToDecimal(bllTour.GetTTTour(Tour).Rows[0]["GIATOUR"]);

            lblGiaNL.Text = CheckLLT1() > 0 ? $"{CheckLLT1()} x {giaNL:N0} đ" : "0 đ";
            lblGiaTE.Text = CheckLLT2() > 0 ? $"{CheckLLT2()} x {giaTE:N0} đ" : "0 đ";
            lblGiaTN.Text = CheckLLT3() > 0 ? $"{CheckLLT3()} x {giaTN:N0} đ" : "0 đ";
            lblGiaEB.Text = CheckLLT4() > 0 ? $"{CheckLLT4()} x {giaEB:N0} đ" : "0 đ";

            decimal tongTien = (CheckLLT1() * giaNL) + (CheckLLT2() * giaTE) + (CheckLLT3() * giaTN) + (CheckLLT4() * giaEB) + giaTourGoc;
            lblTongCong.Text = $"{tongTien:N0} đ";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTTKH.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chưa chọn thành viên để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tbl_TTTV TTTV = new tbl_TTTV();
                TTTV.MaTV = dgvTTKH.SelectedRows[0].Cells["Column1"].Value.ToString();

                int soKH = bllKhachHang.GeTSoKHDangCo();
                string MaKH = "KH" + soKH.ToString("D2");
                TTTV.MaKH = MaKH;

                if (bllTTTV.DeleteTTTV(TTTV))
                {
                    dgvTTKH.DataSource = bllTTTV.GetTTTV(TTTV);
                    txtTenTV.Clear();
                    if (cmbGT.Items.Count > 0) cmbGT.SelectedIndex = 0;
                    dtpNgaySinh.Value = DateTime.Now;
                    SetGiaTien();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}