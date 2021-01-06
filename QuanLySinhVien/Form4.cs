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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txbID_TextChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            Connection cnn = new Connection();
            cnn.connect();
            int id=0;
            if(comboBox1.Text=="Phòng kế toán")
            {
                id=1;
            }
            if (comboBox1.Text == "Phòng sale")
            {
                id=2;
            }
            if (comboBox1.Text == "Phòng kỹ thuật")
            {
                id=3;
            }
            var query = "SELECT * FROM PhongBan WHERE ID = "+id+"";
            using (SqlDataReader SqlRead = cnn.getDataReader(query))
            {
                while (SqlRead.Read())
                {
                    txbID.Text = SqlRead["ID"].ToString();
                    int id2 = Convert.ToInt32(SqlRead["IDLeader"].ToString());
                    txbMoTa.Text = SqlRead["MoTa"].ToString();
                    var queries2 = "SELECT * FROM ThongTin WHERE ID = " + id2 + "";
                    using (SqlDataReader SqlRead2 = cnn.getDataReader(queries2))
                    {
                        while (SqlRead2.Read())
                        {
                            txbQuanLy.Text = SqlRead2["HoTen"].ToString();
                        }
                    }
                }
            }
            cnn.disconnect();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            txbQuanLy.Enabled = true;
            txbMoTa.Enabled = true;
            btnChinhSua.Visible = false;
            btnLuu.Visible = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Connection cnn = new Connection();
            String b = txbQuanLy.Text;
            int idtkmoi=0;
            SqlCommand cmd = new SqlCommand("SELECT UserID FROM ThongTin WHERE HoTen = @a");
            cmd.Parameters.AddWithValue("@a", b);
            cnn.connect();
            using (SqlDataReader SqlRead = cnn.getDataReader(cmd))
            {
                while (SqlRead.Read())
                {
                    idtkmoi = Convert.ToInt32(SqlRead["UserID"].ToString());
                }
            }
            cnn.disconnect();
            cnn.connect();
            int iddd=0;
            if (comboBox1.Text == "Phòng kế toán")
            {
                iddd = 1;
            }
            if (comboBox1.Text == "Phòng sale")
            {
                iddd = 2;
            }
            if (comboBox1.Text == "Phòng kỹ thuật")
            {
                iddd = 3;
            }
            SqlCommand command = new SqlCommand("UPDATE PhongBan SET MoTa=@b,IDLeader=@c WHERE ID=@d");
            command.Parameters.AddWithValue("@b", txbMoTa.Text);
            command.Parameters.AddWithValue("@c", idtkmoi);
            command.Parameters.AddWithValue("@d", iddd);
            int i = cnn.ExecuteNonQuery(command);
            if (i == 0)
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
