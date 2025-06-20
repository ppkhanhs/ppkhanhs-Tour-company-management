using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// ĐẢM BẢO KHÔNG CÓ DÒNG "using Guna.UI2.WinForms;" Ở ĐÂY

namespace QL_TOUR
{
    public partial class frmXemHD : Form
    {
        TTTV_BLL blltttv;
        KhachHang_BLL bllKhachHang;
        HoaDon_BLL bllHoaDon;
        public frmXemHD()
        {
            InitializeComponent();
            blltttv = new TTTV_BLL();
            bllKhachHang = new KhachHang_BLL();
            bllHoaDon = new HoaDon_BLL();
        }


        public void ShowTTTV()
        {
            tbl_HoaDon HD = new tbl_HoaDon();
            HD.SoHD = lblSoHD.Text;
            DataTable dtTable = blltttv.GetTTTV2(HD);
            dgvThanhVien.DataSource = dtTable;
        }


        public string getMaKH()
        {
            tbl_HoaDon HD = new tbl_HoaDon();
            HD.SoHD = lblSoHD.Text;
            return bllKhachHang.getMaKH_HuyTour(HD);
        }

        private void frmXemHD_Load(object sender, EventArgs e)
        {
            ShowTTTV();
        }

        private void btnHuyTour_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy Tour này không?", "Xác nhận hủy Tour", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            // Lấy mã khách hàng TRƯỚC khi xóa hóa đơn
            string maKHCanXoa = getMaKH();

            tbl_HoaDon HD = new tbl_HoaDon();
            HD.SoHD = lblSoHD.Text;

            if (bllHoaDon.DeleteHoaDon(HD))
            {
                // Sau khi xóa hóa đơn thành công, tiến hành xóa khách hàng
                if (!string.IsNullOrEmpty(maKHCanXoa))
                {
                    tbl_KhachHang KhachHang = new tbl_KhachHang();
                    KhachHang.MaKH = maKHCanXoa;
                    bllKhachHang.DeleteKhachHang(KhachHang);
                }

                MessageBox.Show("Hủy Tour thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cập nhật lại frmHoaDon nếu nó đang mở
                frmHoaDon frmHoaDon = Application.OpenForms.OfType<frmHoaDon>().FirstOrDefault();
                if (frmHoaDon != null)
                {
                    frmHoaDon.ShowAllHoaDon();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}