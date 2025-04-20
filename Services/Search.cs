using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace QLGIAODICH.Services
{
    internal class Search
    {
        string SQLconnectionstring;
        public Search(string SQLconnectionstring)
        {
            this.SQLconnectionstring = SQLconnectionstring;
        }
        public DataTable Timkiem(string query, string value)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(SQLconnectionstring))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Thêm tham số an toàn
                    cmd.Parameters.Add("@value", SqlDbType.NVarChar).Value = value;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

    }
}
