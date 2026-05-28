namespace WindowsFormsApp1.BanHang
{
    partial class form_suaSL
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
            this.lb_tenMH = new System.Windows.Forms.Label();
            this.tb_soLuong = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số lượng cho mặt hàng:";
            // 
            // lb_tenMH
            // 
            this.lb_tenMH.AutoSize = true;
            this.lb_tenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenMH.Location = new System.Drawing.Point(37, 67);
            this.lb_tenMH.Name = "lb_tenMH";
            this.lb_tenMH.Size = new System.Drawing.Size(53, 22);
            this.lb_tenMH.TabIndex = 1;
            this.lb_tenMH.Text = "label";
            // 
            // tb_soLuong
            // 
            this.tb_soLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_soLuong.Location = new System.Drawing.Point(41, 108);
            this.tb_soLuong.Name = "tb_soLuong";
            this.tb_soLuong.Size = new System.Drawing.Size(408, 22);
            this.tb_soLuong.TabIndex = 2;
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.Location = new System.Drawing.Point(263, 161);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(85, 47);
            this.btn_OK.TabIndex = 3;
            this.btn_OK.Text = "Xác nhận";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_huy.BackColor = System.Drawing.Color.Red;
            this.btn_huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.Location = new System.Drawing.Point(364, 161);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(85, 47);
            this.btn_huy.TabIndex = 4;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = false;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // form_suaSL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 220);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.tb_soLuong);
            this.Controls.Add(this.lb_tenMH);
            this.Controls.Add(this.label1);
            this.Name = "form_suaSL";
            this.Text = "Sửa số lượng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_tenMH;
        private System.Windows.Forms.TextBox tb_soLuong;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_huy;
    }
}