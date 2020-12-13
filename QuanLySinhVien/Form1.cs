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
        private int c=3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public string ConnectionString()
        {
            string cn1 = "Data Source=DESKTOP-DPKOOS5;Initial Catalog=QuanLySinhVien;Integrated Security=True";
            string cn2 = "Data Source=DESKTOP-HJKTD4A;Initial Catalog=QuanLySinhVien;Integrated Security=True";
            string cn3 = "Data Source=DESKTOP-03QADQ3;Initial Catalog=QuanLySinhVien;Integrated Security=True";
            var conn1 = new SqlConnection(cn1);
            var conn2 = new SqlConnection(cn2);
            var conn3 = new SqlConnection(cn3);
            try
            {
                conn1.Open();
                return cn1;
            }
            catch
            {
                try
                {
                    conn2.Open();
                    return cn2;
                }
                catch
                {
                    try
                    {
                        conn3.Open();
                        return cn3;
                    }
                    catch
                    {
                        string cn4 = "false";
                        return cn4;
                    }
                }
            }
                
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string cn = ConnectionString();
            var conn = new SqlConnection(cn);
            //Dũng Database Connection: Data Source=DESKTOP-DPKOOS5;Initial Catalog=QuanLySinhVien;Integrated Security=True
            //Huỳn Database Connection: Data Source=DESKTOP-HJKTD4A;Initial Catalog=QuanLySinhVien;Integrated Security=True
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
                    Form2 frm2 = new Form2();
                    c = Convert.ToInt32(dr["quyen"].ToString());
                    MessageBox.Show("Dang nhap thanh cong");
                    if (System.Windows.Forms.Application.OpenForms["Form2"] != null)
                    {
                        (System.Windows.Forms.Application.OpenForms["Form2"] as Form2).unlockFunction(c);
                    }
                    this.Close();
                }
            }
            conn.Close();
        }
    }
}
