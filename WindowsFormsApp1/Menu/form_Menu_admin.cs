using QuanLyMatHang;
using quanlynhanvien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Class;
using WindowsFormsApp1.QuanLyDonHang;

namespace WindowsFormsApp1.Menu
{
    public partial class form_Menu_admin : Form
    {
        NhanVien user = new NhanVien();
        public form_Menu_admin(NhanVien nv)
        {
            user = nv;
            InitializeComponent();
        }

        private void form_Menu_Load(object sender, EventArgs e)
        {
            tb_Greeting.Text = $"Xin chào, {user.Name}";
            if (user.Role == "admin") this.Text = "Menu (Admin) - Quản lý cửa hàng";
            else if (user.Role == "staff") this.Text = "Menu (Nhân Viên) - Quản lý cửa hàng";
            return;
        }

        private void btn_Click_Logout(object sender, EventArgs e)
        {
            form_Login login = new form_Login();
            login.Show();
            this.Hide();
            user = new NhanVien();
            return;
        }

        private void btn_Click_QuanLyNhanVien(object sender, EventArgs e)
        {
            if (user.Role != "admin")
            {
                MessageBox.Show("Bạn không phải quản trị viên!");
                return;
            }
            else
            {
                QuanLyNhanVien form = new QuanLyNhanVien(user);
                form.Show();
                this.Hide();
                return;
            }

        }
        private void btn_Click_BanHang(object sender, EventArgs e)
        {
            form_banHang form = new form_banHang(user);
            form.Show();
            this.Hide();
            return;
        }

        private void btn_quanLyMatHang_Click(object sender, EventArgs e)
        {
            form_quanLyMatHang form = new form_quanLyMatHang(user);
            form.Show();
            this.Hide();
            return;
        }

        private void btn_quanLyKhachHang_Click(object sender, EventArgs e)
        {
            form_KhachHang form = new form_KhachHang(user);
            form.Show();
            this.Hide();
            return;
        }

        private void btn_quanLyDonHang_Click(object sender, EventArgs e)
        {
            form_quanLyDonHang form = new form_quanLyDonHang(user);
            form.Show();
            this.Hide();
            return;
        }
    }
}
