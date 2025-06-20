namespace QL_TOUR
{
    partial class frmMainn
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
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblXinChao = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pnlTrangChuContainer = new System.Windows.Forms.Panel();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.pnlTourContainer = new System.Windows.Forms.Panel();
            this.btnTour = new System.Windows.Forms.Button();
            this.pnlHoaDonContainer = new System.Windows.Forms.Panel();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.pnlQLTTContainer = new System.Windows.Forms.Panel();
            this.btnQLTT = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            this.pnlTrangChuContainer.SuspendLayout();
            this.pnlTourContainer.SuspendLayout();
            this.pnlHoaDonContainer.SuspendLayout();
            this.pnlQLTTContainer.SuspendLayout();
            this.pnlNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Location = new System.Drawing.Point(1142, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 9;
            this.btnMinimize.Text = "—";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1178, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblXinChao
            // 
            this.lblXinChao.AutoSize = true;
            this.lblXinChao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXinChao.ForeColor = System.Drawing.Color.White;
            this.lblXinChao.Location = new System.Drawing.Point(939, 12);
            this.lblXinChao.Name = "lblXinChao";
            this.lblXinChao.Size = new System.Drawing.Size(80, 21);
            this.lblXinChao.TabIndex = 5;
            this.lblXinChao.Text = "Xin chào:";
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.Snow;
            this.panelChildForm.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelChildForm.Location = new System.Drawing.Point(14, 140);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1192, 768);
            this.panelChildForm.TabIndex = 2;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlTop.Controls.Add(this.btnLogOut);
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.lblXinChao);
            this.pnlTop.Controls.Add(this.pnlNav);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1220, 134);
            this.pnlTop.TabIndex = 3;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = global::QL_TOUR.Properties.Resources.icons8_exit_60;
            this.btnLogOut.Location = new System.Drawing.Point(1077, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(59, 30);
            this.btnLogOut.TabIndex = 10;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pnlTrangChuContainer
            // 
            this.pnlTrangChuContainer.Controls.Add(this.btnTrangChu);
            this.pnlTrangChuContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTrangChuContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlTrangChuContainer.Name = "pnlTrangChuContainer";
            this.pnlTrangChuContainer.Size = new System.Drawing.Size(210, 52);
            this.pnlTrangChuContainer.TabIndex = 1;
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTrangChu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTrangChu.FlatAppearance.BorderSize = 0;
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.ForeColor = System.Drawing.Color.White;
            this.btnTrangChu.Image = global::QL_TOUR.Properties.Resources.icons8_home_50;
            this.btnTrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu.Location = new System.Drawing.Point(0, 0);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(193, 52);
            this.btnTrangChu.TabIndex = 1;
            this.btnTrangChu.Text = "  Trang chủ";
            this.btnTrangChu.UseVisualStyleBackColor = false;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click_1);
            // 
            // pnlTourContainer
            // 
            this.pnlTourContainer.Controls.Add(this.btnTour);
            this.pnlTourContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTourContainer.Location = new System.Drawing.Point(210, 0);
            this.pnlTourContainer.Name = "pnlTourContainer";
            this.pnlTourContainer.Size = new System.Drawing.Size(209, 52);
            this.pnlTourContainer.TabIndex = 2;
            // 
            // btnTour
            // 
            this.btnTour.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTour.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTour.FlatAppearance.BorderSize = 0;
            this.btnTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTour.ForeColor = System.Drawing.Color.White;
            this.btnTour.Image = global::QL_TOUR.Properties.Resources.icons8_tour_bus_50;
            this.btnTour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTour.Location = new System.Drawing.Point(0, 0);
            this.btnTour.Name = "btnTour";
            this.btnTour.Size = new System.Drawing.Size(192, 52);
            this.btnTour.TabIndex = 2;
            this.btnTour.TabStop = false;
            this.btnTour.Text = "Tour";
            this.btnTour.UseVisualStyleBackColor = false;
            this.btnTour.Click += new System.EventHandler(this.btnTour_Click);
            // 
            // pnlHoaDonContainer
            // 
            this.pnlHoaDonContainer.Controls.Add(this.btnHoaDon);
            this.pnlHoaDonContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlHoaDonContainer.Location = new System.Drawing.Point(419, 0);
            this.pnlHoaDonContainer.Name = "pnlHoaDonContainer";
            this.pnlHoaDonContainer.Size = new System.Drawing.Size(180, 52);
            this.pnlHoaDonContainer.TabIndex = 3;
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHoaDon.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHoaDon.FlatAppearance.BorderSize = 0;
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnHoaDon.Location = new System.Drawing.Point(0, 0);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(162, 52);
            this.btnHoaDon.TabIndex = 4;
            this.btnHoaDon.Text = "Quản lý hóa đơn";
            this.btnHoaDon.UseVisualStyleBackColor = false;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // pnlQLTTContainer
            // 
            this.pnlQLTTContainer.Controls.Add(this.btnQLTT);
            this.pnlQLTTContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlQLTTContainer.Location = new System.Drawing.Point(599, 0);
            this.pnlQLTTContainer.Name = "pnlQLTTContainer";
            this.pnlQLTTContainer.Size = new System.Drawing.Size(180, 52);
            this.pnlQLTTContainer.TabIndex = 4;
            // 
            // btnQLTT
            // 
            this.btnQLTT.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnQLTT.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnQLTT.FlatAppearance.BorderSize = 0;
            this.btnQLTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLTT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLTT.ForeColor = System.Drawing.Color.White;
            this.btnQLTT.Location = new System.Drawing.Point(0, 0);
            this.btnQLTT.Name = "btnQLTT";
            this.btnQLTT.Size = new System.Drawing.Size(171, 52);
            this.btnQLTT.TabIndex = 5;
            this.btnQLTT.Text = "Quản lý thông tin";
            this.btnQLTT.UseVisualStyleBackColor = false;
            this.btnQLTT.Click += new System.EventHandler(this.btnQLTT_Click);
            // 
            // pnlNav
            // 
            this.pnlNav.Controls.Add(this.pnlQLTTContainer);
            this.pnlNav.Controls.Add(this.pnlHoaDonContainer);
            this.pnlNav.Controls.Add(this.pnlTourContainer);
            this.pnlNav.Controls.Add(this.pnlTrangChuContainer);
            this.pnlNav.Location = new System.Drawing.Point(249, 62);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(779, 52);
            this.pnlNav.TabIndex = 0;
            // 
            // frmMainn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1220, 920);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.pnlTop);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMainn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMainn_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlTrangChuContainer.ResumeLayout(false);
            this.pnlTourContainer.ResumeLayout(false);
            this.pnlHoaDonContainer.ResumeLayout(false);
            this.pnlQLTTContainer.ResumeLayout(false);
            this.pnlNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel pnlTop;
        public System.Windows.Forms.Label lblXinChao;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel pnlQLTTContainer;
        public System.Windows.Forms.Button btnQLTT;
        private System.Windows.Forms.Panel pnlHoaDonContainer;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Panel pnlTourContainer;
        private System.Windows.Forms.Button btnTour;
        private System.Windows.Forms.Panel pnlTrangChuContainer;
        private System.Windows.Forms.Button btnTrangChu;
    }
}