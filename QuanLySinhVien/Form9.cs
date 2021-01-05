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
    public partial class Form9 : Form
    {
        int idd;
        public Form9()
        {
            InitializeComponent();
        }
        private void Form9_Load(object sender, EventArgs e)
        {
            idd = Form5.iddong;
            if (idd != 0)
            {
                getInformation();
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {

        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
        }
        private void getInformation()
        {
            Nvien ns = new Nvien();
            Connection cnn = new Connection();
            cnn.connect();
            var query = "SELECT * FROM ThongTin WHERE UserID=" + idd + "";
            using (SqlDataReader SqlRead = cnn.getDataReader(query))
            {
                while (SqlRead.Read())
                {
                    tbxID.Text = SqlRead["ID"].ToString();
                    tbxHoTen.Text = SqlRead["HoTen"].ToString();
                    tbxNgaySinh.Text = SqlRead["NgaySinh"].ToString();
                    string gt = SqlRead["GioiTinh"].ToString();
                    if (gt == "Nam")
                    {
                        rdbNam.Checked = true;
                    }
                    else
                    {
                        rdbNu.Checked = true;
                    }
                    tbxQueQuan.Text = SqlRead["QueQuan"].ToString();
                    int pb = Convert.ToInt32(SqlRead["IDPhongBan"].ToString());
                    if (pb == 0)
                    {
                        cbxPhongBan.Text = "Admin";
                    }
                    else
                    {
                        var queries = "SELECT * FROM PhongBan WHERE ID='" + pb + "'";
                        using (SqlDataReader SqlRead2 = cnn.getDataReader(queries))
                        {
                            while (SqlRead2.Read())
                            {
                                cbxPhongBan.Text = SqlRead2["TenPhongBan"].ToString();
                            }
                        }
                    }
                    tbxSoDienThoai.Text = SqlRead["SoDienThoai"].ToString();
                    tbxChucVu.Text = SqlRead["ChucVu"].ToString();
                    tbxEmail.Text = SqlRead["Email"].ToString();
                    tbxDiaChi.Text = SqlRead["DiaChi"].ToString();
                }
            }
            cnn.disconnect();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
