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
using WindowsFormsApp1.Class;
using WindowsFormsApp1.Menu;

namespace WindowsFormsApp1.QuanLyDonHang
{
    public partial class form_quanLyDonHang : Form
    {
        NhanVien user = new NhanVien();
        public form_quanLyDonHang(NhanVien nv)
        {
            user = nv;
            InitializeComponent();
            LoadAllDonHang();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            string keyword = tb_input.Text.Trim();
            if (string.IsNullOrEmpty(keyword) )
            {
                MessageBox.Show("Không được để trống");
                tb_input.Focus();
                return;
            }
            string connectionString = WindowsFormsApp1.Public.Public.str_conn;

            if (string.IsNullOrEmpty(keyword))
            {
                LoadAllDonHang();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = $@"
                        SELECT 
                        MaHD AS N'Mã hóa đơn', 
                        NgayLap AS N'Ngày lập', 
                        TongTien AS N'Tổng tiền', 
                        SoDienThoai_FK AS N'Số điện thoại', 
                        MaNV_FK AS N'Mã nhân viên'
                        FROM HoaDon 
                        WHERE MaHD = '{keyword}' OR SoDienThoai_FK = '{keyword}'";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            dgv_DonHang.DataSource = dt;

                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("Không tìm thấy đơn hàng nào trùng khớp với thông tin bạn nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadAllDonHang()
        {
            string connectionString = WindowsFormsApp1.Public.Public.str_conn;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = @"
                        SELECT 
                        MaHD AS N'Mã hóa đơn', 
                        NgayLap AS N'Ngày lập', 
                        TongTien AS N'Tổng tiền', 
                        SoDienThoai_FK AS N'Số điện thoại', 
                        MaNV_FK AS N'Mã nhân viên'
                        FROM HoaDon";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgv_DonHang.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách đơn hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            form_Menu_admin form = new form_Menu_admin(user);
            form.Show();
            this.Hide();
        }


        private void dgv_DonHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !dgv_DonHang.Rows[e.RowIndex].IsNewRow)
            {
                var cellValue = dgv_DonHang.Rows[e.RowIndex].Cells["Mã hóa đơn"].Value;

                if (cellValue != null && cellValue != DBNull.Value && !string.IsNullOrWhiteSpace(cellValue.ToString()))
                {
                    string maHoaDon = cellValue.ToString();
                    QuanLyDonHang_ChiTiet frmChiTiet = new QuanLyDonHang_ChiTiet(maHoaDon);
                    frmChiTiet.ShowDialog();
                }
            }
        }
    }
}
