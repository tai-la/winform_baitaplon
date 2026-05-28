using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp1.BanHang;
using WindowsFormsApp1.Class;

namespace WindowsFormsApp1
{
    public partial class form_banHang : Form
    {
        private NhanVien user = new NhanVien();
        bool isLoadedHang = false;
        bool isLoadedKH = false;
        int tongtien = 0;
        string str_conn = WindowsFormsApp1.Public.Public.str_conn;

        DataTable tb_MatHang = new DataTable();
        DataTable tb_KhachHang = new DataTable();

        public form_banHang(NhanVien nv)
        {
            InitializeComponent();
            this.user = nv;
            lb_user.Text = nv.Name;
        }

        // Tải danh sách mặt hàng và khách hàng khi form vừa mở lên
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
        }

        public void Load_ComboBoxTimKiemKhachHang(SqlConnection conn)
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
        }

        private void btn_Click_Exit(object sender, EventArgs e)
        {
            form_Menu menu = new form_Menu(user);
            menu.Show();
            this.Hide();
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
            }
            else
            {
                btn_themKhachHang.Enabled = true;
                cb_timKiemKhachHang.Enabled = true;
                lb_khachHang.Enabled = true;
            }
        }

        // Chọn mặt hàng: Bắn vào DataGridView giỏ hàng (nếu trùng thì +1 số lượng)
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
                    cb_timKiemHang.SelectedIndex = -1;
                    return;
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

        // Hiển thị điểm tích lũy khi chọn tên khách hàng
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

        // Tính toán các loại tiền (tiền trả, tiền giảm giá, điểm thưởng)
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

        // Xử lý lưu hóa đơn, chi tiết, trừ tồn kho và cập nhật điểm khách hàng
        private void btn_thanhToan_Click(object sender, EventArgs e)
        {
            if (dgv_hoaDon.Rows.Count == 0 || (dgv_hoaDon.Rows.Count == 1 && dgv_hoaDon.Rows[0].IsNewRow))
            {
                MessageBox.Show("Vui lòng chọn ít nhất một mặt hàng để thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

            using (SqlConnection conn = new SqlConnection(str_conn))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    // LƯU HÓA ĐƠN
                    string sdt = (cb_khachVangLai.Checked || cb_timKiemKhachHang.SelectedValue == null) ? "NULL" : $"'{cb_timKiemKhachHang.SelectedValue}'";
                    string ngayLap = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    string queryHD = $"INSERT INTO HoaDon (NgayLap, TongTien, GhiChu, SoDienThoai_FK, MaNV_FK) OUTPUT INSERTED.MaHD VALUES ('{ngayLap}', {tienPhaiTra}, '', {sdt}, 1)";

                    int maHD = 0;
                    using (SqlCommand cmdHD = new SqlCommand(queryHD, conn, trans))
                    {
                        maHD = (int)cmdHD.ExecuteScalar();
                    }

                    // LƯU CHI TIẾT HÓA ĐƠN VÀ TRỪ TỒN KHO
                    foreach (DataGridViewRow row in dgv_hoaDon.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string maMH = row.Cells[0].Value.ToString();
                        string donGia = row.Cells[3].Value.ToString();
                        string soLuong = row.Cells[4].Value.ToString();
                        string thanhTien = row.Cells[5].Value.ToString();

                        string queryCT = $"INSERT INTO ChiTietHoaDon (MaHD_FK, MaMH_FK, SoLuong, DonGia, ThanhTien) VALUES ({maHD}, {maMH}, {soLuong}, {donGia}, {thanhTien})";
                        using (SqlCommand cmdCT = new SqlCommand(queryCT, conn, trans))
                        {
                            cmdCT.ExecuteNonQuery();
                        }

                        string queryKho = $"UPDATE MatHang SET SoLuongTon = SoLuongTon - {soLuong} WHERE MaMH = {maMH}";
                        using (SqlCommand cmdKho = new SqlCommand(queryKho, conn, trans))
                        {
                            cmdKho.ExecuteNonQuery();
                        }
                    }

                    // CẬP NHẬT ĐIỂM KHÁCH HÀNG
                    if (!cb_khachVangLai.Checked && cb_timKiemKhachHang.SelectedValue != null)
                    {
                        string sdtKH = cb_timKiemKhachHang.SelectedValue.ToString();
                        string queryKH = $"UPDATE KhachHang SET DiemTichLuy = DiemTichLuy - {diemTru} + {diemCongThem} WHERE SoDienThoai = '{sdtKH}'";

                        using (SqlCommand cmdKH = new SqlCommand(queryKH, conn, trans))
                        {
                            cmdKH.ExecuteNonQuery();
                        }
                    }

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
            if (form.ShowDialog() == DialogResult.OK)
            {
                using (SqlConnection conn = new SqlConnection(str_conn))
                {
                    conn.Open();
                    Load_ComboBoxTimKiemKhachHang(conn);
                }
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn hủy giỏ hàng hiện tại?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ResetFormHoaDon();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_hoaDon.CurrentRow == null || dgv_hoaDon.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Vui lòng chọn một mặt hàng trong giỏ để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mặt hàng này khỏi giỏ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int thanhTienDongsapXoa = Convert.ToInt32(dgv_hoaDon.CurrentRow.Cells[5].Value);
                tongtien -= thanhTienDongsapXoa;

                dgv_hoaDon.Rows.Remove(dgv_hoaDon.CurrentRow);

                CapNhatTienVaDiem();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dgv_hoaDon.CurrentRow == null || dgv_hoaDon.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Vui lòng chọn một mặt hàng trong giỏ để sửa số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = dgv_hoaDon.CurrentRow.Cells[0].Value.ToString();
            string ten = dgv_hoaDon.CurrentRow.Cells[1].Value.ToString();
            int donGia = Convert.ToInt32(dgv_hoaDon.CurrentRow.Cells[3].Value);
            int slHienTai = Convert.ToInt32(dgv_hoaDon.CurrentRow.Cells[4].Value);

            form_suaSL frm = new form_suaSL(ten, slHienTai);
            if (frm.ShowDialog() != DialogResult.OK) return;

            int slMoi = frm.SoLuongMoi;

            int tonKho = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(str_conn))
                {
                    conn.Open();
                    string query = "SELECT SoLuongTon FROM MatHang WHERE MaMH = " + id;
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        tonKho = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra tồn kho: " + ex.Message, "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (slMoi > tonKho)
            {
                MessageBox.Show($"Kho không đủ hàng! Số lượng yêu cầu: {slMoi} - Hiện còn: {tonKho}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int thanhTienCu = donGia * slHienTai;
            int thanhTienMoi = donGia * slMoi;

            tongtien = tongtien - thanhTienCu + thanhTienMoi;

            dgv_hoaDon.CurrentRow.Cells[4].Value = slMoi;
            dgv_hoaDon.CurrentRow.Cells[5].Value = thanhTienMoi;

            CapNhatTienVaDiem();
        }
    }
}