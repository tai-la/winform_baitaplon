namespace WindowsFormsApp1.Menu
{
    partial class form_Menu_admin
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
            this.tb_Greeting = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_quanLyNhanVien = new System.Windows.Forms.Button();
            this.btn_quanLyKhachHang = new System.Windows.Forms.Button();
            this.btn_quanLyMatHang = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_quanLyDonHang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Greeting
            // 
            this.tb_Greeting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_Greeting.AutoSize = true;
            this.tb_Greeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Greeting.Location = new System.Drawing.Point(68, 471);
            this.tb_Greeting.Name = "tb_Greeting";
            this.tb_Greeting.Size = new System.Drawing.Size(85, 29);
            this.tb_Greeting.TabIndex = 12;
            this.tb_Greeting.Text = "label1";
            // 
            // btn_Logout
            // 
            this.btn_Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Logout.BackColor = System.Drawing.Color.Red;
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.White;
            this.btn_Logout.Location = new System.Drawing.Point(590, 457);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(162, 57);
            this.btn_Logout.TabIndex = 11;
            this.btn_Logout.Text = "Đăng xuất";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Click_Logout);
            // 
            // btn_quanLyNhanVien
            // 
            this.btn_quanLyNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quanLyNhanVien.Location = new System.Drawing.Point(73, 193);
            this.btn_quanLyNhanVien.Name = "btn_quanLyNhanVien";
            this.btn_quanLyNhanVien.Size = new System.Drawing.Size(285, 107);
            this.btn_quanLyNhanVien.TabIndex = 10;
            this.btn_quanLyNhanVien.Text = "Quản lý nhân viên";
            this.btn_quanLyNhanVien.UseVisualStyleBackColor = true;
            this.btn_quanLyNhanVien.Click += new System.EventHandler(this.btn_Click_QuanLyNhanVien);
            // 
            // btn_quanLyKhachHang
            // 
            this.btn_quanLyKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quanLyKhachHang.Location = new System.Drawing.Point(401, 50);
            this.btn_quanLyKhachHang.Name = "btn_quanLyKhachHang";
            this.btn_quanLyKhachHang.Size = new System.Drawing.Size(285, 107);
            this.btn_quanLyKhachHang.TabIndex = 9;
            this.btn_quanLyKhachHang.Text = "Quản lý khách hàng";
            this.btn_quanLyKhachHang.UseVisualStyleBackColor = true;
            this.btn_quanLyKhachHang.Click += new System.EventHandler(this.btn_quanLyKhachHang_Click);
            // 
            // btn_quanLyMatHang
            // 
            this.btn_quanLyMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quanLyMatHang.Location = new System.Drawing.Point(73, 50);
            this.btn_quanLyMatHang.Name = "btn_quanLyMatHang";
            this.btn_quanLyMatHang.Size = new System.Drawing.Size(285, 107);
            this.btn_quanLyMatHang.TabIndex = 8;
            this.btn_quanLyMatHang.Text = "Quản lý mặt hàng";
            this.btn_quanLyMatHang.UseVisualStyleBackColor = true;
            this.btn_quanLyMatHang.Click += new System.EventHandler(this.btn_quanLyMatHang_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(401, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 107);
            this.button1.TabIndex = 7;
            this.button1.Text = "Bán hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_Click_BanHang);
            // 
            // btn_quanLyDonHang
            // 
            this.btn_quanLyDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quanLyDonHang.Location = new System.Drawing.Point(236, 332);
            this.btn_quanLyDonHang.Name = "btn_quanLyDonHang";
            this.btn_quanLyDonHang.Size = new System.Drawing.Size(285, 116);
            this.btn_quanLyDonHang.TabIndex = 13;
            this.btn_quanLyDonHang.Text = "Quản lý đơn hàng";
            this.btn_quanLyDonHang.UseVisualStyleBackColor = true;
            this.btn_quanLyDonHang.Click += new System.EventHandler(this.btn_quanLyDonHang_Click);
            // 
            // form_Menu_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 540);
            this.Controls.Add(this.btn_quanLyDonHang);
            this.Controls.Add(this.tb_Greeting);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_quanLyNhanVien);
            this.Controls.Add(this.btn_quanLyKhachHang);
            this.Controls.Add(this.btn_quanLyMatHang);
            this.Controls.Add(this.button1);
            this.Name = "form_Menu_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_Menu_admin";
            this.Load += new System.EventHandler(this.form_Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tb_Greeting;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_quanLyNhanVien;
        private System.Windows.Forms.Button btn_quanLyKhachHang;
        private System.Windows.Forms.Button btn_quanLyMatHang;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_quanLyDonHang;
    }
}