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
using WindowsFormsApp1;
using WindowsFormsApp1.Class;
using WindowsFormsApp1.Public;

namespace quanlynhanvien
{
    
    public partial class QuanLyNhanVien : Form
    {
        NhanVien user = new NhanVien();
        private string connectionString = WindowsFormsApp1.Public.Public.str_conn;
        public QuanLyNhanVien(NhanVien nv)
        {
            InitializeComponent();
            this.user = nv;
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM NhanVien";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                       hienthi.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(tendangnhap.Text) || string.IsNullOrWhiteSpace(pass.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc (Tên, Tài khoản, Mật khẩu)!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = @"INSERT INTO NhanVien (TenNV, SoDienThoai, DiaChi, TenDangNhap, MatKhau, VaiTro, DangLam) 
                           VALUES (@TenNV, @SDT, @DiaChi, @TenDangNhap, @MatKhau, @VaiTro, 1)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        string vitri = position.Text.Trim();
                        if (vitri == "Chủ cửa hàng") vitri = "admin";
                        else if (vitri == "Nhân viên") vitri = "staff";

                        cmd.Parameters.AddWithValue("@TenNV", name.Text.Trim());
                        cmd.Parameters.AddWithValue("@SDT", phone.Text.Trim());
                        cmd.Parameters.AddWithValue("@DiaChi", address.Text.Trim());
                        cmd.Parameters.AddWithValue("@TenDangNhap", tendangnhap.Text.Trim());
                        cmd.Parameters.AddWithValue("@MatKhau", pass.Text);
                        cmd.Parameters.AddWithValue("@VaiTro", vitri);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Thêm nhân viên mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
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

        private void modify_Click(object sender, EventArgs e)
        {
            if (hienthi.CurrentRow == null || hienthi.CurrentRow.Cells["MaNV"].Value == null)
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để sửa thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string ma = Convert.ToString(hienthi.CurrentRow.Cells["MaNV"].Value);
            string ten = Convert.ToString(hienthi.CurrentRow.Cells["TenNV"].Value);
            string sdt = Convert.ToString(hienthi.CurrentRow.Cells["SoDienThoai"].Value);
            string dc = Convert.ToString(hienthi.CurrentRow.Cells["DiaChi"].Value);
            string tdn = Convert.ToString(hienthi.CurrentRow.Cells["TenDangNhap"].Value);
            string mk = Convert.ToString(hienthi.CurrentRow.Cells["MatKhau"].Value);
            string vt = Convert.ToString(hienthi.CurrentRow.Cells["VaiTro"].Value);

            QuanLyNhanVien_Sua frm = new QuanLyNhanVien_Sua(ma, ten, sdt, dc, tdn, mk, vt);
            frm.ShowDialog();

            LoadData();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (hienthi.CurrentRow == null || hienthi.CurrentRow.Cells["MaNV"].Value == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maCanXoa = hienthi.CurrentRow.Cells["MaNV"].Value.ToString();

            DialogResult dialogResult = MessageBox.Show($"Sếp có chắc chắn muốn xóa nhân viên mã: {maCanXoa} không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = "DELETE FROM NhanVien WHERE MaNV = @MaNV";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNV", maCanXoa);

                        int rowsAffected = cmd.ExecuteNonQuery(); 

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Đã xóa nhân viên có mã {maCanXoa} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData(); 
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy nhân viên này trong CSDL.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("Không thể xóa nhân viên này vì họ đã tham gia vào các giao dịch (hóa đơn, phiếu nhập...).", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void thoat_Click(object sender, EventArgs e)
        {
            form_Menu form = new form_Menu(user);
            form.Show();
            this.Close();
            return;
        }

        private void find_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "SELECT * FROM NhanVien WHERE TenNV LIKE N'%" + search.Text + "%' OR SoDienThoai LIKE '%" + search.Text + "%'";

            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            hienthi.DataSource = dt;

            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
