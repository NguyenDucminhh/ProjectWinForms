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
        // kết nối csdl 
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

        //tạo câu lệnh truy vấn thêm sửa xóa
        public static int ExecuteNonQuery(string query)
        {
            using(SqlConnection conn = GetConnection())
            {
                conn.Open();
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
