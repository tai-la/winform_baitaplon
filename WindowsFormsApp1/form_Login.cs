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

namespace WindowsFormsApp1
{
    public partial class form_Login : Form
    {
        public form_Login()
        {
            InitializeComponent();
        }
        
        private void btn_Click_Exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Click_Login(object sender, EventArgs e)
        {
            string username = tb_Username.Text.Trim();
            string password = tb_Password.Text.Trim();
            string str_conn = "Data Source=.;Initial Catalog=btl_winform;Integrated Security=True;TrustServerCertificate=True";
            
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!");
                tb_Username.Focus();
                return;
            }
            else if (string.IsNullOrEmpty (password))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                tb_Password.Focus();
                return;
            }

            using (SqlConnection conn = new SqlConnection(str_conn))
            {
                conn.Open();
                string query = $"SELECT * FROM NhanVien WHERE TenDangNhap = '{username}' AND MatKhau = '{password}'";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader()) 
                    {
                        if (reader.Read())
                        {
                            NhanVien nv = new NhanVien();
                            nv.Id = Convert.ToInt32(reader["MaNV"]);
                            nv.Name = Convert.ToString(reader["TenNV"]);
                            nv.Role = Convert.ToString(reader["VaiTro"]);
                            nv.isActive = Convert.ToBoolean(reader["DangLam"]);

                            if (nv.isActive != true)
                            {
                                MessageBox.Show("Tài khoản của bạn đã bị khóa\nLý do: vì không còn làm việc tại đây.");
                                return;
                            }

                            MessageBox.Show("Đăng nhập thành công!");

                            form_Menu menu = new form_Menu(nv);
                            menu.Show();
                            this.Hide();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                            return;
                        }
                    }

                }
            }
        }
    }
}
