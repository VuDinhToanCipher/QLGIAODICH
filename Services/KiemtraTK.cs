using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGIAODICH.Services
{
    public class TaiKhoanService
    {
        private readonly string _connectionString;

        public TaiKhoanService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool KiemTraTonTai(string soTaiKhoan)
        {
            string query = "SELECT COUNT(*) FROM tblTaiKhoan WHERE SoTaiKhoan = @SoTaiKhoan";
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@SoTaiKhoan", soTaiKhoan);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public bool KiemTraSoDuHopLe(string soTaiKhoan, decimal soTienGiaoDich)
        {
            string query = "SELECT SoDu FROM tblTaiKhoan WHERE SoTaiKhoan = @SoTaiKhoan";
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@SoTaiKhoan", soTaiKhoan);
                    object result = cmd.ExecuteScalar();

                    if (result == null || result == DBNull.Value)
                        return false;

                    decimal soDu = (decimal)result;
                    return soDu >= soTienGiaoDich;
                }
            }
        }
    }
}
