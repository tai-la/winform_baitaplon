using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlynhanvien
{
    public partial class QuanLyNhanVien_Sua : Form
    {
        string connectionString = WindowsFormsApp1.Public.Public.str_conn;
        public string vitri = "";
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

            if (vt == "admin")
            {
                position.Text = "Chủ cửa hàng";
            }
            else
            {
                position.Text = "Nhân viên";
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(tendangnhap.Text) || string.IsNullOrWhiteSpace(pass.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string vitriLuu = position.Text.Trim();
            if (vitriLuu == "Chủ cửa hàng") vitriLuu = "admin";
            else if (vitriLuu == "Nhân viên") vitriLuu = "staff";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = @"UPDATE NhanVien SET 
                           TenNV = @TenNV, 
                           SoDienThoai = @SoDienThoai, 
                           DiaChi = @DiaChi, 
                           TenDangNhap = @TenDangNhap, 
                           MatKhau = @MatKhau, 
                           VaiTro = @VaiTro 
                           WHERE MaNV = @MaNV";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenNV", name.Text.Trim());
                        cmd.Parameters.AddWithValue("@SoDienThoai", phone.Text.Trim());
                        cmd.Parameters.AddWithValue("@DiaChi", address.Text.Trim());
                        cmd.Parameters.AddWithValue("@TenDangNhap", tendangnhap.Text.Trim());
                        cmd.Parameters.AddWithValue("@MatKhau", pass.Text);
                        cmd.Parameters.AddWithValue("@VaiTro", vitriLuu);
                        cmd.Parameters.AddWithValue("@MaNV", maNhanVienGoc);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show("Tên đăng nhập này đã tồn tại! Vui lòng chọn tên khác.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lỗi CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
