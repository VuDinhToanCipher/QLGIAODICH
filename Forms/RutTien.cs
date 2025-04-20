using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLGIAODICH.Helper;
using QLGIAODICH.Services;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using QLGIAODICH.Models;
using System.Collections;

namespace QLGIAODICH
{
    public partial class RutTien : Form
    {
        string SQLConnectionstring = @"Data Source=TOANVU;Initial Catalog=QLGIAODICH;Integrated Security=True;Trust Server Certificate=True";
        CapNhatlichsugiaodich updateLS;
        Search timkiem;
        string STK;
        public RutTien()
        {
            updateLS = new CapNhatlichsugiaodich(SQLConnectionstring);
            STK = "";
            timkiem = new Search(SQLConnectionstring);
            InitializeComponent();
        }
        //Giao dich rut
        private void RutTien_Load(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lbEmployee.Text = Session.TenNhanVien;
            ConfiguImage.resizeimg_inbutton(btnSearch, 40, 40);
            SuakichcoPanel.Fix(0.68f, 1.5f, pn1, this, (int)(this.ClientSize.Width * 0.01f), 0);
            SuakichcoPanel.Fix(0.69f, 1.5f, pn2, this, (int)(this.ClientSize.Width * 0.7f), 0);

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string value = txtTaiKhoan.Text.Trim();
            string query = $"SELECT SoTaiKhoan,TenTaiKhoan, SoDu FROM tblTaiKhoan WHERE SoTaiKhoan = @value ";
            dtTK.DataSource = timkiem.Timkiem(query, value);
        }
        private void dtTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dtTK.Rows[e.RowIndex];
                lbUserName.Text = row.Cells["TenTaiKhoan"].Value.ToString();
                lbSTK.Text = row.Cells["SoTaiKhoan"].Value.ToString();
            }
        }
        private void txtSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtSoTien_TextChanged(object sender, EventArgs e)
        {
            lblTransactionAmount.Text = txtSoTien.Text;
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "SURE?",
                "Xác nhận cập nhật",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            decimal sotienrut;
            STK = txtTaiKhoan.Text.Trim();
            if (STK.IsNullOrEmpty())
            {
                MessageBox.Show("Hãy nhập số tài khoản để thực hiện giao dịch");
                return;
            }
            if (decimal.TryParse(txtSoTien.Text.Trim(), out sotienrut))
            {
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số tiền hợp lệ.");
            }
            string query = $"UPDATE tblTaiKhoan SET Sodu -= @Sodu WHERE SoTaiKhoan = @STK ";
            if (result == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(SQLConnectionstring))
                {
                    con.Open();
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Sodu", sotienrut);
                            cmd.Parameters.AddWithValue("@STK", STK);
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
                    updateLS.GDRuttien(STK, sotienrut);
                }
            }
        }
    }
}

