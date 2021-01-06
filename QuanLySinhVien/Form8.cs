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
        public static int idcv;
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
            listView1.Items.Clear();
            Connection cnn = new Connection();
            int id = usr.Id;
            string username = usr.Username;
            cnn.connect();
            var query = "SELECT ID,TenCV,MoTa,ThoiGianBatDau,ThoiGianKetThuc,TrangThai,IDNhanVien FROM CongViec";
            using (SqlDataReader SqlRead = cnn.getDataReader(query))
            {
                while (SqlRead.Read())
                {
                    ListViewItem lv = new ListViewItem(SqlRead.GetInt32(0).ToString());
                    lv.SubItems.Add(SqlRead.GetString(1).ToString());
                    lv.SubItems.Add(SqlRead.GetString(2).ToString());
                    if (!SqlRead.IsDBNull(3) == true)
                    {
                        lv.SubItems.Add(SqlRead.GetDateTime(3).ToString());
                    }
                    else
                    {
                        lv.SubItems.Add("NULL");
                    }
                    if (!SqlRead.IsDBNull(4) == true)
                    {
                        lv.SubItems.Add(SqlRead.GetDateTime(4).ToString());
                    }
                    else
                    {
                        lv.SubItems.Add("NULL");
                    }
                    if (!SqlRead.IsDBNull(5) == true)
                    {
                        lv.SubItems.Add(SqlRead.GetString(5).ToString());
                    }
                    else
                    {
                        lv.SubItems.Add("NULL");
                    }
                    lv.SubItems.Add(SqlRead.GetInt32(6).ToString());
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
            SqlCommand query =new SqlCommand("SELECT ID,TenCV,MoTa,ThoiGianBatDau,ThoiGianKetThuc,TrangThai,IDNhanVien FROM CongViec WHERE IDPhongBan=@id");
            query.Parameters.AddWithValue("@id", id);
            using (SqlDataReader SqlRead = cnn.getDataReader(query))
            {
                while (SqlRead.Read())
                {
                    ListViewItem lv = new ListViewItem(SqlRead.GetInt32(0).ToString());
                    lv.SubItems.Add(SqlRead.GetString(1).ToString());
                    lv.SubItems.Add(SqlRead.GetString(2).ToString());
                    if (!SqlRead.IsDBNull(3)==true)
                    {
                        lv.SubItems.Add(SqlRead.GetDateTime(3).ToString());
                    }
                    else
                    {
                        lv.SubItems.Add("NULL");
                    }
                    if (!SqlRead.IsDBNull(4)==true)
                    {
                        lv.SubItems.Add(SqlRead.GetDateTime(4).ToString());
                    }
                    else
                    {
                        lv.SubItems.Add("NULL");
                    }
                    if (!SqlRead.IsDBNull(5)==true)
                    {
                        lv.SubItems.Add(SqlRead.GetString(5).ToString());
                    }
                    else
                    {
                        lv.SubItems.Add("NULL");
                    }
                    lv.SubItems.Add(SqlRead.GetInt32(6).ToString());
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
                getInfo(id);

            }
            if (cbxPhongBan.Text == "Phòng sale")
            {
                id = 2;
                getInfo(id);

            }
            if (cbxPhongBan.Text == "Phòng kỹ thuật")
            {
                id = 3;
                getInfo(id);
            }
            if (cbxPhongBan.Text == "Tất cả")
            {
                getInformation();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems == null)
            {
                MessageBox.Show("Bạn đang không chọn dòng dữ liệu.Vui lòng chọn dòng dữ liệu!");
            }
            else
            {
                string message = "Bạn có chắc muốn xóa dữ liệu không?";
                string title = "Xác nhận xóa!";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                Connection cnn = new Connection();
                cnn.connect();
                if (result == DialogResult.Yes)
                {
                    SqlCommand command = new SqlCommand("DELETE FROM CongViec WHERE ID=@gjh");
                    command.Parameters.AddWithValue("@gjh", idcv);
                    int check = cnn.ExecuteNonQuery(command);
                    if (check == 0)
                    {
                        MessageBox.Show("Không xóa được dữ liệu.Vui lòng thử lại");
                    }
                    else
                    {
                        MessageBox.Show("Đã xóa dữ liệu");
                        getInformation();
                    }
                }
                else
                {
                }
                cnn.disconnect();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                idcv = Convert.ToInt32(item.SubItems[0].Text);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            idcv = 0;
            Form10 frm9 = new Form10();
            frm9.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Form10 frm9 = new Form10();
            frm9.Show();
        }
    }
}
