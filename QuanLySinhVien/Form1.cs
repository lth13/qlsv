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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            var conn = new SqlConnection("Data Source=DESKTOP-HJKTD4A;Initial Catalog=QuanLySinhVien;Integrated Security=True");
            conn.Open();
            string a = txbTenDangNhap.Text;
            string b = txbMatKhau.Text;
            var query = new SqlCommand("SELECT * FROM TaiKhoan WHERE TenDangNhap = '"+a+"'AND MatKhau = '"+b+"'",conn);
            SqlDataAdapter da = new SqlDataAdapter(query);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    string c = dr["quyen"].ToString();
                    MessageBox.Show("Dang nhap thanh cong");
                }
            }
            conn.Close();
        }
    }
}
