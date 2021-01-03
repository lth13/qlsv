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
            Connection cnn = new Connection();
            int id = usr.Id;
            string username = usr.Username;
            cnn.connect();
            var query = "SELECT * FROM ThongTin WHERE UserID="+id+"";
            using (SqlDataReader SqlRead = cnn.getDataReader(query))
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
                        using (SqlDataReader SqlRead2 = cnn.getDataReader2(queries))
                        {
                            while (SqlRead2.Read())
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
            cnn.disconnect();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            btnChinhSua.Visible = false;
            tbxNgaySinh.Enabled = true;
            tbxQueQuan.Enabled = true;
            tbxSoDienThoai.Enabled = true;
            tbxDiaChi.Enabled = true;
            tbxEmail.Enabled = true;
            btnLuu.Visible = true;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();
        }
    }
}
