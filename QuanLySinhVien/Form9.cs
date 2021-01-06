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
        String lbl;
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
                tbxID.Enabled = true;
            }
            else
            {
                tbxID.Enabled = false;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            Connection cnn = new Connection();
            cnn.connect();
            int idtkmoi = 0;
            if (idd == 0)
            {
                SqlCommand command = new SqlCommand("INSERT INTO TaiKhoan(TenDangNhap,MatKhau,Quyen) VALUES(@a,@b,@c)");
                if (String.IsNullOrEmpty(tbxTenDangNhap.Text) == true && String.IsNullOrEmpty(txbMatKhau.Text) == true)
                {
                    MessageBox.Show("Vui Long nhap ten dang nhap va mat khau cho nguoi dung nay");
                }
                else
                {
                    command.Parameters.AddWithValue("@a", tbxTenDangNhap.Text.Trim());
                    command.Parameters.AddWithValue("@b", txbMatKhau.Text.Trim());
                    command.Parameters.AddWithValue("@c", 2);
                    int ii = cnn.ExecuteNonQuery(command);
                    SqlCommand command2 = new SqlCommand("SELECT * FROM TaiKhoan WHERE TenDangNhap = @d");
                    using (SqlDataReader SqlRead = cnn.getDataReader(command2))
                    {
                        while (SqlRead.Read())
                        {
                            idtkmoi = Convert.ToInt32(SqlRead["ID"].ToString());
                        }
                    }
                    SqlCommand command3 = new SqlCommand("INSERT INTO ThongTin(UserID,HoTen,NgaySinh,GioiTinh,QueQuan,SoDienThoai,DiaChi,Email,IDPhongBan,ChucVu) VALUES(@a,@b,@c,@d,@e,@f,@g,@h,@i,@j)");
                    command3.Parameters.AddWithValue("@a", idtkmoi);
                    command3.Parameters.AddWithValue("@b", tbxHoTen.Text.Trim());
                    command3.Parameters.AddWithValue("@c", tbxNgaySinh.Text.Trim());
                    String gt;
                    if(rdbNam.Checked == true)
                    {
                        gt = "Nam";
                    }
                    else
                    {
                        gt = "Nu";
                    }
                    command3.Parameters.AddWithValue("@d", gt);
                    command3.Parameters.AddWithValue("@e", tbxQueQuan.Text.Trim());
                    command3.Parameters.AddWithValue("@f", tbxSoDienThoai.Text.Trim());
                    command3.Parameters.AddWithValue("@g", tbxDiaChi.Text.Trim());
                    command3.Parameters.AddWithValue("@h", tbxEmail.Text.Trim());
                    int id3 = 0;
                    if (cbxPhongBan.Text == "Phòng kế toán")
                    {
                        id3 = 1;
                    }
                    if (cbxPhongBan.Text == "Phòng sale")
                    {
                        id3= 2;
                    }
                    if (cbxPhongBan.Text == "Phòng kỹ thuật")
                    {
                        id3 = 3;
                    }
                    command3.Parameters.AddWithValue("@i", id3);
                    command3.Parameters.AddWithValue("@j", tbxChucVu.Text.Trim());
                    int checkquery = cnn.ExecuteNonQuery(command3);
                    if (checkquery == 0 && ii == 0)
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
            else
            {
                SqlCommand command4 = new SqlCommand("UPDATE ThongTin SET HoTen=@a,NgaySinh=@b,GioiTinh=@c,QueQuan=@d,SoDienThoai=@e,DiaChi=@f,Email=@g,IDPhongBan=@i,ChucVu=@j WHERE ID=@h");
                command4.Parameters.AddWithValue("@a", tbxHoTen.Text.Trim());
                command4.Parameters.AddWithValue("@b", tbxNgaySinh.Text.Trim());
                String gt;
                if (rdbNam.Checked == true)
                {
                    gt = "Nam";
                }
                else
                {
                    gt = "Nu";
                }
                command4.Parameters.AddWithValue("@c", gt);
                command4.Parameters.AddWithValue("@d", tbxQueQuan.Text.Trim());
                command4.Parameters.AddWithValue("@e", tbxSoDienThoai.Text.Trim());
                command4.Parameters.AddWithValue("@f", tbxDiaChi.Text.Trim());
                command4.Parameters.AddWithValue("@g", tbxEmail.Text.Trim());
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
                command4.Parameters.AddWithValue("@i", id3);
                command4.Parameters.AddWithValue("@j", tbxChucVu.Text.Trim());
                command4.Parameters.AddWithValue("@h", Convert.ToInt32(tbxID.Text.Trim()));
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
