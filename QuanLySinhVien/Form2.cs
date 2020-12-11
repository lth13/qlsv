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
    public partial class Form2 : Form
    {
        Form1 frm1 = new Form1();

        public Form2()
        {
            InitializeComponent();
            unlockFunction(frm1.c);
        }
        private void unlockFunction(int c) {
            if (c == 0)
            {

            }
        }
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
