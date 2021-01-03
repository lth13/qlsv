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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        private void Form6_Load(object sender, EventArgs e)
        {

        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            User usr = new User();
            Connection cnn = new Connection();
            int id = usr.Id;
            string username = usr.Username;
            cnn.connect();
            if (tbxMKmoi.Text != tbxNhapLai.Text)
            {
                MessageBox.Show("Mat khau moi va nhap lai khong hop le!");
            }
            else
            {
                var query = "SELECT * FROM TaiKhoan WHERE ID=" + id + "";
                using (SqlDataReader SqlRead = cnn.getDataReader(query))
                {
                    while (SqlRead.Read())
                    {
                        string mkcu = SqlRead["MatKhau"].ToString().Trim();
                        string mkcutb = tbxMKcu.Text.Trim();
                        lblMKcu.Text = mkcu;
                        lblMKmoi.Text = mkcutb;
                        if (String.Compare(mkcu,mkcutb,true)==0) {
                            var queries2 = "UPDATE TaiKhoan SET MatKhau=" + tbxMKmoi.Text + " WHERE ID=" + id + "";
                            int i = cnn.ExecuteNonQuery(queries2);
                            if (i == 0)
                            {
                                MessageBox.Show("Cap nhat mat khau that bai vui long thu lai!");
                            }
                            else
                            {
                                MessageBox.Show("Cap nhat thanh cong!");
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mat khau cu khong dung!");
                        }
                    }
                }
                cnn.disconnect();
            }
        }
    }
}
