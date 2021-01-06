using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String a = tbxThongBao.Text.Trim();
            DateTime today = DateTime.Today;
            String b = today.ToString("dd/MM/yyyy");
            String c = "";
            User usr = new User();
            Connection cnn = new Connection();
            int id = usr.Id;
            var query = "SELECT * FROM ThongTin WHERE UserID=" + id + "";
            using (SqlDataReader SqlRead = cnn.getDataReader(query))
            {
                while (SqlRead.Read())
                {
                    c = SqlRead["IDPhongBan"].ToString();
                }
            }
            SqlCommand query2 =new SqlCommand("INSERT INTO ThongBao (IDPhongBan,NoiDung,ThoiGianTao,IDNguoiTao) VALUES (@a,@b,@c,@d)");
            query2.Parameters.AddWithValue("@a", c);
            query2.Parameters.AddWithValue("@b", a);
            query2.Parameters.AddWithValue("@c", b);
            query2.Parameters.AddWithValue("@d", id);
            int i = cnn.ExecuteNonQuery(query2);
            if (i == 0)
            {
                MessageBox.Show("Cap nhat that bai vui long thu lai!");
            }
            else
            {
                MessageBox.Show("Cap nhat thanh cong!");
                tbxThongBao.Clear();
            }

        }
    }
}
