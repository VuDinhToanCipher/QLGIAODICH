using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Microsoft.Data.SqlClient;
using QLGIAODICH.Models;
using QLGIAODICH.Services;
using QLGIAODICH.Helper;

namespace QLGIAODICH
{
    public partial class DangKi : Form
    {
        string SQLConnectionstring = @"Data Source=TOANVU;Initial Catalog=QLGIAODICH;Integrated Security=True;Trust Server Certificate=True";
        RandSTK stk;
        RandPassword passwordcs = new RandPassword();
        public DangKi()
        {
            stk = new RandSTK(SQLConnectionstring);
            InitializeComponent();
        }

        private void DangKi_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            lbNameNV.Text = Session.TenNhanVien;
            lbNgayDangKi.Text = date.Date.ToString();
        }
        //Cap nhat cho phieu thong tin
        private void txbHoTen_TextChanged(object sender, EventArgs e)
        {
            Textchange.changetext(txbHoTen, lbName);
        }
        private void txbSDT_TextChanged(object sender, EventArgs e)
        {
            Textchange.changetext(txbSDT, lbSDT);
        }

        private void txbDiaChi_TextChanged(object sender, EventArgs e)
        {
            Textchange.changetext(txbDiaChi, lbDiaChi);
        }

        private void txbEmail_TextChanged(object sender, EventArgs e)
        {
            Textchange.changetext(txbEmail, lbEmail);
        }
        private void txbTenTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            Textchange.changetext(txbTenTaiKhoan, lbTenTaiKhoan);
        }

        private void txbSoDu_TextChanged(object sender, EventArgs e)
        {
            Textchange.changetext(txbSoDu, lbSoDu);
        }
        //Tao tai khoan
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int Loai = 1;
            string gioiTinh = rdMale.Checked ? "Nam" : "Nữ";
            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl is TextBox && string.IsNullOrEmpty(((TextBox)ctrl).Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Dừng lại nếu có trường trống
                }
            }
            if (cbLoai.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn loại người dùng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Dừng lại nếu có trường trống
            }
            else
            {
                if(cbLoai.SelectedIndex == 0)
                {
                    Loai = 1;
                }
                else if(cbLoai.SelectedIndex == 1)
                {
                    Loai = 2;
                }
            }
            string query = @"INSERT INTO tblNguoiDung(TenNguoiDung,Email,SoDienThoai,DiaChi,LoaiNguoiDung,CCCD,NgaySinh,GioiTinh)
                VALUES
                (
                @TenNguoiDung,
                @Email,
                @SoDienThoai,
                @DiaChi,
                @LoaiNguoiDung,
                @CCCD,
                @NgaySinh,
                @GioiTinh
                ) SELECT SCOPE_IDENTITY()";
            string queryy = @"INSERT INTO tblTaiKhoan(IDNguoiDung,TenTaiKhoan,MatKhau,SoTaiKhoan,SoDu)
                VALUES
                (
                @IDNguoiDung,
                @TenTaiKhoan,
                @MatKhau,
                @SoTaiKhoan,
                @SoDu
                )";
            try
            {
                using (SqlConnection con = new SqlConnection(SQLConnectionstring))
                {
                    DialogResult result = MessageBox.Show(
                "Chắc chắn thực hiện?",
                "Hãy kiểm tra kĩ thông tin",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
                    if (result == DialogResult.Yes)
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@TenNguoiDung", txbHoTen.Text);
                        cmd.Parameters.AddWithValue("@Email", txbEmail.Text);
                        cmd.Parameters.AddWithValue("@SoDienThoai", txbSDT.Text);
                        cmd.Parameters.AddWithValue("@DiaChi", txbDiaChi.Text);
                        cmd.Parameters.AddWithValue("@LoaiNguoiDung", Loai);
                        cmd.Parameters.AddWithValue("@CCCD", txbCCCD.Text);
                        cmd.Parameters.AddWithValue("@NgaySinh", dtpNgayDK.Value);
                        cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                        decimal maKH = (decimal)cmd.ExecuteScalar();  // Lấy giá trị trả về từ SCOPE_IDENTITY() dưới dạng decimal
                        //Them thong tin bang tai khoan
                        string MK = passwordcs.GenerateRandomPassword();
                        string STK = stk.SoTaiKhoan("tblTaiKhoan", "SoTaiKhoan");
                        Session.MatKhau = MK;
                        Session.SoTaiKhoan = STK;
                        SqlCommand cmds = new SqlCommand(queryy, con);
                        cmds.Parameters.AddWithValue("@IDNguoiDung", maKH);
                        cmds.Parameters.AddWithValue("@TenTaiKhoan", txbTenTaiKhoan.Text);
                        cmds.Parameters.AddWithValue("@MatKhau", MK);
                        cmds.Parameters.AddWithValue("@SoTaiKhoan", STK);
                        cmds.Parameters.AddWithValue("@SoDu", txbSoDu.Text);
                        cmds.ExecuteNonQuery();
                        foreach (Control ctrl in groupBox1.Controls)
                        {
                            if (ctrl is TextBox)
                            {
                                ((TextBox)ctrl).Clear();
                            }
                        }
                        con.Close();
                        MessageBox.Show($"Số Tài Khoản: {Session.SoTaiKhoan}\n Mật Khẩu:{Session.MatKhau}");
                        Session.MatKhau = "";
                        Session.SoTaiKhoan = "";
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message );
            }
        }
        private void rdMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMale.Checked)
            {
                lbGioiTinh.Text = rdMale.Text;
            }
            else
            {
                lbGioiTinh.Text = rdFemale.Text;
            }
        }
        private void txbCCCD_TextChanged(object sender, EventArgs e)
        {
            lbCCCD.Text = txbCCCD.Text;
        }
        private void dtpNgayDK_ValueChanged(object sender, EventArgs e)
        {
            lbNgaySinh.Text = dtpNgayDK.Value.ToString("dd/MM/yyyy");
        }
        private void txbHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
        private void txbSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txbCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txbSoDu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void cbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoai.SelectedIndex != -1)
            {
                lbLoai.Text = cbLoai.SelectedItem.ToString(); // ← Dùng SelectedItem
            }
            else
            {
                lbLoai.Text = "";
            }
        }

    }
}
