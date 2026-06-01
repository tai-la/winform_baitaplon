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
using WindowsFormsApp1;
using WindowsFormsApp1.Class;
using WindowsFormsApp1.Menu;

namespace QuanLyMatHang
{
    public partial class form_quanLyMatHang : Form
    {
        NhanVien user = new NhanVien();
        string connectionString = WindowsFormsApp1.Public.Public.str_conn;
        public form_quanLyMatHang(NhanVien nv)
        {
            InitializeComponent();
            this.user = nv;
        }
        private void LoadData()
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                string query = "SELECT MaMH, TenMH, DVT, GiaNhap, GiaBan, SoLuongTon, ConBan FROM MatHang WHERE ConBan = 1";


                SqlDataAdapter da = new SqlDataAdapter(query, conn);


                DataTable dt = new DataTable();


                da.Fill(dt);


                dgvDanhSach.DataSource = dt;
            }
        }

        private void cbbDonVi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTenMH_Click(object sender, EventArgs e)
        {

        }

        private void txtTenMH_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudGiaBan_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudTon_ValueChanged(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            txtTimKiem.Text = "Nhập tên/mã mặt hàng cần tìm....";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenMH.Text == "" || cbbDonVi.Text == "" || nudGiaNhap.Value == 0 || nudGiaBan.Value == 0 || nudSoLuongTon.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin mặt hàng!");
                return;
            }


            string query = "INSERT INTO MatHang (TenMH, DVT, GiaNhap, GiaBan, SoLuongTon, ConBan) VALUES (@TenMH, @DVT, @GiaNhap, @GiaBan, @SoLuongTon, 1)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);


                cmd.Parameters.AddWithValue("@TenMH", txtTenMH.Text);
                cmd.Parameters.AddWithValue("@DVT", cbbDonVi.Text);
                cmd.Parameters.AddWithValue("@GiaNhap", nudGiaNhap.Value);
                cmd.Parameters.AddWithValue("@GiaBan", nudGiaBan.Value);
                cmd.Parameters.AddWithValue("@SoLuongTon", nudSoLuongTon.Value);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("Đã thêm mặt hàng mới thành công!");
            LoadData();
            txtTenMH.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            if (txtTimKiem.Text == "")
            {
                LoadData();
                return;
            }


            string query = "SELECT MaMH, TenMH, DVT, GiaNhap, GiaBan, SoLuongTon, ConBan FROM MatHang WHERE ConBan = 1 AND (MaMH LIKE @TuKhoa OR TenMH LIKE @TuKhoa)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@TuKhoa", "%" + txtTimKiem.Text + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvDanhSach.DataSource = dt;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (txtMaMH.Text == "")
            {
                MessageBox.Show("Hãy chọn 1 mặt hàng dưới bảng để xóa!");
                return;
            }


            string query = "UPDATE MatHang SET ConBan = 0 WHERE MaMH = @MaMH";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaMH", txtMaMH.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("Đã xóa mặt hàng thành công!");
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (txtMaMH.Text == "")
            {
                MessageBox.Show("Hãy chọn 1 mặt hàng ở bảng bên phải trước!");
                return;
            }


            string query = "UPDATE MatHang SET TenMH = @TenMH, DVT = @DVT, GiaNhap = @GiaNhap, GiaBan = @GiaBan, SoLuongTon = @SoLuongTon WHERE MaMH = @MaMH";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@MaMH", txtMaMH.Text);
                cmd.Parameters.AddWithValue("@TenMH", txtTenMH.Text);
                cmd.Parameters.AddWithValue("@DVT", cbbDonVi.Text);
                cmd.Parameters.AddWithValue("@GiaNhap", nudGiaNhap.Value);
                cmd.Parameters.AddWithValue("@GiaBan", nudGiaBan.Value);
                cmd.Parameters.AddWithValue("@SoLuongTon", nudSoLuongTon.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                txtTenMH.Text = "";
                cbbDonVi.Text = "";
                nudGiaBan.Value = 0;
                nudGiaNhap.Value = 0;
                nudSoLuongTon.Value= 0;
                txtMaMH.Clear();
            }

            MessageBox.Show("Đã sửa thông tin thành công!");
            LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (user.Role == "admin")
            {
                form_Menu_admin menu = new form_Menu_admin(user);
                menu.Show();
                this.Hide();
                return;
            }
            else
            {
                form_Menu menu = new form_Menu(user);
                menu.Show();
                this.Hide();
                return;
            }
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDanhSach.Rows[e.RowIndex];

                txtMaMH.Text = row.Cells["MaMH"].Value.ToString();
                txtTenMH.Text = row.Cells["TenMH"].Value.ToString();
                cbbDonVi.Text = row.Cells["DVT"].Value.ToString();
                nudGiaNhap.Value = Convert.ToDecimal(row.Cells["GiaNhap"].Value);
                nudGiaBan.Value = Convert.ToDecimal(row.Cells["GiaBan"].Value);
                nudSoLuongTon.Value = Convert.ToInt32(row.Cells["SoLuongTon"].Value);
            }
        } 
    }
    
}
