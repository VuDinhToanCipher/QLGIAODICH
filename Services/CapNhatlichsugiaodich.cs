using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace QLGIAODICH.Services
{
    internal class CapNhatlichsugiaodich
    {
        string Connectionstring;
        public CapNhatlichsugiaodich(string connectionstring)
        {
            this.Connectionstring = connectionstring;
        }
        public void GDGuiTien(string SoTaiKhoan, decimal sotiengui)
        {
            string queryy = $"INSERT INTO tblGiaoDich(TaiKhoanGui,TaiKhoanNhan,LoaiGiaoDich,SoTien) VALUES(@TaiKhoanGui,@TaiKhoanNhan,@LoaiGiaoDich,@SoTien) ";
            try
            {
                using (SqlConnection conn = new SqlConnection(Connectionstring))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(queryy, conn))
                    {
                        cmd.Parameters.AddWithValue("@TaiKhoanGui", SoTaiKhoan);
                        cmd.Parameters.AddWithValue("@TaiKhoanNhan", DBNull.Value);
                        cmd.Parameters.AddWithValue("@LoaiGiaoDich", 2);
                        cmd.Parameters.AddWithValue("SoTien", sotiengui);
                        cmd.ExecuteNonQuery();
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void GDRuttien(string SoTaiKhoan, decimal sotienrut)
        {
            string queryy = $"INSERT INTO tblGiaoDich(TaiKhoanGui,TaiKhoanNhan,LoaiGiaoDich,SoTien) VALUES(@TaiKhoanRut,@TaiKhoanNhan,@LoaiGiaoDich,@SoTien) ";
            try
            {
                using (SqlConnection conn = new SqlConnection(Connectionstring))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(queryy, conn))
                    {
                        cmd.Parameters.AddWithValue("@TaiKhoanRut", SoTaiKhoan);
                        cmd.Parameters.AddWithValue("@TaiKhoanNhan", DBNull.Value);
                        cmd.Parameters.AddWithValue("@LoaiGiaoDich",11);
                        cmd.Parameters.AddWithValue("SoTien", sotienrut);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void GDChuyenkhoan(string SoTaiKhoanGui,string SoTaiKhoanNhan, decimal sotienchuyen)
        {
            string queryy = $"INSERT INTO tblGiaoDich(TaiKhoanGui,TaiKhoanNhan,LoaiGiaoDich,SoTien) VALUES(@TaiKhoanGui,@TaiKhoanNhan,@LoaiGiaoDich,@SoTien) ";
            try
            {
                using (SqlConnection conn = new SqlConnection(Connectionstring))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(queryy, conn))
                    {
                        cmd.Parameters.AddWithValue("@TaiKhoanGui", SoTaiKhoanGui);
                        cmd.Parameters.AddWithValue("@TaiKhoanNhan", SoTaiKhoanNhan);
                        cmd.Parameters.AddWithValue("@LoaiGiaoDich", 1);
                        cmd.Parameters.AddWithValue("SoTien", sotienchuyen);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
