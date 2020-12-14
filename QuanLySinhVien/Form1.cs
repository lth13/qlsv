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
        public string cn;
        public string username;
        public int id;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Connection cn = new Connection();
            cn.connect();
            string a = txbTenDangNhap.Text;
            string b = txbMatKhau.Text;
            var query = "SELECT * FROM TaiKhoan WHERE TenDangNhap = '"+a+"'AND MatKhau = '"+b+"'";
            DataView dt = new DataView(cn.getDataTable(query));
            if (dt != null)
            {
                foreach (DataRowView dr in dt)
                {
                    Form2 frm2 = new Form2();
                    c = Convert.ToInt32(dr["quyen"].ToString());
                    id = Convert.ToInt32(dr["ID"].ToString());
                    username = dr["TenDangNhap"].ToString();
                    MessageBox.Show("Dang nhap thanh cong");
                    if (System.Windows.Forms.Application.OpenForms["Form2"] != null)
                    {
                        (System.Windows.Forms.Application.OpenForms["Form2"] as Form2).unlockFunction(c);
                    }
                    User usr = new User();
                    usr.Username = username;
                    usr.Id = id;
                    this.Close();
                }
            }
            cn.disconnect();
        }
    }
}
