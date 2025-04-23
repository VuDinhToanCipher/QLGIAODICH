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
    public partial class GiaoDich : Form
    {
        string SQLConnectionstring = @"Data Source=TOANVU;Initial Catalog=QLGIAODICH;Integrated Security=True;Trust Server Certificate=True";
        CloseandOpenForms closeopen = new CloseandOpenForms();
        Search timkiem;
        CapNhatlichsugiaodich updateLS;
        
        private Form[] listF = new Form[2];
        string tk;
        public GiaoDich()
        {
            updateLS = new CapNhatlichsugiaodich(SQLConnectionstring);
            tk = "";
            timkiem = new Search(SQLConnectionstring);
            InitializeComponent();
        }
        //Giao dich gui tien
        private void btnGuitien_Click(object sender, EventArgs e)
        {
            closeopen.Closeform(listF); // Đóng tất cả các form con
            btnGuitien.BackColor = SystemColors.ControlDark;
            btnchuyenkhoan.BackColor = SystemColors.Window;
            btnruttien.BackColor = SystemColors.Window;
            this.BringToFront(); // Đảm bảo form chính luôn được đưa ra phía trước
        }
        private void btnruttien_Click(object sender, EventArgs e)
        {
            RutTien rut = new RutTien();
            btnGuitien.BackColor = SystemColors.Window;
            btnchuyenkhoan.BackColor = SystemColors.Window;
            btnruttien.BackColor = SystemColors.ControlDark;
            closeopen.Openform(listF, rut, 0, pnGiaoDich);
        }
        private void btnchuyenkhoan_Click(object sender, EventArgs e)
        {
            ChuyenKhoan chuyenKhoan = new ChuyenKhoan();
            btnGuitien.BackColor = SystemColors.Window;
            btnchuyenkhoan.BackColor = SystemColors.ControlDark;
            btnruttien.BackColor = SystemColors.Window;
            closeopen.Openform(listF, chuyenKhoan, 1, pnGiaoDich);
        }
        private void GiaoDich_Load(object sender, EventArgs e)
        {
            ConfiguImage.resizeimg_inbutton(btnruttien, 100, 100);
            ConfiguImage.resizeimg_inbutton(btnGuitien, 100, 100);
            ConfiguImage.resizeimg_inbutton(btnchuyenkhoan, 100, 100);
            ConfiguImage.resizeimg_inbutton(btnSearch, 40, 40);
            dtGridViewconfig.DTconfig(dtTK);
            SuakichcoPanel.Fix(0.68f, 1f, pn1, this, (int)(this.ClientSize.Width * (0.01)), 0);
            SuakichcoPanel.Fix(0.69f, 1f, pn2, this, (int)(this.ClientSize.Width * (1 - 0.3f)), 0);
            lbTime.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lbEmployee.Text = Session.TenNhanVien;
        }
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string value = txtTaiKhoan.Text.Trim();
            string query = $"SELECT SoTaiKhoan,TenTaiKhoan, SoDu FROM tblTaiKhoan WHERE SoTaiKhoan = @value ";
          
            string query1 = $"SELECT SoTaiKhoan,TenTaiKhoan, SoDu FROM tblTaiKhoan AS tk INNER JOIN tblNguoiDung as nd ON tk.IDNguoiDung = nd.IDNguoiDung WHERE CCCD = @value ";

            if (cbTimTk.Text == "Căn Cước")
            {
                dtTK.DataSource = timkiem.Timkiem(query1, value);
            }
            else
            {
                dtTK.DataSource = timkiem.Timkiem(query, value);
            }
        }
        private void dtTK_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dtTK.Rows[e.RowIndex];
                lbUserName.Text = row.Cells["TenTaiKhoan"].Value.ToString();
                lbSTK.Text = row.Cells["SoTaiKhoan"].Value.ToString();
                txtSelect.Text = row.Cells["SoTaiKhoan"].Value.ToString();
                tk = txtSelect.Text;
            }
        }
        private void txtSoTien_TextChanged_1(object sender, EventArgs e)
        {

            lblTransactionAmount.Text = txtSoTien.Text;
        }
        private void txtSoTien_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnRut_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(
                "SURE?",
                "Xác nhận cập nhật",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            decimal sotiengui;
           
            if (tk.IsNullOrEmpty())
            {
                MessageBox.Show("Hãy nhập số tài khoản để thực hiện giao dịch");
                return;
            }
            if (decimal.TryParse(txtSoTien.Text.Trim(), out sotiengui))
            {
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số tiền hợp lệ.");
            }
            string query = $"UPDATE tblTaiKhoan SET Sodu += @Sodu WHERE SoTaiKhoan = @STK ";
            if (result == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(SQLConnectionstring))
                {
                    con.Open();
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Sodu", sotiengui);
                            cmd.Parameters.AddWithValue("@STK", tk);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Cập nhật số dư thành công!");
                    }
                    catch (Exception ex)
                    {
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                updateLS.GDGuiTien(tk, sotiengui);
            }
        }
    }
}
