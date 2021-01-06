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
        public static int iddong;
        public static string lbl;
        public static int uid;
        public static int quyen;
        public Form5()
        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            User usr = new User();
            int id = usr.Id;
            Connection cnn = new Connection();
            SqlCommand command = new SqlCommand("SELECT * FROM TaiKhoan WHERE ID=@a");
            command.Parameters.AddWithValue("@a", id);
            cnn.connect();
            using (SqlDataReader SqlRead = cnn.getDataReader(command))
            {
                while (SqlRead.Read())
                {
                    quyen = Convert.ToInt32(SqlRead["Quyen"].ToString());
                }
            }
            if (quyen == 0)
            {
                getInformation();
            }
            if (quyen == 1)
            {
                getInformation();
                btnThem.Visible = false;
                btnXoa.Visible = false;
            }
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
            SqlCommand query =new SqlCommand("SELECT ID,HoTen,NgaySinh,GioiTinh,QueQuan,SoDienThoai,DiaChi,Email,ChucVu,UserID FROM ThongTin WHERE IDPhongBan = @id");
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
                    uid = Convert.ToInt32(SqlRead.GetInt32(9).ToString());
                    listView1.Items.Add(lv);
                }
            }
            cnn.disconnect();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            frm9.Show();
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            String tk = tbxTimKiem.Text.Trim();
            User usr = new User();
            listView1.FullRowSelect = true;
            Connection cnn = new Connection();
            cnn.connect();
            listView1.Items.Clear();
            string sql = ("SELECT ID,HoTen,NgaySinh,GioiTinh,QueQuan,SoDienThoai,DiaChi,Email,ChucVu,UserID FROM ThongTin WHERE (HoTen LIKE \'%" + (tk + "%\')"));
            using (SqlDataReader SqlRead = cnn.getDataReader(sql))
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                iddong = Convert.ToInt32(item.SubItems[0].Text);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            iddong = 0;
            Form9 frm9 = new Form9();
            frm9.Show();
        }

        private void btnXemCongViec_Click(object sender, EventArgs e)
        {
            Form12 frm12 = new Form12();
            frm12.TopLevel = false;
            this.Controls.Add(frm12);
            frm12.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm12.Dock = DockStyle.Fill;
            frm12.BringToFront();
            frm12.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count < 0)
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
                    SqlCommand command = new SqlCommand("DELETE FROM ThongTin WHERE ID=@gjh");
                    command.Parameters.AddWithValue("@gjh", iddong);
                    int check = cnn.ExecuteNonQuery(command);
                    SqlCommand command2 = new SqlCommand("DELETE FROM TaiKhoan WHERE ID=@gjj");
                    command2.Parameters.AddWithValue("@gjj", uid);
                    int check2 = cnn.ExecuteNonQuery(command2);
                    if (check == 0 && check2 == 0)
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
    }
}
