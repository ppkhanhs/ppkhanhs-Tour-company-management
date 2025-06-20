namespace QL_TOUR
{
    partial class frmDatTour
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
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.btlLocKQ = new System.Windows.Forms.Button();
            this.lblThongTinVanChuyen = new System.Windows.Forms.Label();
            this.lblSoNguoi = new System.Windows.Forms.Label();
            this.dtpNgayDi = new System.Windows.Forms.DateTimePicker();
            this.lblNgayDi = new System.Windows.Forms.Label();
            this.lblDiemDen = new System.Windows.Forms.Label();
            this.cmbDiemDi = new System.Windows.Forms.ComboBox();
            this.lblDiemDi = new System.Windows.Forms.Label();
            this.btnTrongNuoc = new System.Windows.Forms.Button();
            this.cmbDiemDen = new System.Windows.Forms.ComboBox();
            this.grbLocKQ = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.numSL = new System.Windows.Forms.NumericUpDown();
            this.cmbPhuongTien = new System.Windows.Forms.ComboBox();
            this.cmbSoNgay = new System.Windows.Forms.ComboBox();
            this.lblSoNgay = new System.Windows.Forms.Label();
            this.dgvTour = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblKQSoTour = new System.Windows.Forms.Label();
            this.btnNgoaiNuoc = new System.Windows.Forms.Button();
            this.grbLocKQ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChildForm
            // 
            this.panelChildForm.Location = new System.Drawing.Point(456, 244);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(4);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1120, 613);
            this.panelChildForm.TabIndex = 4;
            // 
            // btlLocKQ
            // 
            this.btlLocKQ.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btlLocKQ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlLocKQ.ForeColor = System.Drawing.Color.White;
            this.btlLocKQ.Location = new System.Drawing.Point(37, 647);
            this.btlLocKQ.Margin = new System.Windows.Forms.Padding(4);
            this.btlLocKQ.Name = "btlLocKQ";
            this.btlLocKQ.Size = new System.Drawing.Size(161, 46);
            this.btlLocKQ.TabIndex = 26;
            this.btlLocKQ.Text = "Lọc kết quả";
            this.btlLocKQ.UseVisualStyleBackColor = false;
            this.btlLocKQ.Click += new System.EventHandler(this.btlLocKQ_Click);
            // 
            // lblThongTinVanChuyen
            // 
            this.lblThongTinVanChuyen.AutoSize = true;
            this.lblThongTinVanChuyen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinVanChuyen.Location = new System.Drawing.Point(8, 551);
            this.lblThongTinVanChuyen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThongTinVanChuyen.Name = "lblThongTinVanChuyen";
            this.lblThongTinVanChuyen.Size = new System.Drawing.Size(218, 28);
            this.lblThongTinVanChuyen.TabIndex = 24;
            this.lblThongTinVanChuyen.Text = "Thông tin vận chuyển";
            // 
            // lblSoNguoi
            // 
            this.lblSoNguoi.AutoSize = true;
            this.lblSoNguoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNguoi.Location = new System.Drawing.Point(8, 454);
            this.lblSoNguoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoNguoi.Name = "lblSoNguoi";
            this.lblSoNguoi.Size = new System.Drawing.Size(97, 28);
            this.lblSoNguoi.TabIndex = 14;
            this.lblSoNguoi.Text = "Số người";
            // 
            // dtpNgayDi
            // 
            this.dtpNgayDi.CalendarMonthBackground = System.Drawing.Color.LightGray;
            this.dtpNgayDi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayDi.Location = new System.Drawing.Point(8, 394);
            this.dtpNgayDi.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayDi.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayDi.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayDi.Name = "dtpNgayDi";
            this.dtpNgayDi.Size = new System.Drawing.Size(413, 34);
            this.dtpNgayDi.TabIndex = 12;
            this.dtpNgayDi.Value = new System.DateTime(2024, 1, 1, 14, 38, 0, 0);
            // 
            // lblNgayDi
            // 
            this.lblNgayDi.AutoSize = true;
            this.lblNgayDi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDi.Location = new System.Drawing.Point(8, 362);
            this.lblNgayDi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayDi.Name = "lblNgayDi";
            this.lblNgayDi.Size = new System.Drawing.Size(87, 28);
            this.lblNgayDi.TabIndex = 11;
            this.lblNgayDi.Text = "Ngày đi";
            // 
            // lblDiemDen
            // 
            this.lblDiemDen.AutoSize = true;
            this.lblDiemDen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemDen.Location = new System.Drawing.Point(8, 178);
            this.lblDiemDen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiemDen.Name = "lblDiemDen";
            this.lblDiemDen.Size = new System.Drawing.Size(104, 28);
            this.lblDiemDen.TabIndex = 4;
            this.lblDiemDen.Text = "Điểm đến";
            // 
            // cmbDiemDi
            // 
            this.cmbDiemDi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiemDi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDiemDi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbDiemDi.FormattingEnabled = true;
            this.cmbDiemDi.ItemHeight = 23;
            this.cmbDiemDi.Location = new System.Drawing.Point(8, 117);
            this.cmbDiemDi.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDiemDi.Name = "cmbDiemDi";
            this.cmbDiemDi.Size = new System.Drawing.Size(412, 31);
            this.cmbDiemDi.TabIndex = 3;
            // 
            // lblDiemDi
            // 
            this.lblDiemDi.AutoSize = true;
            this.lblDiemDi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemDi.Location = new System.Drawing.Point(8, 85);
            this.lblDiemDi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiemDi.Name = "lblDiemDi";
            this.lblDiemDi.Size = new System.Drawing.Size(87, 28);
            this.lblDiemDi.TabIndex = 2;
            this.lblDiemDi.Text = "Điểm đi";
            // 
            // btnTrongNuoc
            // 
            this.btnTrongNuoc.BackColor = System.Drawing.Color.White;
            this.btnTrongNuoc.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTrongNuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrongNuoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrongNuoc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTrongNuoc.Location = new System.Drawing.Point(8, 34);
            this.btnTrongNuoc.Margin = new System.Windows.Forms.Padding(4);
            this.btnTrongNuoc.Name = "btnTrongNuoc";
            this.btnTrongNuoc.Size = new System.Drawing.Size(411, 44);
            this.btnTrongNuoc.TabIndex = 0;
            this.btnTrongNuoc.Text = "Danh sách Tour trong nước";
            this.btnTrongNuoc.UseVisualStyleBackColor = false;
            this.btnTrongNuoc.Click += new System.EventHandler(this.btnTrongNuoc_Click);
            // 
            // cmbDiemDen
            // 
            this.cmbDiemDen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiemDen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDiemDen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbDiemDen.FormattingEnabled = true;
            this.cmbDiemDen.ItemHeight = 23;
            this.cmbDiemDen.Location = new System.Drawing.Point(8, 209);
            this.cmbDiemDen.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDiemDen.Name = "cmbDiemDen";
            this.cmbDiemDen.Size = new System.Drawing.Size(412, 31);
            this.cmbDiemDen.TabIndex = 5;
            // 
            // grbLocKQ
            // 
            this.grbLocKQ.Controls.Add(this.btnReset);
            this.grbLocKQ.Controls.Add(this.numSL);
            this.grbLocKQ.Controls.Add(this.cmbPhuongTien);
            this.grbLocKQ.Controls.Add(this.cmbSoNgay);
            this.grbLocKQ.Controls.Add(this.btlLocKQ);
            this.grbLocKQ.Controls.Add(this.lblThongTinVanChuyen);
            this.grbLocKQ.Controls.Add(this.lblSoNguoi);
            this.grbLocKQ.Controls.Add(this.dtpNgayDi);
            this.grbLocKQ.Controls.Add(this.lblNgayDi);
            this.grbLocKQ.Controls.Add(this.lblSoNgay);
            this.grbLocKQ.Controls.Add(this.cmbDiemDen);
            this.grbLocKQ.Controls.Add(this.lblDiemDen);
            this.grbLocKQ.Controls.Add(this.cmbDiemDi);
            this.grbLocKQ.Controls.Add(this.lblDiemDi);
            this.grbLocKQ.Controls.Add(this.btnTrongNuoc);
            this.grbLocKQ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLocKQ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grbLocKQ.Location = new System.Drawing.Point(16, 15);
            this.grbLocKQ.Margin = new System.Windows.Forms.Padding(4);
            this.grbLocKQ.Name = "grbLocKQ";
            this.grbLocKQ.Padding = new System.Windows.Forms.Padding(4);
            this.grbLocKQ.Size = new System.Drawing.Size(429, 875);
            this.grbLocKQ.TabIndex = 3;
            this.grbLocKQ.TabStop = false;
            this.grbLocKQ.Text = "Lọc kết quả";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(227, 647);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(161, 46);
            this.btnReset.TabIndex = 32;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // numSL
            // 
            this.numSL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numSL.ForeColor = System.Drawing.Color.Black;
            this.numSL.Location = new System.Drawing.Point(8, 486);
            this.numSL.Margin = new System.Windows.Forms.Padding(4);
            this.numSL.Name = "numSL";
            this.numSL.Size = new System.Drawing.Size(411, 27);
            this.numSL.TabIndex = 31;
            // 
            // cmbPhuongTien
            // 
            this.cmbPhuongTien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhuongTien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPhuongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbPhuongTien.FormattingEnabled = true;
            this.cmbPhuongTien.ItemHeight = 23;
            this.cmbPhuongTien.Location = new System.Drawing.Point(8, 583);
            this.cmbPhuongTien.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPhuongTien.Name = "cmbPhuongTien";
            this.cmbPhuongTien.Size = new System.Drawing.Size(412, 31);
            this.cmbPhuongTien.TabIndex = 30;
            // 
            // cmbSoNgay
            // 
            this.cmbSoNgay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSoNgay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSoNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSoNgay.FormattingEnabled = true;
            this.cmbSoNgay.ItemHeight = 23;
            this.cmbSoNgay.Items.AddRange(new object[] {
            "-- Chọn số ngày --",
            "1 - 3 ngày",
            "4 - 7 ngày",
            "8 - 14 ngày",
            "trên 14 ngày"});
            this.cmbSoNgay.Location = new System.Drawing.Point(8, 302);
            this.cmbSoNgay.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSoNgay.Name = "cmbSoNgay";
            this.cmbSoNgay.Size = new System.Drawing.Size(412, 31);
            this.cmbSoNgay.TabIndex = 27;
            // 
            // lblSoNgay
            // 
            this.lblSoNgay.AutoSize = true;
            this.lblSoNgay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNgay.Location = new System.Drawing.Point(8, 270);
            this.lblSoNgay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoNgay.Name = "lblSoNgay";
            this.lblSoNgay.Size = new System.Drawing.Size(87, 28);
            this.lblSoNgay.TabIndex = 7;
            this.lblSoNgay.Text = "Số ngày";
            // 
            // dgvTour
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTour.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTour.BackgroundColor = System.Drawing.Color.White;
            this.dgvTour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTour.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTour.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTour.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTour.ColumnHeadersHeight = 30;
            this.dgvTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTour.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTour.EnableHeadersVisualStyles = false;
            this.dgvTour.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTour.Location = new System.Drawing.Point(457, 49);
            this.dgvTour.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTour.Name = "dgvTour";
            this.dgvTour.ReadOnly = true;
            this.dgvTour.RowHeadersVisible = false;
            this.dgvTour.RowHeadersWidth = 51;
            this.dgvTour.RowTemplate.Height = 25;
            this.dgvTour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTour.Size = new System.Drawing.Size(1116, 187);
            this.dgvTour.TabIndex = 7;
            this.dgvTour.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTour_CellClick);
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "MaTour";
            this.Column8.FillWeight = 39F;
            this.Column8.HeaderText = "Mã Tour";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "TenTour";
            this.Column9.HeaderText = "Tên Tour";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "SoLuongConLai";
            this.Column10.FillWeight = 30F;
            this.Column10.HeaderText = "Số chỗ";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "NgayDiTour";
            this.Column11.FillWeight = 60F;
            this.Column11.HeaderText = "Ngày đi";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "NgayKetThuc";
            this.Column12.FillWeight = 60F;
            this.Column12.HeaderText = "Ngày kết thúc";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "GiaTour";
            this.Column13.FillWeight = 50F;
            this.Column13.HeaderText = "Giá Tour";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // lblKQSoTour
            // 
            this.lblKQSoTour.AutoSize = true;
            this.lblKQSoTour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQSoTour.Location = new System.Drawing.Point(903, 15);
            this.lblKQSoTour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKQSoTour.Name = "lblKQSoTour";
            this.lblKQSoTour.Size = new System.Drawing.Size(179, 28);
            this.lblKQSoTour.TabIndex = 8;
            this.lblKQSoTour.Text = "Đã tìm được 0 Tour";
            // 
            // btnNgoaiNuoc
            // 
            this.btnNgoaiNuoc.BackColor = System.Drawing.Color.White;
            this.btnNgoaiNuoc.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnNgoaiNuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNgoaiNuoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNgoaiNuoc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnNgoaiNuoc.Location = new System.Drawing.Point(457, 15);
            this.btnNgoaiNuoc.Margin = new System.Windows.Forms.Padding(4);
            this.btnNgoaiNuoc.Name = "btnNgoaiNuoc";
            this.btnNgoaiNuoc.Size = new System.Drawing.Size(195, 28);
            this.btnNgoaiNuoc.TabIndex = 1;
            this.btnNgoaiNuoc.Text = "Ngoài nước";
            this.btnNgoaiNuoc.UseVisualStyleBackColor = false;
            this.btnNgoaiNuoc.Click += new System.EventHandler(this.btnNgoaiNuoc_Click);
            // 
            // frmDatTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1589, 890);
            this.Controls.Add(this.lblKQSoTour);
            this.Controls.Add(this.dgvTour);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.grbLocKQ);
            this.Controls.Add(this.btnNgoaiNuoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDatTour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmTour_Load);
            this.grbLocKQ.ResumeLayout(false);
            this.grbLocKQ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btlLocKQ;
        private System.Windows.Forms.Label lblThongTinVanChuyen;
        private System.Windows.Forms.Label lblSoNguoi;
        private System.Windows.Forms.DateTimePicker dtpNgayDi;
        private System.Windows.Forms.Label lblNgayDi;
        private System.Windows.Forms.Label lblDiemDen;
        private System.Windows.Forms.ComboBox cmbDiemDi;
        private System.Windows.Forms.Label lblDiemDi;
        private System.Windows.Forms.Button btnTrongNuoc;
        private System.Windows.Forms.GroupBox grbLocKQ;
        private System.Windows.Forms.ComboBox cmbDiemDen;
        private System.Windows.Forms.DataGridView dgvTour;
        private System.Windows.Forms.ComboBox cmbPhuongTien;
        private System.Windows.Forms.ComboBox cmbSoNgay;
        private System.Windows.Forms.Label lblSoNgay;
        private System.Windows.Forms.NumericUpDown numSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.Label lblKQSoTour;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnNgoaiNuoc;
    }
}