using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace QuanLySinhVien
{
    class Connection
    {
        SqlConnection conn;
        /* Hello gympie nhen để connect nhanh hơn thì cậu hay thay cái phần conn = new SqlConnection(cn1) thay
         * cn1 thành biến máy cậu là cn2 nhá.Chú thích cn1 = laptop của Dũng nè,cn2 = laptop của Huỳn nè, cn3 = PC của Dũng nè,
         * nhớ nhá.:3 */
        string cn1 = "Data Source=DESKTOP-03QADQ3;Initial Catalog=QuanLySinhVien;Integrated Security=True;MultipleActiveResultSets=true";
        string cn2 = "Data Source=DESKTOP-HJKTD4A;Initial Catalog=QuanLySinhVien;Integrated Security=True;MultipleActiveResultSets=true";
        string cn3 = "Data Source=DESKTOP-N7SL8B9;Initial Catalog=QuanLySinhVien;Integrated Security=True;MultipleActiveResultSets=true";
        public void connect()
        {
            if (conn == null)
            {
                conn = new SqlConnection(cn2);
            }
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void disconnect()
        {
            if ((conn != null) && (conn.State == System.Data.ConnectionState.Open))
            {
                conn.Close();
            }
        }
        public DataTable getDataTable(string sql)
        {
            connect();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            disconnect();
            return dt;
        }
        public void ExecuteNonQuery(string sql)
        {
            connect();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            disconnect();
        }
        public void ExecuteNonQuery(SqlCommand sqlcommand)
        {
            connect();
            sqlcommand.ExecuteNonQuery();
            disconnect();
        }
        public SqlDataReader getDataReader(string sql)
        {
            connect();
            SqlCommand com = new SqlCommand(sql, conn);
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }
        public SqlDataReader getDataReader(SqlCommand command)
        {
            connect();
            SqlDataReader dr = command.ExecuteReader();
            return dr;
        }
    }
}
