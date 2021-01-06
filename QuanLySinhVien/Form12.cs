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
    public partial class Form12 : Form
    {
        int idd;
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            CustomCTCV[] cv = new CustomCTCV[30];
            int i = 0;
            Connection cnn = new Connection();
            idd = Form5.iddong;
            SqlCommand command = new SqlCommand("SELECT HoTen FROM ThongTin WHERE ID=@a");
            command.Parameters.AddWithValue("@a", idd);
            cnn.connect();
            using (SqlDataReader SqlRead = cnn.getDataReader(command))
            {
                while (SqlRead.Read())
                {
                    label2.Text = SqlRead["HoTen"].ToString();
                }
            }
            cnn.disconnect();
            cnn.connect();
            SqlCommand command2 = new SqlCommand("SELECT * FROM CongViec WHERE IDNhanVien=@b");
            command2.Parameters.AddWithValue("@b", idd);
            using (SqlDataReader SqlRead2 = cnn.getDataReader(command2))
            {
                while (SqlRead2.Read())
                {
                    cv[i] = new CustomCTCV();
                    cv[i].Title = SqlRead2["IDPhongBan"].ToString();
                    cv[i].Tcv = SqlRead2["TenCV"].ToString();
                    cv[i].Message = SqlRead2["Mota"].ToString();
                    cv[i].Tgian = SqlRead2["ThoiGianKetThuc"].ToString();
                    cv[i].Ngtao = SqlRead2["TrangThai"].ToString();
                    flowLayoutPanel1.Controls.Add(cv[i]);
                    i++;
                }
            }
            cnn.disconnect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 frm12 = new Form5();
            frm12.TopLevel = false;
            this.Controls.Add(frm12);
            frm12.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm12.Dock = DockStyle.Fill;
            frm12.BringToFront();
            frm12.Show();
        }
    }
}
