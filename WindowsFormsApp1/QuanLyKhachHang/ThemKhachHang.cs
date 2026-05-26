using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Class;

namespace WindowsFormsApp1
{
    public partial class form_ThemKhachHang : Form
    {
        NhanVien user = new NhanVien();
        // Sử dụng lại chuỗi kết nối của bạn
        string chuoiKetNoi = WindowsFormsApp1.Public.Public.str_conn;

        public form_ThemKhachHang()
        {
            InitializeComponent();
            // Đặt vị trí xuất hiện ở giữa màn hình
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Thêm Khách Hàng Mới";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra nhập liệu
            if (string.IsNullOrWhiteSpace(txtSĐT.Text) || string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                MessageBox.Show("Vui lòng nhập Số điện thoại và Tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtSĐT.Text.Length > 15)
            {
                MessageBox.Show("Số điện thoại không được vượt quá 15 ký tự! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!txtSĐT.Text.All(char.IsDigit))
            {
                MessageBox.Show("vui lòng nhập số điện thoại là chuỗi các số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!string.IsNullOrWhiteSpace(txtDiemTichLuy.Text))
            {
                bool isInterger = int.TryParse(txtDiemTichLuy.Text, out int diem);
                if (!isInterger || diem < 0)
                {
                    MessageBox.Show("Điểm tích lũy phải là một số nguyên dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // 2. Thực hiện thêm vào CSDL
            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                {
                    conn.Open();
                    string query = "INSERT INTO KhachHang (SoDienThoai, TenKH, DiaChi, DiemTichLuy, ConHoatDong) " +
                                   "VALUES (@SDT, @TenKH, @DiaChi, @Diem, @TrangThai)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SDT", txtSĐT.Text.Trim());
                        cmd.Parameters.AddWithValue("@TenKH", txtTenKH.Text.Trim());
                        cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.Trim());
                        cmd.Parameters.AddWithValue("@Diem", 0); 
                        cmd.Parameters.AddWithValue("@TrangThai", chkConHoatDong.Checked);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Trả về kết quả OK để Form chính biết và Load lại bảng
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: SĐT có thể đã tồn tại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}