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
    }
}
