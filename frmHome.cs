using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace QL_TOUR
{
    public partial class frmHome : Form
    {
        HoaDon_BLL bllhoadon;
        Tour_BLL bllTour;
        DataConnection db = new DataConnection();
        public frmHome()
        {
            InitializeComponent();
            bllhoadon = new HoaDon_BLL();
            bllTour = new Tour_BLL();
        }

        private void getDoanhThuNam()
        {
            chartRevenue.Series.Clear();
            chartRevenue.Series.Add("Doanh thu");
            tbl_HoaDon HoaDon = new tbl_HoaDon();
            HoaDon.Nam = Convert.ToInt32(cmbYear.Text);
            chartRevenue.DataSource = bllhoadon.ThongKe_DoanhThu_Nam(HoaDon);
            chartRevenue.ChartAreas[0].AxisX.Interval = 1;
            chartRevenue.ChartAreas[0].AxisY.Interval = 1500000;
            chartRevenue.Series[0].XValueMember = "Tháng";
            chartRevenue.Series[0].YValueMembers = "Thành tiền";
            chartRevenue.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chartRevenue.ChartAreas[0].AxisX.LineColor = Color.Gray;
            chartRevenue.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Transparent;
            chartRevenue.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.Black;
            chartRevenue.Series[0].Palette = ChartColorPalette.Fire;
            chartRevenue.ChartAreas[0].AxisY.LineColor = Color.Gray;
            chartRevenue.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;
            chartRevenue.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.Black;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            chartRevenue.Series.Clear();
            chartRevenue.Series.Add("Doanh thu");
            tbl_HoaDon HoaDon = new tbl_HoaDon();
            HoaDon.Nam = 2024;
            chartRevenue.DataSource = bllhoadon.ThongKe_DoanhThu_Nam(HoaDon);
            chartRevenue.ChartAreas[0].AxisX.Interval = 1;
            chartRevenue.ChartAreas[0].AxisY.Interval = 1500000;
            chartRevenue.Series[0].XValueMember = "Tháng";
            chartRevenue.Series[0].YValueMembers = "Thành tiền";
            chartRevenue.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chartRevenue.ChartAreas[0].AxisX.LineColor = Color.Gray;
            chartRevenue.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Transparent;
            chartRevenue.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.Black;
            chartRevenue.Series[0].Palette = ChartColorPalette.Fire;
            chartRevenue.ChartAreas[0].AxisY.LineColor = Color.Gray;
            chartRevenue.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;
            chartRevenue.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.Black;

            cmbYear.Items.Add("-- Chọn năm --");
            cmbYear.SelectedIndex = 0;
            for (int a = 2015; a < 2026; a++)
            {
                cmbYear.Items.Add(a);
            }
            cmbYear.Text = 2024.ToString();

            try
            {
                string queryTotal = "SELECT SUM(THANHTIENHOADON) AS TongTien FROM HOADON";

                string queryWeek = @"
                    SELECT SUM(THANHTIENHOADON) AS TongTien
                    FROM HOADON
                    WHERE DATEPART(YEAR, NGAYLAPHOADON) = @Year AND DATEPART(WEEK, NGAYLAPHOADON) = @Week";

                string queryMonth = @"
                    SELECT SUM(THANHTIENHOADON) AS TongTien
                    FROM HOADON
                    WHERE YEAR(NGAYLAPHOADON) = @Year AND MONTH(NGAYLAPHOADON) = @Month";

                string queryYear = @"
                    SELECT SUM(THANHTIENHOADON) AS TongTien
                    FROM HOADON
                    WHERE YEAR(NGAYLAPHOADON) = @Year";

                string queryHoaDon = "SELECT COUNT(SOHD) FROM HOADON";

                string queryCustomer = "SELECT COUNT(MAKH) FROM KHACHHANG";

                // Gọi hàm lấy dữ liệu và gán vào Label
                lblTongDoanhThu.Text = "" + GetSumValue(queryTotal).ToString("N0") + " VND";
                lblDoanhThuTuan.Text = "" + GetSumValue(queryWeek, 2024, 51).ToString("N0") + " VND";
                lblDoanhThuThang.Text = "" + GetSumValue(queryMonth, 2024, 12).ToString("N0") + " VND";
                lblDoanhThuNam.Text = "" + GetSumValue(queryYear, 2024).ToString("N0") + " VND";

                lblHoaDon.Text = "" + GetCountValue(queryHoaDon).ToString() + " hóa đơn";
                lblKhachHang.Text = "" + GetCountValue(queryCustomer).ToString() + " khách hàng";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cmbYear.SelectedIndex != 0))
            {
                getDoanhThuNam();
            }
        }

        private decimal GetSumValue(string query, int year = 0, int period = 0)
        {
            decimal result = 0;

            using (SqlConnection conn = db.getConnect())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (query.Contains("@Year")) cmd.Parameters.AddWithValue("@Year", year);
                        if (query.Contains("@Week")) cmd.Parameters.AddWithValue("@Week", period);
                        if (query.Contains("@Month")) cmd.Parameters.AddWithValue("@Month", period);

                        object value = cmd.ExecuteScalar();
                        if (value != DBNull.Value)
                            result = Convert.ToDecimal(value);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi truy vấn: " + ex.Message);
                }
            }

            return result;
        }

        private int GetCountValue(string query)
        {
            int result = 0;

            using (SqlConnection conn = db.getConnect())
            {
                try
                {
                    conn.Open(); // Mở kết nối
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        object value = cmd.ExecuteScalar();
                        if (value != DBNull.Value)
                            result = Convert.ToInt32(value);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi truy vấn: " + ex.Message);
                }
            }

            return result;
        }
    }
}