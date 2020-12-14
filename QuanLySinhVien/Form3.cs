using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLySinhVien
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            getInformation();

        }
        private void getInformation()
        {
            User usr = new User();
            int id = usr.Id;
            string username = usr.Username;
            string cnn = usr.Cnn;
            var conn = new SqlConnection(cnn);
            conn.Open();
            var query = new SqlCommand("SELECT * FROM ThongTin WHERE UserID="+id+"", conn);
            using (SqlDataReader SqlRead = query.ExecuteReader())
            {
                while (SqlRead.Read())
                {
                    tbxID.Text = SqlRead["ID"].ToString();
                    tbxHoTen.Text = SqlRead["HoTen"].ToString();
                    tbxNgaySinh.Text = SqlRead["NgaySinh"].ToString();
                    string gt = SqlRead["GioiTinh"].ToString();
                    if(gt == "Nam")
                    {
                        rdbNam.Checked = true;
                    }
                    else
                    {
                        rdbNu.Checked = true;
                    }
                    tbxQueQuan.Text = SqlRead["QueQuan"].ToString();
                    int pb = Convert.ToInt32(SqlRead["IDPhongBan"].ToString());
                    if (pb == 0)
                    {
                        tbxPhongBan.Text = "Admin";
                    }
                    else
                    {
                        SqlCommand queries = new SqlCommand("SELECT * FROM PhongBan WHERE ID=@id");
                        queries.Parameters.AddWithValue("@id", pb);
                        using (SqlDataReader SqlRead2 = queries.ExecuteReader())
                        {
                            while (SqlRead.Read())
                            {
                                tbxPhongBan.Text = SqlRead["TenPhongBan"].ToString();
                            }
                        }
                    }
                    tbxSoDienThoai.Text = SqlRead["SoDienThoai"].ToString();
                    tbxChucVu.Text = SqlRead["ChucVu"].ToString();
                    tbxEmail.Text = SqlRead["Email"].ToString();
                    tbxDiaChi.Text = SqlRead["DiaChi"].ToString();
                    tbxTenDangNhap.Text = username;
                }
            }
            conn.Close();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
