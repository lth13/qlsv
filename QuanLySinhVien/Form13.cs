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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            if (comboBox1.Text == "Phòng kế toán")
            {
                id = 1;
                getInfo(id);
            }
            if (comboBox1.Text == "Phòng sale")
            {
                id = 2;
                getInfo(id);
            }
            if (comboBox1.Text == "Phòng kỹ thuật")
            {
                id = 3;
                getInfo(id);
            }
            if (comboBox1.Text == "Tất cả")
            {
                getInfo();
            }
        }
        void getInfo(int d)
        {
            Connection cnn = new Connection();
            cnn.connect();
            SqlCommand cm1 = new SqlCommand("SELECT COUNT(ID) AS CT FROM ThongTin WHERE ThoiGianKetThuc > convert(varchar, getdate(), 20) AND IDPhongBan=@a");
            SqlCommand cm2 = new SqlCommand("SELECT COUNT(ID) AS CT FROM ThongTin WHERE ThoiGianKetThuc < convert(varchar, getdate(), 20) AND IDPhongBan=@b");
            cm1.Parameters.AddWithValue("@a", d);
            cm2.Parameters.AddWithValue("@b", d);
            using (SqlDataReader SqlRead = cnn.getDataReader(cm1))
            {
                while (SqlRead.Read())
                {
                    label4.Text = SqlRead["CT"].ToString();
                }
            }
            cnn.disconnect();
            cnn.connect();
            using (SqlDataReader SqlRead2 = cnn.getDataReader(cm2))
            {
                while (SqlRead2.Read())
                {
                    label5.Text = SqlRead2["CT"].ToString();
                }
            }
            cnn.disconnect();
            SqlCommand cm3 = new SqlCommand("SELECT ID,HoTen,NgaySinh,GioiTinh,QueQuan,SoDienThoai,DiaChi,Email,ChucVu,ThoiGianBatDau,ThoiGianKetThuc FROM ThongTin WHERE ID>4 AND IDPhongBan=@c");
            cm3.Parameters.AddWithValue("@c", d);
            listView1.Items.Clear();
            cnn.connect();
            using (SqlDataReader SqlRead = cnn.getDataReader(cm3))
            {
                while (SqlRead.Read())
                {
                    ListViewItem lv = new ListViewItem(SqlRead.GetInt32(0).ToString());
                    lv.SubItems.Add(SqlRead.GetString(1).ToString());
                    lv.SubItems.Add(SqlRead.GetDateTime(2).ToString());
                    lv.SubItems.Add(SqlRead.GetString(3).ToString());
                    lv.SubItems.Add(SqlRead.GetString(4).ToString());
                    lv.SubItems.Add(SqlRead.GetInt32(5).ToString());
                    lv.SubItems.Add(SqlRead.GetString(6).ToString());
                    lv.SubItems.Add(SqlRead.GetString(7).ToString());
                    lv.SubItems.Add(SqlRead.GetString(8).ToString());
                    lv.SubItems.Add(SqlRead.GetString(9).ToString());
                    lv.SubItems.Add(SqlRead.GetString(10).ToString());
                    listView1.Items.Add(lv);
                }
            }
            cnn.disconnect();
        }
        void getInfo()
        {
            Connection cnn = new Connection();
            cnn.connect();
            SqlCommand cm1 = new SqlCommand("SELECT COUNT(ID) AS CT FROM ThongTin WHERE ThoiGianKetThuc > convert(varchar, getdate(), 20)");
            SqlCommand cm2 = new SqlCommand("SELECT COUNT(ID) AS CT FROM ThongTin WHERE ThoiGianKetThuc < convert(varchar, getdate(), 20)");
            using (SqlDataReader SqlRead = cnn.getDataReader(cm1))
            {
                while (SqlRead.Read())
                {
                    label4.Text = SqlRead["CT"].ToString();
                }
            }
            cnn.disconnect();
            cnn.connect();
            using (SqlDataReader SqlRead2 = cnn.getDataReader(cm2))
            {
                while (SqlRead2.Read())
                {
                    label5.Text = SqlRead2["CT"].ToString();
                }
            }
            cnn.disconnect();
            SqlCommand cm3 = new SqlCommand("SELECT ID,HoTen,NgaySinh,GioiTinh,QueQuan,SoDienThoai,DiaChi,Email,ChucVu,ThoiGianBatDau,ThoiGianKetThuc FROM ThongTin WHERE ID>4");
            listView1.Items.Clear();
            cnn.connect();
            using (SqlDataReader SqlRead = cnn.getDataReader(cm3))
            {
                while (SqlRead.Read())
                {
                    ListViewItem lv = new ListViewItem(SqlRead.GetInt32(0).ToString());
                    lv.SubItems.Add(SqlRead.GetString(1).ToString());
                    lv.SubItems.Add(SqlRead.GetDateTime(2).ToString());
                    lv.SubItems.Add(SqlRead.GetString(3).ToString());
                    lv.SubItems.Add(SqlRead.GetString(4).ToString());
                    lv.SubItems.Add(SqlRead.GetInt32(5).ToString());
                    lv.SubItems.Add(SqlRead.GetString(6).ToString());
                    lv.SubItems.Add(SqlRead.GetString(7).ToString());
                    lv.SubItems.Add(SqlRead.GetString(8).ToString());
                    lv.SubItems.Add(SqlRead.GetString(9).ToString());
                    lv.SubItems.Add(SqlRead.GetString(10).ToString());
                    listView1.Items.Add(lv);
                }
            }
            cnn.disconnect();
        }
        private void Form13_Load(object sender, EventArgs e)
        {
            getInfo();
        }
    }
}
