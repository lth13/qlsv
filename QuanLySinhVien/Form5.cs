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
        private void btnSua_Click(object sender, EventArgs e)
        {
        }
    }
}
