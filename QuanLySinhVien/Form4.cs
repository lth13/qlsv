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
            var query ="SELECT * FROM PhongBan WHERE TenPhongBan = '"+comboBox1.Text+"'";
            using (SqlDataReader SqlRead = cnn.getDataReader(query))
            {
                while (SqlRead.Read())
                {
                    txbID.Text = SqlRead["ID"].ToString();
                    int id = Convert.ToInt32(SqlRead["IDLeader"].ToString());
                    var query2 = "SELECT * FROM ThongTin WHERE ID = " + id + "";
                    using (SqlDataReader SqlRead2 = cnn.getDataReader(query2))
                    {
                        while (SqlRead2.Read())
                        {
                            txbQuanLy.Text = SqlRead2["HoTen"].ToString();
                        }
                    }
                }
            }
        }
    }
}
