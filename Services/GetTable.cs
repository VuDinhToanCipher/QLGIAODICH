using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace QLGIAODICH.Services
{
   
    public class GetTable
    {
        private string Connectionstring;
        public GetTable(string connectionstring)
        {
            Connectionstring = connectionstring;
        }
        public void getdata(string query,DataGridView data)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con =new SqlConnection(Connectionstring))
                {
                    con.Open();
                    SqlDataAdapter cmd = new SqlDataAdapter(query, con);
                    cmd.Fill(dt);
                    data.DataSource = dt;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
           
        }
    }
}
