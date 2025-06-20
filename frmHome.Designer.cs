namespace QL_TOUR
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelChartContainer = new System.Windows.Forms.Panel();
            this.panelStatistics = new System.Windows.Forms.Panel();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.lblDoanhThuNam = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lblDoanhThuThang = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblDoanhThuTuan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            this.panelChartContainer.SuspendLayout();
            this.panelStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.ItemHeight = 23;
            this.cmbYear.Location = new System.Drawing.Point(359, 2);
            this.cmbYear.Margin = new System.Windows.Forms.Padding(4);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(179, 31);
            this.cmbYear.TabIndex = 4;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // chartRevenue
            // 
            this.chartRevenue.BackColor = System.Drawing.Color.Transparent;
            this.chartRevenue.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineWidth = 2;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineWidth = 2;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.BorderWidth = 2;
            chartArea1.Name = "Revenue Chart";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 86F;
            chartArea1.Position.Width = 79F;
            chartArea1.Position.X = 8F;
            chartArea1.Position.Y = 7F;
            this.chartRevenue.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.Height = 5.311355F;
            legend1.Position.Width = 13.34895F;
            legend1.Position.X = 46.32553F;
            legend1.Position.Y = 94.68864F;
            this.chartRevenue.Legends.Add(legend1);
            this.chartRevenue.Location = new System.Drawing.Point(72, 23);
            this.chartRevenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartRevenue.Name = "chartRevenue";
            this.chartRevenue.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BackSecondaryColor = System.Drawing.Color.Turquoise;
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.BorderWidth = 3;
            series1.ChartArea = "Revenue Chart";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(40)))), ((int)(((byte)(37)))));
            series1.IsValueShownAsLabel = true;
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.LabelBorderColor = System.Drawing.Color.Transparent;
            series1.LabelForeColor = System.Drawing.Color.DodgerBlue;
            series1.Legend = "Legend1";
            series1.Name = "Revenue";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.YValuesPerPoint = 2;
            series2.BorderWidth = 3;
            series2.ChartArea = "Revenue Chart";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Revenue2";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            this.chartRevenue.Series.Add(series1);
            this.chartRevenue.Series.Add(series2);
            this.chartRevenue.Size = new System.Drawing.Size(783, 472);
            this.chartRevenue.TabIndex = 10;
            title1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Doanh thu các tháng trong năm";
            title1.Position.Auto = false;
            title1.Position.Height = 3.997467F;
            title1.Position.Width = 94F;
            title1.Position.X = 3F;
            title1.Text = "Doanh thu các tháng trong năm";
            this.chartRevenue.Titles.Add(title1);
            // 
            // panelChartContainer
            // 
            this.panelChartContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChartContainer.Controls.Add(this.chartRevenue);
            this.panelChartContainer.Location = new System.Drawing.Point(13, 57);
            this.panelChartContainer.Margin = new System.Windows.Forms.Padding(4);
            this.panelChartContainer.Name = "panelChartContainer";
            this.panelChartContainer.Size = new System.Drawing.Size(841, 548);
            this.panelChartContainer.TabIndex = 2;
            // 
            // panelStatistics
            // 
            this.panelStatistics.BackColor = System.Drawing.Color.White;
            this.panelStatistics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStatistics.Controls.Add(this.lblKhachHang);
            this.panelStatistics.Controls.Add(this.label14);
            this.panelStatistics.Controls.Add(this.button6);
            this.panelStatistics.Controls.Add(this.lblHoaDon);
            this.panelStatistics.Controls.Add(this.label12);
            this.panelStatistics.Controls.Add(this.button5);
            this.panelStatistics.Controls.Add(this.lblTongDoanhThu);
            this.panelStatistics.Controls.Add(this.label10);
            this.panelStatistics.Controls.Add(this.button4);
            this.panelStatistics.Controls.Add(this.lblDoanhThuNam);
            this.panelStatistics.Controls.Add(this.label8);
            this.panelStatistics.Controls.Add(this.button3);
            this.panelStatistics.Controls.Add(this.lblDoanhThuThang);
            this.panelStatistics.Controls.Add(this.label6);
            this.panelStatistics.Controls.Add(this.button2);
            this.panelStatistics.Controls.Add(this.lblDoanhThuTuan);
            this.panelStatistics.Controls.Add(this.label3);
            this.panelStatistics.Controls.Add(this.button1);
            this.panelStatistics.Controls.Add(this.label1);
            this.panelStatistics.Location = new System.Drawing.Point(875, 57);
            this.panelStatistics.Margin = new System.Windows.Forms.Padding(4);
            this.panelStatistics.Name = "panelStatistics";
            this.panelStatistics.Size = new System.Drawing.Size(669, 548);
            this.panelStatistics.TabIndex = 9;
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachHang.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblKhachHang.Location = new System.Drawing.Point(358, 384);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(0, 32);
            this.lblKhachHang.TabIndex = 76;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(358, 350);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(165, 25);
            this.label14.TabIndex = 75;
            this.label14.Text = "Tổng khách hàng";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(346, 335);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(298, 89);
            this.button6.TabIndex = 74;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.AutoSize = true;
            this.lblHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoaDon.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblHoaDon.Location = new System.Drawing.Point(43, 384);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(0, 32);
            this.lblHoaDon.TabIndex = 73;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(33, 350);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(192, 25);
            this.label12.TabIndex = 72;
            this.label12.Text = "Tổng hoá đơn đã lập";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(21, 335);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(298, 89);
            this.button5.TabIndex = 71;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDoanhThu.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTongDoanhThu.Location = new System.Drawing.Point(357, 261);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(0, 32);
            this.lblTongDoanhThu.TabIndex = 70;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(357, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(220, 25);
            this.label10.TabIndex = 69;
            this.label10.Text = "Tổng toàn bộ doanh thu";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(345, 212);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(298, 89);
            this.button4.TabIndex = 68;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lblDoanhThuNam
            // 
            this.lblDoanhThuNam.AutoSize = true;
            this.lblDoanhThuNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThuNam.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblDoanhThuNam.Location = new System.Drawing.Point(43, 261);
            this.lblDoanhThuNam.Name = "lblDoanhThuNam";
            this.lblDoanhThuNam.Size = new System.Drawing.Size(0, 32);
            this.lblDoanhThuNam.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 25);
            this.label8.TabIndex = 66;
            this.label8.Text = "Doanh thu năm";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(20, 212);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(298, 89);
            this.button3.TabIndex = 65;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lblDoanhThuThang
            // 
            this.lblDoanhThuThang.AutoSize = true;
            this.lblDoanhThuThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThuThang.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblDoanhThuThang.Location = new System.Drawing.Point(357, 143);
            this.lblDoanhThuThang.Name = "lblDoanhThuThang";
            this.lblDoanhThuThang.Size = new System.Drawing.Size(0, 32);
            this.lblDoanhThuThang.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(357, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 25);
            this.label6.TabIndex = 63;
            this.label6.Text = "Doanh thu tháng";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(345, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(298, 89);
            this.button2.TabIndex = 62;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblDoanhThuTuan
            // 
            this.lblDoanhThuTuan.AutoSize = true;
            this.lblDoanhThuTuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThuTuan.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblDoanhThuTuan.Location = new System.Drawing.Point(43, 143);
            this.lblDoanhThuTuan.Name = "lblDoanhThuTuan";
            this.lblDoanhThuTuan.Size = new System.Drawing.Size(0, 32);
            this.lblDoanhThuTuan.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 60;
            this.label3.Text = "Doanh thu tuần";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(298, 89);
            this.button1.TabIndex = 59;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(159, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 32);
            this.label1.TabIndex = 58;
            this.label1.Text = "THỐNG KÊ SỐ LIỆU CÔNG TY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1557, 910);
            this.Controls.Add(this.panelStatistics);
            this.Controls.Add(this.panelChartContainer);
            this.Controls.Add(this.cmbYear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.panelChartContainer.ResumeLayout(false);
            this.panelStatistics.ResumeLayout(false);
            this.panelStatistics.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.Panel panelChartContainer;
        private System.Windows.Forms.Panel panelStatistics;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lblHoaDon;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblDoanhThuNam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblDoanhThuThang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblDoanhThuTuan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}