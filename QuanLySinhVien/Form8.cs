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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        private void Form8_Load(object sender, EventArgs e)
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
            var query = "SELECT TenCV,MoTa,ThoiGianBatDau,ThoiGianKetThuc,TrangThai FROM CongViec";
            using (SqlDataReader SqlRead = cnn.getDataReader(query))
            {
                while (SqlRead.Read())
                {
                    ListViewItem lv = new ListViewItem(SqlRead.GetString(0).ToString());
                    lv.SubItems.Add(SqlRead.GetString(1).ToString());
                    lv.SubItems.Add(SqlRead.GetDateTime(2).ToString());
                    if (!SqlRead.IsDBNull(3))
                    {
                        lv.SubItems.Add(SqlRead.GetDateTime(3).ToString());
                    }
                    if (!SqlRead.IsDBNull(4))
                    {
                        lv.SubItems.Add(SqlRead.GetString(4).ToString());
                    }
                    listView1.Items.Add(lv);
                }
            }
            cnn.disconnect();
        }
        private void getInfo(int id)
        {
            User usr = new User();
            listView1.FullRowSelect = true;
            listView1.Items.Clear();
            Connection cnn = new Connection();
            string username = usr.Username;
            cnn.connect();
            SqlCommand query =new SqlCommand("SELECT TenCV,MoTa,ThoiGianBatDau,ThoiGianKetThuc,TrangThai FROM CongViec WHERE IDPhongBan=@id");
            query.Parameters.AddWithValue("@id", id);
            using (SqlDataReader SqlRead = cnn.getDataReader(query))
            {
                while (SqlRead.Read())
                {
                    ListViewItem lv = new ListViewItem(SqlRead.GetString(0).ToString());
                    lv.SubItems.Add(SqlRead.GetString(1).ToString());
                    lv.SubItems.Add(SqlRead.GetDateTime(2).ToString());
                    if (!SqlRead.IsDBNull(3))
                    {
                        lv.SubItems.Add(SqlRead.GetDateTime(3).ToString());
                    }
                    if (!SqlRead.IsDBNull(4))
                    {
                        lv.SubItems.Add(SqlRead.GetString(4).ToString());
                    }
                    listView1.Items.Add(lv);
                }
            }
            cnn.disconnect();
        }
        private void lblTitle_Click(object sender, EventArgs e)
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
