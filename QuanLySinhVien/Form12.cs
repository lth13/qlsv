using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            Form12 frm12 = new Form12();
            frm12.TopLevel = false;
            this.Controls.Add(frm12);
            frm12.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm12.Dock = DockStyle.Fill;
            frm12.BringToFront();
            frm12.Show();
        }
    }
}
