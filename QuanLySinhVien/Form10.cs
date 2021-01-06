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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void lblHoTen_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
        private void getInformation()
        {
            Nvien ns = new Nvien();
            Connection cnn = new Connection();
            int idcv = Form8.idcv;
            cnn.connect();
            var query = "SELECT * FROM CongViec WHERE ID=" + idcv + "";
            using (SqlDataReader SqlRead = cnn.getDataReader(query))
            {
                while (SqlRead.Read())
                {
                    tbxTenCV.Text = SqlRead["TenCV"].ToString();
                    tbxMota.Text = SqlRead["TenCV"].ToString();
                    int idpb = Convert.ToInt32(SqlRead["IDPhongBan"].ToString());
                    if (idpb == 1)
                    {
                        cbxPhongBan.Text = "Phòng kế toán";
                    }
                    if (idpb == 2)
                    {
                        cbxPhongBan.Text = "Phòng sale";
                    }
                    if (idpb == 3)
                    {
                        cbxPhongBan.Text = "Phòng kỹ thuật";
                    }
                    dateTimePicker1.Text = SqlRead["ThoiGianBatDau"].ToString();
                    dateTimePicker2.Text = SqlRead["ThoiGianKetThuc"].ToString();
                    tbxIDnv.Text = SqlRead["IDNhanVien"].ToString();

                }
            }
            cnn.disconnect();
        }
        private void Form10_Load(object sender, EventArgs e)
        {
            if (Form8.idcv == 0)
            {
                getInformation();

            }
            else 
            {
                getInformation();
                btnThem.Text = "Lưu";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Connection cnn = new Connection();
            cnn.connect();
            int idtkmoi = 0;
            if (Form8.idcv == 0)
            {
                SqlCommand command = new SqlCommand("INSERT INTO CongViec(IDPhongBan,TenCV,MoTa,ThoiGianBatDau,ThoiGianKetThuc,TrangThai,IDNhanVien) VALUES(@a,@b,@c,@d,@e,@f,@g)");
                command.Parameters.AddWithValue("@b", tbxTenCV.Text.Trim());
                command.Parameters.AddWithValue("@c", tbxMota.Text.Trim());
                command.Parameters.AddWithValue("@e", dateTimePicker2.Text.Trim());
                command.Parameters.AddWithValue("@d", dateTimePicker1.Text.Trim());
                command.Parameters.AddWithValue("@g", tbxIDnv.Text.Trim());
                int id3 = 0;
                if (cbxPhongBan.Text == "Phòng kế toán")
                {
                    id3 = 1;
                }
                if (cbxPhongBan.Text == "Phòng sale")
                {
                    id3 = 2;
                }
                if (cbxPhongBan.Text == "Phòng kỹ thuật")
                {
                    id3 = 3;
                }
                DateTime today = DateTime.Today;
                if (today > dateTimePicker2.Value)
                {
                    command.Parameters.AddWithValue("@f", "Hoàn Thành");
                }
                else
                {
                    command.Parameters.AddWithValue("@f", "Chưa Hoàn Thành");
                }
                command.Parameters.AddWithValue("@a", id3);
                int checkquery = cnn.ExecuteNonQuery(command);
                if (checkquery == 0)
                {
                    MessageBox.Show("Cap nhat that bai vui long thu lai!");
                }
                else
                {
                    MessageBox.Show("Thêm thanh cong!");
                    this.Close();
                }
            }
            else
            {
                SqlCommand command4 = new SqlCommand("UPDATE CongViec SET TenCV=@b,MoTa=@c,ThoiGianBatDau=@d,ThoiGianKetThuc=@e,TrangThai=@f,IDPhongBan=@a,IDNhanVien=@g WHERE ID=@h");
                command4.Parameters.AddWithValue("@b", tbxTenCV.Text.Trim());
                command4.Parameters.AddWithValue("@c", tbxMota.Text.Trim());
                command4.Parameters.AddWithValue("@e", dateTimePicker2.Text.Trim());
                command4.Parameters.AddWithValue("@d", dateTimePicker1.Text.Trim());
                command4.Parameters.AddWithValue("@g", tbxIDnv.Text.Trim());
                command4.Parameters.AddWithValue("@h", Form8.idcv);
                int id3 = 0;
                if (cbxPhongBan.Text == "Phòng kế toán")
                {
                    id3 = 1;
                }
                if (cbxPhongBan.Text == "Phòng sale")
                {
                    id3 = 2;
                }
                if (cbxPhongBan.Text == "Phòng kỹ thuật")
                {
                    id3 = 3;
                }
                DateTime today = DateTime.Today;
                if (today > dateTimePicker2.Value)
                {
                    command4.Parameters.AddWithValue("@f", "Hoàn Thành");
                }
                else
                {
                    command4.Parameters.AddWithValue("@f", "Chưa Hoàn Thành");
                }
                command4.Parameters.AddWithValue("@a", id3);
                int checkquery = cnn.ExecuteNonQuery(command4);
                if (checkquery == 0)
                {
                    MessageBox.Show("Cap nhat that bai vui long thu lai!");
                }
                else
                {
                    MessageBox.Show("Cap nhat thanh cong!");
                    this.Close();
                }
            }
        }
    }
}
