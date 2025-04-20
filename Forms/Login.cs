using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Data.SqlClient;
using QLGIAODICH.Models;

namespace QLGIAODICH
{
    public partial class Login_MBBank_Crack : Form
    {
        string SQLConnectionstring = @"Data Source=TOANVU;Initial Catalog=QLGIAODICH;Integrated Security=True;Trust Server Certificate=True";
        SqlConnection con;

        public Login_MBBank_Crack()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            con = new SqlConnection(SQLConnectionstring);
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (con != null && con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (con != null && con.State == System.Data.ConnectionState.Open)
                {
                    string query = "SELECT COUNT(*),TenNhanVien FROM tblNhanVien WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau GROUP BY TenNhanVien";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@TenDangNhap", txtTenDangNhap.Text);
                        cmd.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text);


                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int count = reader.GetInt32(0);
                                string tennhanvien = reader.GetString(1);
                                if (count > 0)
                                {
                                    txtTenDangNhap.Text = "";
                                    txtMatKhau.Text = "";
                                    Session.TenNhanVien = tennhanvien;
                                    formMain newForm = new formMain();
                                    newForm.Show();  
                                    this.Hide();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                            }
                        }

                    }
                }
                else
                {
                    MessageBox.Show("cơ sở dữ liệu where ?");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            
        }
        private void Login_Load(object sender, EventArgs e)
        {
            lb1.BackColor = Color.Transparent;
            lb2.BackColor = Color.Transparent;
            lb3.BackColor = Color.Transparent;

            try
            {
                con.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Không tìm thấy cơ sở dữ liệu" + ex.Message);
            }
        }
        private void Login_MBBank_Crack_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (con.State == System.Data.ConnectionState.Open && con != null)
            {
                con.Close();
            }
        }
    }
}
