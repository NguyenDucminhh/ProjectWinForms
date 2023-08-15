using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjectWinForms
{
    internal class DataBaseManager
    {
      private static  string connectionString = "Data Source=DESKTOP-FILOATR\\SQLEXPRESS;Initial Catalog=QuanLyBanHang;User ID=sa;Password=123";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
        public static DataTable ExecuteQuery(string query)
        {
            using (SqlConnection conn  = GetConnection())
            {
                conn.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable result = new DataTable();
                    adapter.Fill(result);
                    return result;
                }
            }
        }
    }
}
