namespace QL_TOUR
{
    partial class frmXemHD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnHuyTour = new System.Windows.Forms.Button();
            this.lblGiaTour = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTenTour = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNgayLapHD = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblSoHD = new System.Windows.Forms.Label();
            this.dgvThanhVien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNgayLapHDd = new System.Windows.Forms.Label();
            this.lblTenKHd = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.Control;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.btnHuyTour);
            this.panelMain.Controls.Add(this.lblGiaTour);
            this.panelMain.Controls.Add(this.label10);
            this.panelMain.Controls.Add(this.lblTenTour);
            this.panelMain.Controls.Add(this.label9);
            this.panelMain.Controls.Add(this.lblNgayLapHD);
            this.panelMain.Controls.Add(this.lblTenKH);
            this.panelMain.Controls.Add(this.lblTenNV);
            this.panelMain.Controls.Add(this.lblSoHD);
            this.panelMain.Controls.Add(this.dgvThanhVien);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.lblNgayLapHDd);
            this.panelMain.Controls.Add(this.lblTenKHd);
            this.panelMain.Controls.Add(this.s);
            this.panelMain.Controls.Add(this.txtThanhTien);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Location = new System.Drawing.Point(16, 15);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1095, 682);
            this.panelMain.TabIndex = 0;
            // 
            // btnHuyTour
            // 
            this.btnHuyTour.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHuyTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyTour.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyTour.ForeColor = System.Drawing.Color.White;
            this.btnHuyTour.Location = new System.Drawing.Point(896, 625);
            this.btnHuyTour.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuyTour.Name = "btnHuyTour";
            this.btnHuyTour.Size = new System.Drawing.Size(156, 55);
            this.btnHuyTour.TabIndex = 140;
            this.btnHuyTour.Text = "Hủy Tour";
            this.btnHuyTour.UseVisualStyleBackColor = false;
            this.btnHuyTour.Click += new System.EventHandler(this.btnHuyTour_Click);
            // 
            // lblGiaTour
            // 
            this.lblGiaTour.AutoSize = true;
            this.lblGiaTour.BackColor = System.Drawing.SystemColors.Control;
            this.lblGiaTour.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblGiaTour.Location = new System.Drawing.Point(876, 91);
            this.lblGiaTour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGiaTour.Name = "lblGiaTour";
            this.lblGiaTour.Size = new System.Drawing.Size(117, 28);
            this.lblGiaTour.TabIndex = 139;
            this.lblGiaTour.Text = "Số hóa đơn:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label10.Location = new System.Drawing.Point(108, 91);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 28);
            this.label10.TabIndex = 136;
            this.label10.Text = "Tên Tour:";
            // 
            // lblTenTour
            // 
            this.lblTenTour.BackColor = System.Drawing.SystemColors.Control;
            this.lblTenTour.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTenTour.Location = new System.Drawing.Point(260, 91);
            this.lblTenTour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenTour.Name = "lblTenTour";
            this.lblTenTour.Size = new System.Drawing.Size(456, 68);
            this.lblTenTour.TabIndex = 138;
            this.lblTenTour.Text = "Số hóa đơn:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.Location = new System.Drawing.Point(724, 91);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 28);
            this.label9.TabIndex = 137;
            this.label9.Text = "Giá Tour:";
            // 
            // lblNgayLapHD
            // 
            this.lblNgayLapHD.AutoSize = true;
            this.lblNgayLapHD.BackColor = System.Drawing.SystemColors.Control;
            this.lblNgayLapHD.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNgayLapHD.Location = new System.Drawing.Point(641, 53);
            this.lblNgayLapHD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayLapHD.Name = "lblNgayLapHD";
            this.lblNgayLapHD.Size = new System.Drawing.Size(117, 28);
            this.lblNgayLapHD.TabIndex = 135;
            this.lblNgayLapHD.Text = "Số hóa đơn:";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.BackColor = System.Drawing.SystemColors.Control;
            this.lblTenKH.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTenKH.Location = new System.Drawing.Point(641, 17);
            this.lblTenKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(117, 28);
            this.lblTenKH.TabIndex = 134;
            this.lblTenKH.Text = "Số hóa đơn:";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.BackColor = System.Drawing.SystemColors.Control;
            this.lblTenNV.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTenNV.Location = new System.Drawing.Point(260, 53);
            this.lblTenNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(117, 28);
            this.lblTenNV.TabIndex = 133;
            this.lblTenNV.Text = "Số hóa đơn:";
            // 
            // lblSoHD
            // 
            this.lblSoHD.AutoSize = true;
            this.lblSoHD.BackColor = System.Drawing.SystemColors.Control;
            this.lblSoHD.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSoHD.Location = new System.Drawing.Point(260, 15);
            this.lblSoHD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoHD.Name = "lblSoHD";
            this.lblSoHD.Size = new System.Drawing.Size(117, 28);
            this.lblSoHD.TabIndex = 132;
            this.lblSoHD.Text = "Số hóa đơn:";
            // 
            // dgvThanhVien
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvThanhVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThanhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThanhVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvThanhVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvThanhVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThanhVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThanhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThanhVien.ColumnHeadersHeight = 30;
            this.dgvThanhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThanhVien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThanhVien.EnableHeadersVisualStyles = false;
            this.dgvThanhVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThanhVien.Location = new System.Drawing.Point(17, 162);
            this.dgvThanhVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvThanhVien.Name = "dgvThanhVien";
            this.dgvThanhVien.ReadOnly = true;
            this.dgvThanhVien.RowHeadersVisible = false;
            this.dgvThanhVien.RowHeadersWidth = 51;
            this.dgvThanhVien.RowTemplate.Height = 25;
            this.dgvThanhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThanhVien.Size = new System.Drawing.Size(1065, 455);
            this.dgvThanhVien.TabIndex = 131;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MATV";
            this.Column1.FillWeight = 40F;
            this.Column1.HeaderText = "Mã TV";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENTV";
            this.Column2.HeaderText = "Tên TV";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GIOITINH";
            this.Column3.HeaderText = "Giới tính";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NGAYSINH";
            this.Column4.HeaderText = "Ngày sinh";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TENLLT";
            this.Column5.HeaderText = "Loại LT";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(108, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 28);
            this.label3.TabIndex = 129;
            this.label3.Text = "Số hóa đơn:";
            // 
            // lblNgayLapHDd
            // 
            this.lblNgayLapHDd.AutoSize = true;
            this.lblNgayLapHDd.BackColor = System.Drawing.SystemColors.Control;
            this.lblNgayLapHDd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNgayLapHDd.Location = new System.Drawing.Point(473, 53);
            this.lblNgayLapHDd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayLapHDd.Name = "lblNgayLapHDd";
            this.lblNgayLapHDd.Size = new System.Drawing.Size(128, 28);
            this.lblNgayLapHDd.TabIndex = 128;
            this.lblNgayLapHDd.Text = "Ngày lập HD:";
            // 
            // lblTenKHd
            // 
            this.lblTenKHd.AutoSize = true;
            this.lblTenKHd.BackColor = System.Drawing.SystemColors.Control;
            this.lblTenKHd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTenKHd.Location = new System.Drawing.Point(473, 15);
            this.lblTenKHd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenKHd.Name = "lblTenKHd";
            this.lblTenKHd.Size = new System.Drawing.Size(150, 28);
            this.lblTenKHd.TabIndex = 127;
            this.lblTenKHd.Text = "Tên khách hàng:";
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.BackColor = System.Drawing.SystemColors.Control;
            this.s.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.s.Location = new System.Drawing.Point(108, 53);
            this.s.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(134, 28);
            this.s.TabIndex = 126;
            this.s.Text = "Tên nhân viên:";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.BackColor = System.Drawing.SystemColors.Control;
            this.txtThanhTien.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(159, 636);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(259, 32);
            this.txtThanhTien.TabIndex = 124;
            this.txtThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(41, 641);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 28);
            this.label2.TabIndex = 125;
            this.label2.Text = "Thành tiền:";
            // 
            // frmXemHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1128, 713);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmXemHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmXemHD";
            this.Load += new System.EventHandler(this.frmXemHD_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelMain;
        public System.Windows.Forms.Label lblGiaTour;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label lblTenTour;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label lblNgayLapHD;
        public System.Windows.Forms.Label lblTenKH;
        public System.Windows.Forms.Label lblTenNV;
        public System.Windows.Forms.Label lblSoHD;
        public System.Windows.Forms.DataGridView dgvThanhVien;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblNgayLapHDd;
        public System.Windows.Forms.Label lblTenKHd;
        public System.Windows.Forms.Label s;
        public System.Windows.Forms.TextBox txtThanhTien;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnHuyTour;
    }
}