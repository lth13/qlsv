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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        private void Form11_Load(object sender,EventArgs e)
        {
            GetData();
        }
        private void GetData()
        {
            CustomCV[] cv = new CustomCV[20];
            Connection cnn = new Connection();
            cnn.connect();
            int i = 0;
            SqlCommand command = new SqlCommand("SELECT * FROM ThongBao");
            flowLayoutPanel1.Controls.Clear();
            using (SqlDataReader SqlRead = cnn.getDataReader(command))
            {
                while (SqlRead.Read())
                {

                    cv[i] = new CustomCV();
                    cv[i].Title = SqlRead["IDPhongBan"].ToString();
                    cv[i].Message = SqlRead["NoiDung"].ToString();
                    cv[i].Tgian = SqlRead["ThoiGianTao"].ToString();
                    cv[i].Ngtao = SqlRead["IDNguoiTao"].ToString();
                    flowLayoutPanel1.Controls.Add(cv[i]);
                    i++;
                }
            }
            cnn.disconnect();
        }
    }
}
