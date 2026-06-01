namespace WindowsFormsApp1.QuanLyDonHang
{
    partial class QuanLyDonHang_ChiTiet
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
            this.dgv_ChiTiet = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ChiTiet
            // 
            this.dgv_ChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ChiTiet.Location = new System.Drawing.Point(0, 0);
            this.dgv_ChiTiet.Name = "dgv_ChiTiet";
            this.dgv_ChiTiet.RowHeadersWidth = 51;
            this.dgv_ChiTiet.RowTemplate.Height = 24;
            this.dgv_ChiTiet.Size = new System.Drawing.Size(1332, 450);
            this.dgv_ChiTiet.TabIndex = 0;
            // 
            // QuanLyDonHang_ChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 450);
            this.Controls.Add(this.dgv_ChiTiet);
            this.Name = "QuanLyDonHang_ChiTiet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_chiTietDonHang";
            this.Load += new System.EventHandler(this.QuanLyDonHang_ChiTiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ChiTiet;
    }
}