using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace QLGIAODICH.Services
{
    internal class RandSTK
    {
        string connectionstring;
        Random r = new Random();
        string STK;
        int test;
        public RandSTK(string connectionstring)
        {
            this.connectionstring = connectionstring;
        }
        public string SoTaiKhoan(string Table,string Colunm)
        {
           
            do
            {
                STK = "";
                for(int i = 0; i < 12; i++)
                {
                  STK += r.Next(1,10).ToString();
                }
                string query = $"SELECT COUNT(*) FROM {Table} WHERE {Colunm} = @STK";
                using(SqlConnection con = new SqlConnection(connectionstring))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query,con);
                    try
                    {
                        test = (int)cmd.ExecuteScalar();
                    }
                    catch (Exception)
                    {

                    }
                   
                    if ( test == 0)
                    {
                        break;
                    }

                }

            } while (true);
            return STK;

        }
    }
}
