using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Class;
using WindowsFormsApp1.Menu;

namespace WindowsFormsApp1
{
    public partial class form_KhachHang : Form
    {

        string chuoiKetNoi = WindowsFormsApp1.Public.Public.str_conn;
        NhanVien user = new NhanVien();
        public form_KhachHang(NhanVien nv)
        {
            InitializeComponent();
            this.user = nv;
        }

        private void LoadDanhSachKhachHang()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                {
                    string query = "SELECT SoDienThoai, TenKH, DiaChi, DiemTichLuy, ConHoatDong FROM KhachHang";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();

                    da.Fill(dt);
                
                    dgvKhachHang.DataSource = dt;
                    dgvKhachHang.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chi tiết lỗi: " + ex.ToString(), "Lỗi Kết Nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void form_KhachHang_Load(object sender, EventArgs e)
        {

            LoadDanhSachKhachHang();
        }

        

        private void btn_Them_Click(object sender, EventArgs e)
        {
    
            if (string.IsNullOrWhiteSpace(txtSDT.Text) || string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                MessageBox.Show("Vui lòng nhập Số điện thoại và Tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtSDT.Text.Length > 15   )
            {
                MessageBox.Show("Số điện thoại không được vượt quá 15 ký tự! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!txtSDT.Text.All(char.IsDigit))
            {
                MessageBox.Show("vui lòng nhập số điện thoại là chuỗi các số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(!string.IsNullOrWhiteSpace(txtDiemtichluy.Text))
            {
                bool isInterger = int.TryParse(txtDiemtichluy.Text, out int diem);
                if (!isInterger || diem < 0)
                {
                    MessageBox.Show("Điểm tích lũy phải là một số nguyên dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                {
                    conn.Open();
                    
                    string query = "INSERT INTO KhachHang (SoDienThoai, TenKH, DiaChi, DiemTichLuy, ConHoatDong) " +
                                   "VALUES (@SDT, @TenKH, @DiaChi, @Diem, @ConHoatDong)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                        cmd.Parameters.AddWithValue("@TenKH", txtTenKH.Text);
                        cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);

                        int diem = 0;
                        if (!string.IsNullOrWhiteSpace(txtDiemtichluy.Text))
                            int.TryParse(txtDiemtichluy.Text, out diem);
                        cmd.Parameters.AddWithValue("@Diem", diem);

                        cmd.Parameters.AddWithValue("@ConHoatDong", chkHoatDong.Checked);

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachKhachHang(); 


                txtSDT.Enabled = true;
                txtSDT.Clear();
                txtTenKH.Clear();
                txtDiaChi.Clear();
                txtDiemtichluy.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Số điện thoại này đã tồn tại hoặc có lỗi xảy ra: \n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng chọn một khách hàng từ danh sách để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                {
                    conn.Open();
                    string query = "UPDATE KhachHang SET TenKH = @TenKH, DiaChi = @DiaChi, DiemTichLuy = @Diem, ConHoatDong = @ConHoatDong " +
                                   "WHERE SoDienThoai = @SDT";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenKH", txtTenKH.Text);
                        cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);

                        int diem = 0;
                        int.TryParse(txtDiemtichluy.Text, out diem);
                        cmd.Parameters.AddWithValue("@Diem", diem);

                        cmd.Parameters.AddWithValue("@ConHoatDong", chkHoatDong.Checked);
                        cmd.Parameters.AddWithValue("@SDT", txtSDT.Text); 

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDanhSachKhachHang(); 
                            txtSDT.Enabled = true; 
                        }
                    }
                }
                txtSDT.Clear();
                txtTenKH.Clear();
                txtDiaChi.Clear();
                txtDiemtichluy.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa dữ liệu: \n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng chọn một khách hàng từ danh sách để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                    {
                        conn.Open();
                        string query = "DELETE FROM KhachHang WHERE SoDienThoai = @SDT";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Đã xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachKhachHang(); 

                    txtSDT.Clear();
                    txtTenKH.Clear();
                    txtDiaChi.Clear();
                    txtDiemtichluy.Clear();
                    txtSDT.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa dữ liệu: \n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];

                
                txtSDT.Text = row.Cells["SoDienThoai"].Value.ToString();
                txtTenKH.Text = row.Cells["TenKH"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtDiemtichluy.Text = row.Cells["DiemTichLuy"].Value.ToString();

            
                if (row.Cells["ConHoatDong"].Value != DBNull.Value)
                {
                    chkHoatDong.Checked = Convert.ToBoolean(row.Cells["ConHoatDong"].Value);
                }

                
                txtSDT.Enabled = false;
            }
        }
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            
            string tuKhoa = txtTimKiem.Text.Trim();

            
            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                MessageBox.Show("Vui lòng nhập Số điện thoại hoặc Tên khách hàng cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool timThay = false;

            
            dgvKhachHang.ClearSelection();

            foreach (DataGridViewRow row in dgvKhachHang.Rows)
            {
                string sdt = row.Cells["SoDienThoai"].Value?.ToString() ?? "";
                string tenKH = row.Cells["TenKH"].Value?.ToString() ?? "";

                if (sdt.Contains(tuKhoa) || tenKH.ToLower().Contains(tuKhoa.ToLower()))
                {
                    row.Selected = true;

                    dgvKhachHang.FirstDisplayedScrollingRowIndex = row.Index;

                    timThay = true;

                    break;
                }
            }


            if (!timThay)
            {
                MessageBox.Show("Không tìm thấy khách hàng nào khớp với từ khóa: " + tuKhoa, "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
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
    }
}