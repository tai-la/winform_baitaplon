using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.BanHang
{
    public partial class form_suaSL : Form
    {
        public int SoLuongMoi { get; private set; }
        public form_suaSL(string tenHang, int soLuongHienTai)
        {
            InitializeComponent();
            lb_tenMH.Text = tenHang;
            tb_soLuong.Text = soLuongHienTai.ToString();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tb_soLuong.Text, out int result) && result > 0)
            {
                SoLuongMoi = result; 
                this.DialogResult = DialogResult.OK; 
                this.Close();
            }
            else
            {
                MessageBox.Show("Số lượng phải là số nguyên lớn hơn 0!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
