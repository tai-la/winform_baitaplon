namespace WindowsFormsApp1
{
    partial class form_banHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_thanhToan = new System.Windows.Forms.Button();
            this.dgv_hoaDon = new System.Windows.Forms.DataGridView();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_totalCost = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_user = new System.Windows.Forms.Label();
            this.lb_khachHang = new System.Windows.Forms.Label();
            this.cb_timKiemKhachHang = new System.Windows.Forms.ComboBox();
            this.btn_themKhachHang = new System.Windows.Forms.Button();
            this.cb_timKiemHang = new System.Windows.Forms.ComboBox();
            this.lb_Diem = new System.Windows.Forms.Label();
            this.lb_point = new System.Windows.Forms.Label();
            this.lb_suDungDiem = new System.Windows.Forms.Label();
            this.radioBtn_Co = new System.Windows.Forms.RadioButton();
            this.radioBtn_Khong = new System.Windows.Forms.RadioButton();
            this.lb_giamGia = new System.Windows.Forms.Label();
            this.lb_giamGia_value = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.cb_khachVangLai = new System.Windows.Forms.CheckBox();
            this.lb_tichDiem = new System.Windows.Forms.Label();
            this.lb_tichDiem_value = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm mặt hàng";
            // 
            // btn_thanhToan
            // 
            this.btn_thanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_thanhToan.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_thanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thanhToan.ForeColor = System.Drawing.Color.White;
            this.btn_thanhToan.Location = new System.Drawing.Point(788, 563);
            this.btn_thanhToan.Name = "btn_thanhToan";
            this.btn_thanhToan.Size = new System.Drawing.Size(538, 54);
            this.btn_thanhToan.TabIndex = 2;
            this.btn_thanhToan.Text = "Thanh toán";
            this.btn_thanhToan.UseVisualStyleBackColor = false;
            this.btn_thanhToan.Click += new System.EventHandler(this.btn_thanhToan_Click);
            // 
            // dgv_hoaDon
            // 
            this.dgv_hoaDon.AllowUserToAddRows = false;
            this.dgv_hoaDon.AllowUserToResizeRows = false;
            this.dgv_hoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_hoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMH,
            this.TenMH,
            this.DVT,
            this.DonGia,
            this.SoLuong,
            this.ThanhTien});
            this.dgv_hoaDon.Location = new System.Drawing.Point(17, 70);
            this.dgv_hoaDon.Name = "dgv_hoaDon";
            this.dgv_hoaDon.RowHeadersWidth = 51;
            this.dgv_hoaDon.RowTemplate.Height = 24;
            this.dgv_hoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_hoaDon.Size = new System.Drawing.Size(743, 547);
            this.dgv_hoaDon.TabIndex = 3;
            // 
            // MaMH
            // 
            this.MaMH.HeaderText = "ID";
            this.MaMH.MinimumWidth = 6;
            this.MaMH.Name = "MaMH";
            // 
            // TenMH
            // 
            this.TenMH.HeaderText = "Tên mặt hàng";
            this.TenMH.MinimumWidth = 6;
            this.TenMH.Name = "TenMH";
            // 
            // DVT
            // 
            this.DVT.HeaderText = "ĐVT";
            this.DVT.MinimumWidth = 6;
            this.DVT.Name = "DVT";
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(784, 511);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng số tiền:";
            // 
            // lb_totalCost
            // 
            this.lb_totalCost.AutoSize = true;
            this.lb_totalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalCost.Location = new System.Drawing.Point(909, 511);
            this.lb_totalCost.Name = "lb_totalCost";
            this.lb_totalCost.Size = new System.Drawing.Size(35, 20);
            this.lb_totalCost.TabIndex = 5;
            this.lb_totalCost.Text = "0 đ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(819, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nhân viên:";
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_user.Location = new System.Drawing.Point(926, 70);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(49, 20);
            this.lb_user.TabIndex = 7;
            this.lb_user.Text = "label";
            // 
            // lb_khachHang
            // 
            this.lb_khachHang.AutoSize = true;
            this.lb_khachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_khachHang.Location = new System.Drawing.Point(804, 111);
            this.lb_khachHang.Name = "lb_khachHang";
            this.lb_khachHang.Size = new System.Drawing.Size(113, 20);
            this.lb_khachHang.TabIndex = 8;
            this.lb_khachHang.Text = "Khách hàng:";
            // 
            // cb_timKiemKhachHang
            // 
            this.cb_timKiemKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_timKiemKhachHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_timKiemKhachHang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_timKiemKhachHang.FormattingEnabled = true;
            this.cb_timKiemKhachHang.Location = new System.Drawing.Point(930, 107);
            this.cb_timKiemKhachHang.Name = "cb_timKiemKhachHang";
            this.cb_timKiemKhachHang.Size = new System.Drawing.Size(360, 24);
            this.cb_timKiemKhachHang.TabIndex = 9;
            this.cb_timKiemKhachHang.SelectedIndexChanged += new System.EventHandler(this.cb_timKiemKhachHang_SelectedIndexChanged);
            // 
            // btn_themKhachHang
            // 
            this.btn_themKhachHang.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_themKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themKhachHang.Location = new System.Drawing.Point(1296, 107);
            this.btn_themKhachHang.Name = "btn_themKhachHang";
            this.btn_themKhachHang.Size = new System.Drawing.Size(30, 24);
            this.btn_themKhachHang.TabIndex = 10;
            this.btn_themKhachHang.Text = "+";
            this.btn_themKhachHang.UseVisualStyleBackColor = true;
            this.btn_themKhachHang.Click += new System.EventHandler(this.btn_themKhachHang_Click);
            // 
            // cb_timKiemHang
            // 
            this.cb_timKiemHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_timKiemHang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_timKiemHang.FormattingEnabled = true;
            this.cb_timKiemHang.Location = new System.Drawing.Point(17, 37);
            this.cb_timKiemHang.Name = "cb_timKiemHang";
            this.cb_timKiemHang.Size = new System.Drawing.Size(743, 24);
            this.cb_timKiemHang.TabIndex = 11;
            this.cb_timKiemHang.SelectedValueChanged += new System.EventHandler(this.cb_timKiemHang_SelectedIndexChanged);
            // 
            // lb_Diem
            // 
            this.lb_Diem.AutoSize = true;
            this.lb_Diem.Enabled = false;
            this.lb_Diem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Diem.Location = new System.Drawing.Point(859, 168);
            this.lb_Diem.Name = "lb_Diem";
            this.lb_Diem.Size = new System.Drawing.Size(58, 20);
            this.lb_Diem.TabIndex = 12;
            this.lb_Diem.Text = "Điểm:";
            // 
            // lb_point
            // 
            this.lb_point.AutoSize = true;
            this.lb_point.Enabled = false;
            this.lb_point.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_point.Location = new System.Drawing.Point(933, 168);
            this.lb_point.Name = "lb_point";
            this.lb_point.Size = new System.Drawing.Size(19, 20);
            this.lb_point.TabIndex = 13;
            this.lb_point.Text = "0";
            // 
            // lb_suDungDiem
            // 
            this.lb_suDungDiem.AutoSize = true;
            this.lb_suDungDiem.Enabled = false;
            this.lb_suDungDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_suDungDiem.Location = new System.Drawing.Point(784, 202);
            this.lb_suDungDiem.Name = "lb_suDungDiem";
            this.lb_suDungDiem.Size = new System.Drawing.Size(133, 20);
            this.lb_suDungDiem.TabIndex = 14;
            this.lb_suDungDiem.Text = "Sử dụng điểm?";
            // 
            // radioBtn_Co
            // 
            this.radioBtn_Co.AutoSize = true;
            this.radioBtn_Co.Enabled = false;
            this.radioBtn_Co.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_Co.Location = new System.Drawing.Point(990, 196);
            this.radioBtn_Co.Name = "radioBtn_Co";
            this.radioBtn_Co.Size = new System.Drawing.Size(56, 26);
            this.radioBtn_Co.TabIndex = 15;
            this.radioBtn_Co.TabStop = true;
            this.radioBtn_Co.Text = "Có";
            this.radioBtn_Co.UseVisualStyleBackColor = true;
            this.radioBtn_Co.CheckedChanged += new System.EventHandler(this.radioBtn_Co_CheckedChanged);
            // 
            // radioBtn_Khong
            // 
            this.radioBtn_Khong.AutoSize = true;
            this.radioBtn_Khong.Enabled = false;
            this.radioBtn_Khong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_Khong.Location = new System.Drawing.Point(1074, 196);
            this.radioBtn_Khong.Name = "radioBtn_Khong";
            this.radioBtn_Khong.Size = new System.Drawing.Size(88, 26);
            this.radioBtn_Khong.TabIndex = 16;
            this.radioBtn_Khong.TabStop = true;
            this.radioBtn_Khong.Text = "Không";
            this.radioBtn_Khong.UseVisualStyleBackColor = true;
            // 
            // lb_giamGia
            // 
            this.lb_giamGia.AutoSize = true;
            this.lb_giamGia.Enabled = false;
            this.lb_giamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_giamGia.Location = new System.Drawing.Point(784, 477);
            this.lb_giamGia.Name = "lb_giamGia";
            this.lb_giamGia.Size = new System.Drawing.Size(90, 20);
            this.lb_giamGia.TabIndex = 17;
            this.lb_giamGia.Text = "Giảm giá:";
            // 
            // lb_giamGia_value
            // 
            this.lb_giamGia_value.AutoSize = true;
            this.lb_giamGia_value.Enabled = false;
            this.lb_giamGia_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_giamGia_value.Location = new System.Drawing.Point(880, 477);
            this.lb_giamGia_value.Name = "lb_giamGia_value";
            this.lb_giamGia_value.Size = new System.Drawing.Size(35, 20);
            this.lb_giamGia_value.TabIndex = 18;
            this.lb_giamGia_value.Text = "0 đ";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1190, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 43);
            this.button3.TabIndex = 19;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btn_Click_Exit);
            // 
            // cb_khachVangLai
            // 
            this.cb_khachVangLai.AutoSize = true;
            this.cb_khachVangLai.Location = new System.Drawing.Point(930, 137);
            this.cb_khachVangLai.Name = "cb_khachVangLai";
            this.cb_khachVangLai.Size = new System.Drawing.Size(116, 20);
            this.cb_khachVangLai.TabIndex = 22;
            this.cb_khachVangLai.Text = "Khách vãng lai";
            this.cb_khachVangLai.UseVisualStyleBackColor = true;
            this.cb_khachVangLai.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged_KhachVangLai);
            // 
            // lb_tichDiem
            // 
            this.lb_tichDiem.AutoSize = true;
            this.lb_tichDiem.Enabled = false;
            this.lb_tichDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tichDiem.Location = new System.Drawing.Point(784, 442);
            this.lb_tichDiem.Name = "lb_tichDiem";
            this.lb_tichDiem.Size = new System.Drawing.Size(97, 20);
            this.lb_tichDiem.TabIndex = 23;
            this.lb_tichDiem.Text = "Tích điểm:";
            // 
            // lb_tichDiem_value
            // 
            this.lb_tichDiem_value.AutoSize = true;
            this.lb_tichDiem_value.Enabled = false;
            this.lb_tichDiem_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tichDiem_value.Location = new System.Drawing.Point(887, 442);
            this.lb_tichDiem_value.Name = "lb_tichDiem_value";
            this.lb_tichDiem_value.Size = new System.Drawing.Size(19, 20);
            this.lb_tichDiem_value.TabIndex = 24;
            this.lb_tichDiem_value.Text = "0";
            // 
            // form_banHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 629);
            this.Controls.Add(this.lb_tichDiem_value);
            this.Controls.Add(this.lb_tichDiem);
            this.Controls.Add(this.cb_khachVangLai);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lb_giamGia_value);
            this.Controls.Add(this.lb_giamGia);
            this.Controls.Add(this.radioBtn_Khong);
            this.Controls.Add(this.radioBtn_Co);
            this.Controls.Add(this.lb_suDungDiem);
            this.Controls.Add(this.lb_point);
            this.Controls.Add(this.lb_Diem);
            this.Controls.Add(this.cb_timKiemHang);
            this.Controls.Add(this.btn_themKhachHang);
            this.Controls.Add(this.cb_timKiemKhachHang);
            this.Controls.Add(this.lb_khachHang);
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_totalCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_hoaDon);
            this.Controls.Add(this.btn_thanhToan);
            this.Controls.Add(this.label1);
            this.Name = "form_banHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán Hàng - Quản lý cửa hàng";
            this.Load += new System.EventHandler(this.form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_thanhToan;
        private System.Windows.Forms.DataGridView dgv_hoaDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_totalCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Label lb_khachHang;
        private System.Windows.Forms.ComboBox cb_timKiemKhachHang;
        private System.Windows.Forms.Button btn_themKhachHang;
        private System.Windows.Forms.ComboBox cb_timKiemHang;
        private System.Windows.Forms.Label lb_Diem;
        private System.Windows.Forms.Label lb_point;
        private System.Windows.Forms.Label lb_suDungDiem;
        private System.Windows.Forms.RadioButton radioBtn_Co;
        private System.Windows.Forms.RadioButton radioBtn_Khong;
        private System.Windows.Forms.Label lb_giamGia;
        private System.Windows.Forms.Label lb_giamGia_value;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox cb_khachVangLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Label lb_tichDiem;
        private System.Windows.Forms.Label lb_tichDiem_value;
    }
}