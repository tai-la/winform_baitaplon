namespace QuanLyMatHang
{
    partial class form_quanLyMatHang
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grbNhap = new System.Windows.Forms.GroupBox();
            this.nudSoLuongTon = new System.Windows.Forms.NumericUpDown();
            this.lblGiaNhap = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbbDonVi = new System.Windows.Forms.ComboBox();
            this.nudGiaNhap = new System.Windows.Forms.NumericUpDown();
            this.nudGiaBan = new System.Windows.Forms.NumericUpDown();
            this.lblSoLuongTon = new System.Windows.Forms.Label();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.lblDonVi = new System.Windows.Forms.Label();
            this.lblTenMH = new System.Windows.Forms.Label();
            this.lblMaMH = new System.Windows.Forms.Label();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.grbDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.pnTimKiem = new System.Windows.Forms.Panel();
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grbNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongTon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaBan)).BeginInit();
            this.grbDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.pnTimKiem.SuspendLayout();
            this.grbTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grbNhap);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grbDanhSach);
            this.splitContainer1.Panel2.Controls.Add(this.pnTimKiem);
            this.splitContainer1.Size = new System.Drawing.Size(1147, 542);
            this.splitContainer1.SplitterDistance = 415;
            this.splitContainer1.TabIndex = 0;
            // 
            // grbNhap
            // 
            this.grbNhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grbNhap.Controls.Add(this.nudSoLuongTon);
            this.grbNhap.Controls.Add(this.lblGiaNhap);
            this.grbNhap.Controls.Add(this.btnThoat);
            this.grbNhap.Controls.Add(this.btnSua);
            this.grbNhap.Controls.Add(this.btnXoa);
            this.grbNhap.Controls.Add(this.btnThem);
            this.grbNhap.Controls.Add(this.cbbDonVi);
            this.grbNhap.Controls.Add(this.nudGiaNhap);
            this.grbNhap.Controls.Add(this.nudGiaBan);
            this.grbNhap.Controls.Add(this.lblSoLuongTon);
            this.grbNhap.Controls.Add(this.lblGiaBan);
            this.grbNhap.Controls.Add(this.lblDonVi);
            this.grbNhap.Controls.Add(this.lblTenMH);
            this.grbNhap.Controls.Add(this.lblMaMH);
            this.grbNhap.Controls.Add(this.txtTenMH);
            this.grbNhap.Controls.Add(this.txtMaMH);
            this.grbNhap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNhap.ForeColor = System.Drawing.Color.Navy;
            this.grbNhap.Location = new System.Drawing.Point(0, 0);
            this.grbNhap.Name = "grbNhap";
            this.grbNhap.Size = new System.Drawing.Size(411, 538);
            this.grbNhap.TabIndex = 0;
            this.grbNhap.TabStop = false;
            this.grbNhap.Text = "Thông Tin Mặt Hàng";
            // 
            // nudSoLuongTon
            // 
            this.nudSoLuongTon.Location = new System.Drawing.Point(146, 371);
            this.nudSoLuongTon.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSoLuongTon.Name = "nudSoLuongTon";
            this.nudSoLuongTon.Size = new System.Drawing.Size(242, 30);
            this.nudSoLuongTon.TabIndex = 18;
            // 
            // lblGiaNhap
            // 
            this.lblGiaNhap.AutoSize = true;
            this.lblGiaNhap.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaNhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGiaNhap.Location = new System.Drawing.Point(10, 257);
            this.lblGiaNhap.Name = "lblGiaNhap";
            this.lblGiaNhap.Size = new System.Drawing.Size(109, 19);
            this.lblGiaNhap.TabIndex = 17;
            this.lblGiaNhap.Text = "Giá nhập (VNĐ)";
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThoat.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(312, 472);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(76, 56);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(120, 472);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(76, 56);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.BackColor = System.Drawing.Color.OrangeRed;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(221, 472);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(76, 56);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.BackColor = System.Drawing.Color.LimeGreen;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(23, 472);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(76, 56);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbbDonVi
            // 
            this.cbbDonVi.FormattingEnabled = true;
            this.cbbDonVi.Items.AddRange(new object[] {
            "Chai",
            "Lọ",
            "Chiếc",
            "Đôi",
            "Thùng",
            "Hộp"});
            this.cbbDonVi.Location = new System.Drawing.Point(120, 190);
            this.cbbDonVi.Name = "cbbDonVi";
            this.cbbDonVi.Size = new System.Drawing.Size(267, 31);
            this.cbbDonVi.TabIndex = 12;
            this.cbbDonVi.SelectedIndexChanged += new System.EventHandler(this.cbbDonVi_SelectedIndexChanged);
            // 
            // nudGiaNhap
            // 
            this.nudGiaNhap.Location = new System.Drawing.Point(146, 311);
            this.nudGiaNhap.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudGiaNhap.Name = "nudGiaNhap";
            this.nudGiaNhap.Size = new System.Drawing.Size(242, 30);
            this.nudGiaNhap.TabIndex = 11;
            this.nudGiaNhap.ThousandsSeparator = true;
            this.nudGiaNhap.ValueChanged += new System.EventHandler(this.nudTon_ValueChanged);
            // 
            // nudGiaBan
            // 
            this.nudGiaBan.Location = new System.Drawing.Point(145, 249);
            this.nudGiaBan.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudGiaBan.Name = "nudGiaBan";
            this.nudGiaBan.Size = new System.Drawing.Size(242, 30);
            this.nudGiaBan.TabIndex = 10;
            this.nudGiaBan.ThousandsSeparator = true;
            this.nudGiaBan.ValueChanged += new System.EventHandler(this.nudGiaBan_ValueChanged);
            // 
            // lblSoLuongTon
            // 
            this.lblSoLuongTon.AutoSize = true;
            this.lblSoLuongTon.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongTon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSoLuongTon.Location = new System.Drawing.Point(10, 379);
            this.lblSoLuongTon.Name = "lblSoLuongTon";
            this.lblSoLuongTon.Size = new System.Drawing.Size(98, 19);
            this.lblSoLuongTon.TabIndex = 9;
            this.lblSoLuongTon.Text = "Số Lượng Tồn";
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaBan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGiaBan.Location = new System.Drawing.Point(10, 319);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(101, 19);
            this.lblGiaBan.TabIndex = 8;
            this.lblGiaBan.Text = "Giá bán (VNĐ)";
            // 
            // lblDonVi
            // 
            this.lblDonVi.AutoSize = true;
            this.lblDonVi.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonVi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDonVi.Location = new System.Drawing.Point(10, 199);
            this.lblDonVi.Name = "lblDonVi";
            this.lblDonVi.Size = new System.Drawing.Size(80, 19);
            this.lblDonVi.TabIndex = 7;
            this.lblDonVi.Text = "Đơn vị tính";
            // 
            // lblTenMH
            // 
            this.lblTenMH.AutoSize = true;
            this.lblTenMH.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTenMH.Location = new System.Drawing.Point(10, 131);
            this.lblTenMH.Name = "lblTenMH";
            this.lblTenMH.Size = new System.Drawing.Size(94, 19);
            this.lblTenMH.TabIndex = 6;
            this.lblTenMH.Text = "Tên mặt hàng";
            this.lblTenMH.Click += new System.EventHandler(this.lblTenMH_Click);
            // 
            // lblMaMH
            // 
            this.lblMaMH.AutoSize = true;
            this.lblMaMH.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaMH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMaMH.Location = new System.Drawing.Point(10, 62);
            this.lblMaMH.Name = "lblMaMH";
            this.lblMaMH.Size = new System.Drawing.Size(92, 19);
            this.lblMaMH.TabIndex = 5;
            this.lblMaMH.Text = "Mã mặt hàng";
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(120, 122);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(267, 30);
            this.txtTenMH.TabIndex = 1;
            this.txtTenMH.TextChanged += new System.EventHandler(this.txtTenMH_TextChanged);
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(121, 53);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.ReadOnly = true;
            this.txtMaMH.Size = new System.Drawing.Size(267, 30);
            this.txtMaMH.TabIndex = 0;
            this.txtMaMH.Text = "🔒";
            // 
            // grbDanhSach
            // 
            this.grbDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbDanhSach.Controls.Add(this.dgvDanhSach);
            this.grbDanhSach.Location = new System.Drawing.Point(4, 88);
            this.grbDanhSach.Name = "grbDanhSach";
            this.grbDanhSach.Size = new System.Drawing.Size(718, 452);
            this.grbDanhSach.TabIndex = 2;
            this.grbDanhSach.TabStop = false;
            this.grbDanhSach.Text = "Danh sách mặt hàng";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AllowUserToAddRows = false;
            this.dgvDanhSach.AllowUserToDeleteRows = false;
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSach.Location = new System.Drawing.Point(3, 21);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.RowHeadersWidth = 62;
            this.dgvDanhSach.RowTemplate.Height = 28;
            this.dgvDanhSach.Size = new System.Drawing.Size(712, 428);
            this.dgvDanhSach.TabIndex = 0;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
            // 
            // pnTimKiem
            // 
            this.pnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnTimKiem.BackColor = System.Drawing.Color.LightGray;
            this.pnTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnTimKiem.Controls.Add(this.grbTimKiem);
            this.pnTimKiem.Location = new System.Drawing.Point(3, 3);
            this.pnTimKiem.Name = "pnTimKiem";
            this.pnTimKiem.Size = new System.Drawing.Size(719, 80);
            this.pnTimKiem.TabIndex = 1;
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbTimKiem.Controls.Add(this.btnTimKiem);
            this.grbTimKiem.Controls.Add(this.txtTimKiem);
            this.grbTimKiem.ForeColor = System.Drawing.Color.Navy;
            this.grbTimKiem.Location = new System.Drawing.Point(0, 0);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Size = new System.Drawing.Size(716, 78);
            this.grbTimKiem.TabIndex = 0;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Tìm Kiếm Mặt Hàng";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTimKiem.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnTimKiem.Location = new System.Drawing.Point(569, 19);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(114, 44);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "🔍 Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(6, 28);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(534, 32);
            this.txtTimKiem.TabIndex = 0;
            // 
            // form_quanLyMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1147, 542);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "form_quanLyMatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Mặt Hàng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grbNhap.ResumeLayout(false);
            this.grbNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongTon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaBan)).EndInit();
            this.grbDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.pnTimKiem.ResumeLayout(false);
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grbNhap;
        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.Panel pnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblSoLuongTon;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.Label lblDonVi;
        private System.Windows.Forms.Label lblTenMH;
        private System.Windows.Forms.Label lblMaMH;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.NumericUpDown nudGiaBan;
        private System.Windows.Forms.ComboBox cbbDonVi;
        private System.Windows.Forms.NumericUpDown nudGiaNhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grbDanhSach;
        private System.Windows.Forms.Label lblGiaNhap;
        private System.Windows.Forms.NumericUpDown nudSoLuongTon;
        private System.Windows.Forms.DataGridView dgvDanhSach;
    }
}

