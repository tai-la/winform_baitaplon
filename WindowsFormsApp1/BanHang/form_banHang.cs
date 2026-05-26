using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Class;

namespace WindowsFormsApp1
{
    public partial class form_banHang : Form
    {
        private NhanVien user = new NhanVien();
        bool isLoadedHang = false;
        bool isLoadedKH = false;
        int tongtien = 0;
        string str_conn = "Data Source=.;Initial Catalog=btl_winform;Integrated Security=True;TrustServerCertificate=True";

        DataTable tb_MatHang = new DataTable();
        DataTable tb_KhachHang = new DataTable();
        public form_banHang(NhanVien nv)
        {
            InitializeComponent();
            this.user = nv;
            lb_user.Text = nv.Name;
            return;
        }
        private void form_Load(object sender, EventArgs e) 
        {
            using (SqlConnection conn = new SqlConnection(str_conn))
            {
                conn.Open();
                Load_ComboBoxTimKiemMatHang(conn);
                Load_ComboBoxTimKiemKhachHang(conn);
            }
        }
        private void Load_ComboBoxTimKiemMatHang(SqlConnection conn) 
        {
            string query = "SELECT MaMH, TenMH, DVT, GiaNhap, GiaBan, SoLuongTon, CAST(MaMH AS VARCHAR) + ' - ' + TenMH AS HienThi FROM MatHang WHERE ConBan = 1";
            using (SqlCommand cmd = new SqlCommand(query, conn)) 
            {
                using (SqlDataReader reader = cmd.ExecuteReader()) 
                {
                    tb_MatHang.Clear();
                    tb_MatHang.Load(reader);

                    cb_timKiemHang.DataSource = tb_MatHang;
                    cb_timKiemHang.DisplayMember = "HienThi";
                    cb_timKiemHang.ValueMember = "MaMH";

                    cb_timKiemHang.SelectedIndex = -1;
                    cb_timKiemHang.Text = "";
                }
            }
            isLoadedHang = true;
            return;
        }
        private void Load_ComboBoxTimKiemKhachHang(SqlConnection conn)
        {
            string query = "SELECT SoDienThoai, TenKH, DiaChi, DiemTichLuy, SoDienThoai + ' - ' + TenKH AS HienThi FROM KhachHang WHERE ConHoatDong = 1";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    tb_KhachHang.Clear();
                    tb_KhachHang.Load(reader);

                    cb_timKiemKhachHang.DataSource = tb_KhachHang;
                    cb_timKiemKhachHang.DisplayMember = "HienThi";
                    cb_timKiemKhachHang.ValueMember = "SoDienThoai";
                    cb_timKiemKhachHang.SelectedIndex = -1;
                    cb_timKiemKhachHang.Text = "";
                }
            }
            isLoadedKH = true;
            return;
        }
        private void btn_Click_Exit(object sender, EventArgs e)
        {
            form_Menu menu = new form_Menu(user);
            menu.Show();
            this.Hide();
            return;
        }
        private void cb_CheckedChanged_KhachVangLai(object sender, EventArgs e)
        {
            if (cb_khachVangLai.Checked)
            {
                lb_Diem.Enabled = false;
                lb_point.Enabled = false;
                btn_themKhachHang.Enabled = false;
                cb_timKiemKhachHang.Enabled = false;
                lb_khachHang.Enabled = false;
                lb_suDungDiem.Enabled = false;
                radioBtn_Co.Enabled = false;
                radioBtn_Khong.Enabled = false;
                lb_giamGia.Enabled = false;
                lb_giamGia_value.Enabled = false;
                lb_tichDiem.Enabled = false;
                lb_tichDiem_value.Enabled = false;

                cb_timKiemKhachHang.SelectedIndex = -1; 
                cb_timKiemKhachHang.Text = "";         

                
                lb_point.Text = "0";                  
                radioBtn_Khong.Checked = false;       
                radioBtn_Co.Checked = false;
                lb_giamGia_value.Text = "0 đ";
                cb_timKiemKhachHang = null;
            }
            else
            {
                btn_themKhachHang.Enabled = true;
                cb_timKiemKhachHang.Enabled = true;
                lb_khachHang.Enabled = true;
            }
        }
        private void cb_timKiemHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_timKiemHang.SelectedItem != null && isLoadedHang)
            {
                DataRowView item = (DataRowView)cb_timKiemHang.SelectedItem;
                string id = item["MaMH"].ToString();
                string ten = item["TenMH"].ToString();
                string dvt = item["DVT"].ToString();
                int dongia = Convert.ToInt32(item["GiaBan"]);
                int tonkho = Convert.ToInt32(item["SoLuongTon"]);
                int soluong = 1;
                int thanhtien1mon = soluong * dongia;
                tongtien += thanhtien1mon;

                bool daTonTai = false;

                if (tonkho <= 0)
                {
                    MessageBox.Show($"Sản phẩm này đã hết hàng trong kho:\n{id} - {ten}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cb_timKiemHang.SelectedIndex = -1; // Hủy chọn
                    return; // Thoát hàm ngay lập tức, không làm gì thêm
                }

                foreach (DataGridViewRow row in dgv_hoaDon.Rows)
                {
                    if (row.IsNewRow) continue;
                    if ((row.Cells[0].Value).ToString() == id)
                    {
                        int soLuongHienTai = Convert.ToInt32(row.Cells[4].Value);
                        if (soLuongHienTai >= tonkho)
                        {
                            MessageBox.Show($"Sản phẩm đã vượt quá số lượng sản phẩm trong kho:\n{id} - {ten}");
                            cb_timKiemHang.SelectedIndex = -1;
                            return;
                        }
                        daTonTai = true;
                        row.Cells[4].Value = soLuongHienTai + 1;
                        row.Cells[5].Value = Convert.ToInt32(row.Cells[4].Value) * dongia;
                    }
                }

                if (!daTonTai)
                {
                    dgv_hoaDon.Rows.Add(id, ten, dvt, dongia, soluong, thanhtien1mon);
                }
                cb_timKiemHang.SelectedIndex = -1;
                CapNhatTienVaDiem();
            }
        }
        private void cb_timKiemKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_timKiemKhachHang.SelectedItem != null && isLoadedKH)
            {
                DataRowView item = (DataRowView)cb_timKiemKhachHang.SelectedItem;
                string point = Convert.ToString(item["DiemTichLuy"]);

                lb_point.Enabled = true;
                lb_Diem.Enabled = true; 
                lb_suDungDiem.Enabled = true;
                radioBtn_Co.Enabled = true;
                radioBtn_Khong.Enabled = true;
                lb_giamGia_value.Enabled = true;
                lb_giamGia.Enabled = true;
                lb_tichDiem.Enabled = true;
                lb_tichDiem_value.Enabled = true;
                lb_point.Text = point;
            }
        }
        private void CapNhatTienVaDiem()
        {
            int tienGiamGia = 0;
            if (!cb_khachVangLai.Checked && radioBtn_Co.Checked && !string.IsNullOrEmpty(lb_point.Text))
            {
                int diemHienCo = Convert.ToInt32(lb_point.Text);
                tienGiamGia = diemHienCo * 1000;

                if (tienGiamGia >= tongtien)
                {
                    tienGiamGia = tongtien;
                }
            }
            lb_giamGia_value.Text = $"{tienGiamGia:N0} đ";

            int tienPhaiTra = tongtien - tienGiamGia;
            lb_totalCost.Text = $"{tienPhaiTra:N0} đ";

            int diemCongThem = tienPhaiTra / 100000;
            lb_tichDiem_value.Text = $"{diemCongThem}";

        }
        private void radioBtn_Co_CheckedChanged(object sender, EventArgs e)
        {
            CapNhatTienVaDiem();
        }
        private void btn_thanhToan_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem giỏ hàng có đồ không
            if (dgv_hoaDon.Rows.Count == 0 || (dgv_hoaDon.Rows.Count == 1 && dgv_hoaDon.Rows[0].IsNewRow))
            {
                MessageBox.Show("Vui lòng chọn ít nhất một mặt hàng để thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tính toán lại tiền và điểm
            int diemTru = 0;
            int tienGiam = 0;

            if (!cb_khachVangLai.Checked && radioBtn_Co.Checked && !string.IsNullOrEmpty(lb_point.Text))
            {
                diemTru = Convert.ToInt32(lb_point.Text);
                tienGiam = diemTru * 1000;

                if (tienGiam > tongtien)
                {
                    tienGiam = tongtien;
                    diemTru = tongtien / 1000;
                }
            }

            int tienPhaiTra = tongtien - tienGiam;
            int diemCongThem = cb_khachVangLai.Checked ? 0 : (tienPhaiTra / 100000);

            // MỞ KẾT NỐI VÀ LƯU VÀO CSDL
            using (SqlConnection conn = new SqlConnection(str_conn))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    // 1. THÊM VÀO BẢNG HOADON 
                    string queryHD = @"INSERT INTO HoaDon (NgayLap, TongTien, GhiChu, SoDienThoai_FK, MaNV_FK) 
                               OUTPUT INSERTED.MaHD 
                               VALUES (@NgayLap, @TongTien, @GhiChu, @SDT, @MaNV)";
                    int maHD = 0;
                    using (SqlCommand cmdHD = new SqlCommand(queryHD, conn, trans))
                    {
                        cmdHD.Parameters.AddWithValue("@NgayLap", DateTime.Now);
                        cmdHD.Parameters.AddWithValue("@TongTien", tienPhaiTra);
                        cmdHD.Parameters.AddWithValue("@GhiChu", "");

                        if (cb_khachVangLai.Checked || cb_timKiemKhachHang.SelectedValue == null)
                            cmdHD.Parameters.AddWithValue("@SDT", DBNull.Value);
                        else
                            cmdHD.Parameters.AddWithValue("@SDT", cb_timKiemKhachHang.SelectedValue.ToString());

                        // Lấy ID nhân viên từ biến user của bạn
                        cmdHD.Parameters.AddWithValue("@MaNV", 1); // Đổi số 1 thành ID nhân viên thực tế nếu bạn có, vd: user.ID

                        maHD = (int)cmdHD.ExecuteScalar();
                    }

                    // 2. THÊM VÀO CHITIETHOADON VÀ TRỪ TỒN KHO MATHANG
                    string queryCT = @"INSERT INTO ChiTietHoaDon (MaHD_FK, MaMH_FK, SoLuong, DonGia, ThanhTien) 
                               VALUES (@MaHD, @MaMH, @SoLuong, @DonGia, @ThanhTien)";
                    string queryKho = @"UPDATE MatHang SET SoLuongTon = SoLuongTon - @SoLuong WHERE MaMH = @MaMH";

                    foreach (DataGridViewRow row in dgv_hoaDon.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int maMH = Convert.ToInt32(row.Cells[0].Value);
                        int donGia = Convert.ToInt32(row.Cells[3].Value);
                        int soLuong = Convert.ToInt32(row.Cells[4].Value);
                        int thanhTien = Convert.ToInt32(row.Cells[5].Value);

                        using (SqlCommand cmdCT = new SqlCommand(queryCT, conn, trans))
                        {
                            cmdCT.Parameters.AddWithValue("@MaHD", maHD);
                            cmdCT.Parameters.AddWithValue("@MaMH", maMH);
                            cmdCT.Parameters.AddWithValue("@SoLuong", soLuong);
                            cmdCT.Parameters.AddWithValue("@DonGia", donGia);
                            cmdCT.Parameters.AddWithValue("@ThanhTien", thanhTien);
                            cmdCT.ExecuteNonQuery();
                        }

                        using (SqlCommand cmdKho = new SqlCommand(queryKho, conn, trans))
                        {
                            cmdKho.Parameters.AddWithValue("@MaMH", maMH);
                            cmdKho.Parameters.AddWithValue("@SoLuong", soLuong);
                            cmdKho.ExecuteNonQuery();
                        }
                    }

                    // 3. CẬP NHẬT ĐIỂM CHO KHÁCH HÀNG 
                    if (!cb_khachVangLai.Checked && cb_timKiemKhachHang.SelectedValue != null)
                    {
                        string queryKH = @"UPDATE KhachHang 
                                   SET DiemTichLuy = DiemTichLuy - @DiemTru + @DiemCong 
                                   WHERE SoDienThoai = @SDT";
                        using (SqlCommand cmdKH = new SqlCommand(queryKH, conn, trans))
                        {
                            cmdKH.Parameters.AddWithValue("@DiemTru", diemTru);
                            cmdKH.Parameters.AddWithValue("@DiemCong", diemCongThem);
                            cmdKH.Parameters.AddWithValue("@SDT", cb_timKiemKhachHang.SelectedValue.ToString());
                            cmdKH.ExecuteNonQuery();
                        }
                    }

                    // CHỐT LƯU 
                    trans.Commit();
                    MessageBox.Show("Thanh toán hóa đơn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetFormHoaDon();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Lỗi thanh toán: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ResetFormHoaDon()
        {
            dgv_hoaDon.Rows.Clear();
            tongtien = 0;
            lb_totalCost.Text = "0 đ";
            lb_giamGia_value.Text = "0 đ";
            lb_tichDiem_value.Text = "0";
            cb_timKiemHang.SelectedIndex = -1;

            if (!cb_khachVangLai.Checked)
            {
                cb_timKiemKhachHang.SelectedIndex = -1;
                lb_point.Text = "0";
                radioBtn_Khong.Checked = true;
            }

            using (SqlConnection conn = new SqlConnection(str_conn))
            {
                conn.Open();
                Load_ComboBoxTimKiemMatHang(conn);
                Load_ComboBoxTimKiemKhachHang(conn);
            }
        }

        private void btn_themKhachHang_Click(object sender, EventArgs e)
        {
            form_ThemKhachHang form = new form_ThemKhachHang();
            form.Show();
            return;
        }
    }
}
