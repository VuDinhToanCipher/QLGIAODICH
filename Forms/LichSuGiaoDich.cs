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
using QLGIAODICH.Helper;
using QLGIAODICH.Services;
using Microsoft.IdentityModel.Tokens;

namespace QLGIAODICH
{
    public partial class LichSuGiaoDich : Form
    {
        GetTable LichSu;
        string SQLConnectionstring = @"Data Source=TOANVU;Initial Catalog=QLGIAODICH;Integrated Security=True;Trust Server Certificate=True";
        public LichSuGiaoDich()
        {
            LichSu = new GetTable(SQLConnectionstring);
            InitializeComponent();
        }
        private void LichSuGiaoDich_Load(object sender, EventArgs e)
        {
            ConfiguImage.resizeimg_inbutton(btnSearch, 50, 50);
            ConfiguImage.resizeimg_inbutton(btnReload, 40, 40);
            string query = $"SELECT * FROM tblGiaoDich";
            LichSu.getdata(query, dtLichsu);
        }

        private void LichSuGiaoDich_SizeChanged(object sender, EventArgs e)
        {
            SuakichcoPanel.Fix(0.55f, 0.8f, pnData, this, 0, (int)(this.ClientSize.Height * (1 - 0.8f)));
            SuakichcoPanel.Fix(0.43f, 0.8f, pnThongtin, this, (int)(this.ClientSize.Width * (1 - 0.43f)), (int)(this.ClientSize.Height * (1 - 0.8f)));
            SuakichcoPanel.Fix(1f, 0.19f, pnThanhcongcu, this, 0, 0);
        }
        private void dtLichsu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string tenTaiKhoan = "";
                string tenLoai = "";
                var row = dtLichsu.Rows[e.RowIndex];
                int maLoai = Convert.ToInt32(row.Cells["LoaiGiaoDich"].Value);
                string stk = row.Cells["TaiKhoanGui"].Value.ToString()!;
                lbSTKN.Text = row.Cells["TaiKhoanNhan"].Value.ToString();
                lbSotien.Text = row.Cells["Sotien"].Value.ToString();
                lbTime.Text = row.Cells["NgayGiaoDich"].Value.ToString();

                if (!string.IsNullOrEmpty(stk))
                {
                    try
                    {
                        using (SqlConnection con = new SqlConnection(SQLConnectionstring))
                        {
                            con.Open();

                            // Lấy tên tài khoản
                            string queryTK = "SELECT TenTaiKhoan FROM tblTaiKhoan WHERE SoTaiKhoan = @stk";
                            using (SqlCommand cmd = new SqlCommand(queryTK, con))
                            {
                                cmd.Parameters.AddWithValue("@stk", stk);
                                object result = cmd.ExecuteScalar();
                                if (result != null)
                                    tenTaiKhoan = result.ToString()!;
                            }

                            // Lấy tên loại giao dịch
                            string queryLoai = "SELECT TenLoai FROM tblLoaiGiaoDich WHERE MaLoai = @maLoai";
                            using (SqlCommand cmd = new SqlCommand(queryLoai, con))
                            {
                                cmd.Parameters.AddWithValue("@maLoai", maLoai);
                                object result = cmd.ExecuteScalar();
                                if (result != null)
                                    tenLoai = result.ToString()!;
                            }
                        }

                        // Gán ra giao diện
                        lbSTK.Text = stk;
                        lbName.Text = tenTaiKhoan;
                        lbType.Text = tenLoai;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM tblGiaoDich";
            LichSu.getdata(query, dtLichsu);
        }
    }
}
