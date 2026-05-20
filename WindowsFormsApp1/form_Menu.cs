using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Class;

namespace WindowsFormsApp1
{
    public partial class form_Menu : Form
    {
        private NhanVien user = new NhanVien();
        public form_Menu(NhanVien nv)
        {
            InitializeComponent();
            this.user = nv;
        }

        private void form_Menu_Load(object sender, EventArgs e)
        {
            tb_Greeting.Text = $"Xin chào, {user.Name}";
            if (user.Role == "admin") this.Text = "Menu (Admin) - Quản lý cửa hàng";
            else if (user.Role == "staff") this.Text = "Menu (Nhân Viên) - Quản lý cửa hàng";
        }

        private void btn_Click_Logout(object sender, EventArgs e)
        {
            form_Login login = new form_Login();
            login.Show();
            this.Hide();
        }

        private void btn_Click_QuanLyNhanVien(object sender, EventArgs e)
        {
            if (user.Role != "admin")
            {
                MessageBox.Show("Bạn không phải quản trị viên!");
                return;
            }
            else { }
        }
    }
}
