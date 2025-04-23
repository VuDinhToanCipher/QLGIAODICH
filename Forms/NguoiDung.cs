using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;
using QLGIAODICH.Helper;
using QLGIAODICH.Models;
using QLGIAODICH.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace QLGIAODICH
{
    public partial class NguoiDung : Form
    {
        string SQLConnectionstring = @"Data Source=TOANVU;Initial Catalog=QLGIAODICH;Integrated Security=True;Trust Server Certificate=True";
        Search timkiem;
        int selectedUserId;
        int selectestk;
        bool swicth = false;
        bool swicth_crCard = false;
        RandSTK stk;
        RandPassword password;
        RandSTK randcard;
        public NguoiDung()
        {
            randcard = new RandSTK(SQLConnectionstring);
            password = new RandPassword();
            stk = new RandSTK(SQLConnectionstring);
            timkiem = new Search(SQLConnectionstring);
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string value = txtSearchStk.Text.Trim();

            string query = @"
            SELECT nd.IDNguoiDung, nd.TenNguoiDung, nd.Email, nd.SoDienThoai, nd.DiaChi, nd.LoaiNguoiDung, nd.CCCD, nd.NgaySinh
            FROM tblTaiKhoan tk
            JOIN tblNguoiDung nd ON tk.IDNguoiDung = nd.IDNguoiDung
            WHERE tk.SoTaiKhoan = @value
            ";
            string query1 = @"
            SELECT *
            FROM tblTaiKhoan tk
            WHERE tk.SoTaiKhoan = @value
            ";
            dtNguoidung.DataSource = timkiem.Timkiem(query, value);
            dtTaikhoan.DataSource = timkiem.Timkiem(query1, value);
        }

        private void NguoiDung_Load(object sender, EventArgs e)
        {
            panel1.Width = this.ClientSize.Width / 2;
            panel2.Width = this.ClientSize.Width / 4;
            panel3.Width = this.ClientSize.Width / 4;

            dtGridViewconfig.DTconfig(dtNguoidung);
            dtGridViewconfig.DTconfig(dtTaikhoan);
            dtGridViewconfig.DTconfig(dtThe);
        }
        private void NguoiDung_SizeChanged(object sender, EventArgs e)
        {
            panel1.Width = this.ClientSize.Width / 2;
            panel2.Width = this.ClientSize.Width / 4;
            panel3.Width = this.ClientSize.Width / 4;
        }
        private void dtNguoidung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dtNguoidung.Rows[e.RowIndex];
                txbHoTen.Text = row.Cells["TenNguoiDung"].Value.ToString();
                txbEmail.Text = row.Cells["Email"].Value.ToString();
                txbSDT.Text = row.Cells["SoDienThoai"].Value.ToString();
                txbDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txbLoai.Text = row.Cells["LoaiNguoiDung"].Value.ToString();
                txbCCCD.Text = row.Cells["CCCD"].Value.ToString();
                txbNgaysSinh.Text = row.Cells["NgaySinh"].Value.ToString();
                // Lưu lại ID của người dùng đã chọn để dùng khi cập nhật
                selectedUserId = (int)row.Cells["IDNguoiDung"].Value; // IDNguoiDung là cột ID trong DataGridView
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedUserId <= 0)
            {
                MessageBox.Show("Vui lòng chọn người dùng để cập nhật.");
                return; // Nếu không có người dùng được chọn, dừng lại
            }
            string Hoten = txbHoTen.Text;
            string Email = txbEmail.Text;
            string SDT = txbSDT.Text;
            string DiaChi = txbDiaChi.Text;
            string Loai = txbLoai.Text;
            string CCCD = txbCCCD.Text;
            DateTime NgaySinh;
            if (!DateTime.TryParse(txbNgaysSinh.Text, out NgaySinh))
            {
                MessageBox.Show("Ngày sinh không hợp lệ.");
                return;
            }
            DialogResult result = MessageBox.Show(
            "Bạn có chắc chắn?",
            "Xác nhận cập nhật",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            // Kiểm tra dữ liệu nhập vào, đảm bảo hợp lệ (ví dụ: không để trống)
            if (string.IsNullOrWhiteSpace(Hoten) || string.IsNullOrWhiteSpace(Email))
            {
                MessageBox.Show("Tên người dùng và email không được để trống.");
                return;
            }

            string query = "UPDATE thbNguoiDung SET TenNguoiDung = @TenNguoiDung, Email = @Email, SoDienThoai = @SoDienThoai, DiaChi = @DiaChi, LoaiNguoiDung = @LoaiNguoiDung,CCCD = @CCCD,NgaySinh = @NgaySinh WHERE IDNguoiDung = @IDNguoiDung";
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(SQLConnectionstring))
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            // Sử dụng Add() để rõ ràng hơn về kiểu dữ liệu
                            cmd.Parameters.Add("@TenNguoiDung", SqlDbType.NVarChar).Value = Hoten;
                            cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = Email;
                            cmd.Parameters.Add("@SoDienThoai", SqlDbType.NVarChar).Value = SDT;
                            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = DiaChi;
                            cmd.Parameters.Add("@LoaiNguoiDung", SqlDbType.NVarChar).Value = Loai;
                            cmd.Parameters.Add("@CCCD", SqlDbType.NVarChar).Value = CCCD;
                            cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = NgaySinh;
                            cmd.Parameters.Add("@IDNguoiDung", SqlDbType.Int).Value = selectedUserId;

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Cập nhật thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi cập nhật: " + ex.Message);
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
           "Bạn có chắc chắn?",
           "Xác nhận cập nhật",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question
           );
            string TenTaiKhoan = txbTentaikhoan.Text;
            string MatKhau = tbMK.Text;
            string query = @"UPDATE tblTaiKhoan SET TenTaiKhoan = @TenTaiKhoan,MatKhau = @MatKhau WHERE IDTaiKhoan = @IDTaiKhoan";
            if (selectestk <= 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản dùng để cập nhật.");
                return;
            }
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(SQLConnectionstring))
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@TenTaiKhoan", TenTaiKhoan);
                            cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
                            cmd.Parameters.AddWithValue("@IDTaiKhoan", selectestk);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Cập nhật thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi cập nhật: " + ex.Message);
                    }
                }
            }
        }
        private void dtTaikhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dtTaikhoan.Rows[e.RowIndex];
                txbTentaikhoan.Text = row.Cells["TenTaiKhoan"].Value.ToString();
                tbMK.Text = row.Cells["MatKhau"].Value.ToString();
                selectestk = (int)row.Cells["IDTaiKhoan"].Value;
                txtTaiKhoan.Text = row.Cells["TenTaiKhoan"].Value.ToString();
                txtTimthe.Text = row.Cells["SoTaiKhoan"].Value.ToString();
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(panel1.BackColor); // Xoá đường cũ

            Pen pen = new Pen(Color.Black, 5);
            int x1 = (int)(panel1.Width * 1);

            e.Graphics.DrawLine(pen, x1, 0, x1, panel1.Height);

        }
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            swicth = !swicth;
            if (swicth)
            {
                pnThemTK.Visible = true;
                pnAdd_card.Visible = false;
            }
            else
            {
                pnThemTK.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận thêm tài khoản", "Đồng ý",
                MessageBoxButtons.YesNo);
            string query = "INSERT INTO tblTaiKhoan(IDNguoiDung,TenTaiKhoan,MatKhau,SoTaiKhoan,SoDu) " + "VALUES(@IDNguoiDung,@TenTaiKhoan,@MatKhau,@SoTaiKhoan,@SoDu)";
            foreach (Control control in pnThemTK.Controls)
            {
                if (control is TextBox txt)
                {
                    if (string.IsNullOrEmpty(txt.Text))
                    {
                        MessageBox.Show("Vui Long Nhap Day Du Thong Tin");
                        return;
                    }
                }
            }
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (string.IsNullOrEmpty(selectedUserId.ToString()))
                    {
                        using (SqlConnection conn = new SqlConnection(SQLConnectionstring))
                        {
                            conn.Open();
                            string MK = password.GenerateRandomPassword();
                            string STK = stk.SoTaiKhoan("tblTaiKhoan", "SoTaiKhoan");
                            Session.MatKhau = MK;
                            Session.SoTaiKhoan = STK;
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("IDNguoiDung", selectedUserId);
                                cmd.Parameters.AddWithValue("@TenTaiKhoan", txtName.Text);
                                cmd.Parameters.AddWithValue("@MatKhau", MK);
                                cmd.Parameters.AddWithValue("@SoTaiKhoan", STK);
                                cmd.Parameters.AddWithValue("@SoDu", txtBalance.Text);
                                cmd.ExecuteNonQuery();
                            }
                            MessageBox.Show($"Số Tài Khoản: {Session.SoTaiKhoan}\n Mật Khẩu:{Session.MatKhau}");
                            Session.MatKhau = "";
                            Session.SoTaiKhoan = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Chon Nguoi Dung Di Bro");
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Addcard_Click(object sender, EventArgs e)
        {
            swicth_crCard = !swicth_crCard;
            if (swicth_crCard)
            {
                pnAdd_card.Visible = true;
                pnThemTK.Visible = false;
            }
            else
            {
                pnAdd_card.Visible = false;
            }
        }

        private void btnXn_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO tblThe VALUES (@IDTaiKhoan,@SoThe,@NgayHetHan,@MaLoai,@Mapin)";
            DialogResult result = MessageBox.Show("Xác nhận thao tác?",
                "Đồng ý",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            foreach (Control c in pnAdd_card.Controls)
            {
                if (c is TextBox && string.IsNullOrEmpty(c.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    return;
                }
            }
            if (cbxCardType.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại thẻ");
                return;
            }
            int Loai;
            if (cbxCardType.Text.ToString() == "Tín dụng")
            {
                Loai = 11;
            }
            else
            {
                Loai = 12;
            }
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(SQLConnectionstring))
                    {
                        con.Open();
                        string sothe = randcard.SoThe("tblThe", "SoThe");
                        DateTime dt = DateTime.Now.AddYears(5);

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@IDTaiKhoan", selectestk);
                            cmd.Parameters.AddWithValue("@SoThe", sothe);
                            cmd.Parameters.AddWithValue("@NgayHetHan", dt);
                            cmd.Parameters.AddWithValue("@MaLoai", Loai);
                            cmd.Parameters.AddWithValue("@Mapin", txtPin.Text);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show($"The cua ban :{sothe}\n Mapin {txtPin.Text}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnTimthe_Click(object sender, EventArgs e)
        {
            string query2 = @"
            SELECT *
            FROM tblThe tk
            WHERE tk.IDTaiKhoan = @value
            ";
            dtThe.DataSource = timkiem.Timkiem(query2, selectestk.ToString());
        }
    }
}
