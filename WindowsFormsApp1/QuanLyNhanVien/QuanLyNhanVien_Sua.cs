using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlynhanvien
{
    public partial class QuanLyNhanVien_Sua : Form
    {
        string connectionString = WindowsFormsApp1.Public.Public.str_conn;

        string maNhanVienGoc = "";
        public QuanLyNhanVien_Sua(string ma, string ten, string sdt, string dc, string tdn, string mk, string vt)
        {
            InitializeComponent();
            maNhanVienGoc = ma;
            maNV.Text = ma;
            maNV.Enabled = false;
            name.Text = ten;
            phone.Text = sdt;
            address.Text = dc;
            tendangnhap.Text = tdn;
            pass.Text = mk;
            position.Text = vt;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "UPDATE NhanVien SET " +
                         "TenNV = N'" + name.Text + "', " +
                         "SoDienThoai = '" + phone.Text + "', " +
                         "DiaChi = N'" + address.Text + "', " +
                         "TenDangNhap = '" + tendangnhap.Text + "', " +
                         "MatKhau = '" + pass.Text + "', " +
                         "VaiTro = N'" + position.Text + "' " +
                         "WHERE MaNV = '" + maNhanVienGoc + "'";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Sửa thông tin thành công!");
            this.Close();
        }
    }
}
