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
using Microsoft.IdentityModel.Tokens;
using QLGIAODICH.Helper;
using QLGIAODICH.Models;
using QLGIAODICH.Services;
namespace QLGIAODICH
{
    public partial class ChuyenKhoan : Form
    {
        Search timkiem;
        CapNhatlichsugiaodich updateLS;
        string SQLConnectionstring = @"Data Source=TOANVU;Initial Catalog=QLGIAODICH;Integrated Security=True;Trust Server Certificate=True";
        public ChuyenKhoan()
        {
            updateLS = new CapNhatlichsugiaodich(SQLConnectionstring);
            timkiem = new Search(SQLConnectionstring);
            InitializeComponent();
        }
        private void ChuyenKhoan_Load(object sender, EventArgs e)
        {
            dtGridViewconfig.DTconfig(dtTK);
            dtGridViewconfig.DTconfig(dtTKN);
            DateTime dat = DateTime.Now;
            lbNgay.Text = dat.ToString("d");
            lbNV.Text = Session.TenNhanVien;
            SuakichcoPanel.Fix(0.68f, 1.5f, panel3, this, (int)(this.ClientSize.Width * 0.01f), 0);
            SuakichcoPanel.Fix(0.69f, 1.5f, panel1, this, (int)(this.ClientSize.Width * 0.7f), 0);
        }
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string value = txbTaiKhoan.Text.Trim();
            string query = $"SELECT SoTaiKhoan,TenTaiKhoan, SoDu FROM tblTaiKhoan WHERE SoTaiKhoan = @value ";
            dtTK.DataSource = timkiem.Timkiem(query, value);
        }
        private void btnSearchTKN_Click_1(object sender, EventArgs e)
        {
            string value = txbTaiKhoanNhan.Text.Trim();
            string query = $"SELECT SoTaiKhoan,TenTaiKhoan, SoDu FROM tblTaiKhoan WHERE SoTaiKhoan = @value ";
            dtTKN.DataSource = timkiem.Timkiem(query, value);
        }
        private void dtTK_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dtTK.Rows[e.RowIndex];
                lbNguoigui.Text = row.Cells["TenTaiKhoan"].Value.ToString();
                lbSTKG.Text = row.Cells["SoTaiKhoan"].Value.ToString();
            }
        }
        private void btnXacNhan_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xac nhan",
               "Xac nhan giao dich",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string STK = txbTaiKhoan.Text.Trim();
                string STKN = txbTaiKhoanNhan.Text.Trim();
                int soTien;
                if (string.IsNullOrEmpty(txbTaiKhoan.Text) || string.IsNullOrEmpty(txbTaiKhoanNhan.Text))
                {
                    MessageBox.Show("Nhập số tài khoản để thức hiện giao dịch");
                    return;
                }
                if (!int.TryParse(txbSoTien.Text, out soTien) || soTien <= 0)
                {
                    MessageBox.Show("Nhập số tiền hợp lệ để thức hiện giao dịch");
                    return;
                }
                string query = "UPDATE tblTaiKhoan SET SoDu =SoDu + @Sodu WHERE SoTaiKhoan = @SoTaiKhoan ";
                string querry = "UPDATE tblTaiKhoan SET SoDu =SoDu - @Sodu WHERE SoTaiKhoan = @SoTaiKhoan";
                try
                {
                    using (SqlConnection conn = new SqlConnection(SQLConnectionstring))
                    {
                        conn.Open();
                        SqlTransaction trans = conn.BeginTransaction();
                        try
                        {
                            using (SqlCommand cmdG = new SqlCommand(querry, conn, trans))
                            {
                                cmdG.Parameters.AddWithValue("@Sodu", soTien);
                                cmdG.Parameters.AddWithValue("@SoTaiKhoan", STK);
                                cmdG.ExecuteNonQuery();
                            }
                            using (SqlCommand cmdG = new SqlCommand(query, conn, trans))
                            {
                                cmdG.Parameters.AddWithValue("@Sodu", soTien);
                                cmdG.Parameters.AddWithValue("@SoTaiKhoan", STKN);
                                cmdG.ExecuteNonQuery();
                            }
                            trans.Commit();
                            MessageBox.Show("Giao dịch thành công!");
                        }
                        catch (Exception ex)
                        {
                            trans.Rollback();
                            MessageBox.Show("Giao dịch thất bại: " + ex.Message);
                        }
                    }
                    updateLS.GDChuyenkhoan(STK, STKN, soTien);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message);
                }
            }
        }
        private void dtTKN_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dtTKN.Rows[e.RowIndex];
                lbNguoinhan.Text = row.Cells["TenTaiKhoan"].Value.ToString();
                lbSTKN.Text = row.Cells["SoTaiKhoan"].Value.ToString();
            }
        }
        private void txbSoTien_TextChanged_1(object sender, EventArgs e)
        {
            lbSoTien.Text = txbSoTien.Text;
        }
        private void txbSoTien_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
