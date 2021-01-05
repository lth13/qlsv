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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            getInformation();
        }
        private void getInformation()
        {
            User usr = new User();
            listView1.FullRowSelect = true;
            Connection cnn = new Connection();
            int id = usr.Id;
            string username = usr.Username;
            cnn.connect();
            listView1.Items.Clear();
            var query = "SELECT ID,HoTen,NgaySinh,GioiTinh,QueQuan,SoDienThoai,DiaChi,Email,ChucVu FROM ThongTin";
            using (SqlDataReader SqlRead = cnn.getDataReader(query))
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
                    listView1.Items.Add(lv);
                }
            }
            cnn.disconnect();
        }
        private void getInfo(int id)
        {
            User usr = new User();
            listView1.FullRowSelect = true;
            Connection cnn = new Connection();
            cnn.connect();
            listView1.Items.Clear();
            SqlCommand query =new SqlCommand("SELECT ID,HoTen,NgaySinh,GioiTinh,QueQuan,SoDienThoai,DiaChi,Email,ChucVu FROM ThongTin WHERE IDPhongBan = @id");
            query.Parameters.AddWithValue("@id", id);
            using (SqlDataReader SqlRead = cnn.getDataReader(query))
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
                    listView1.Items.Add(lv);
                }
            }
            cnn.disconnect();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
        }

        private void cbxPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            if (cbxPhongBan.Text == "Phòng kế toán")
            {
                id = 1;
            }
            if (cbxPhongBan.Text == "Phòng sale")
            {
                id = 2;
            }
            if (cbxPhongBan.Text == "Phòng kỹ thuật")
            {
                id = 3;
            }
            getInfo(id);
        }
    }
}
