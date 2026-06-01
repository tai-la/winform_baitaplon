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

namespace WindowsFormsApp1.QuanLyDonHang
{
    public partial class QuanLyDonHang_ChiTiet : Form
    {
        private string maHD;
        private string connectionString = WindowsFormsApp1.Public.Public.str_conn;
        public QuanLyDonHang_ChiTiet(string maHoaDon)
        {
            InitializeComponent();
            this.maHD = maHoaDon;
            this.Text = "Chi tiết hóa đơn mã: " + maHD;
        }

        private void QuanLyDonHang_ChiTiet_Load(object sender, EventArgs e)
        {
            LoadChiTietDonHang();
        }

        private void LoadChiTietDonHang()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = $"SELECT mh.TenMH AS N'Tên sản phẩm', " +
                                 $"ct.SoLuong AS N'Số lượng', ct.DonGia AS N'Đơn giá', " +
                                 $"ct.ThanhTien AS N'Thành tiền' " +
                                 $"FROM ChiTietHoaDon ct " +
                                 $"INNER JOIN MatHang mh ON ct.MaMH_FK = mh.MaMH " +
                                 $"WHERE ct.MaHD_FK = '{maHD}'";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgv_ChiTiet.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải chi tiết đơn hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
