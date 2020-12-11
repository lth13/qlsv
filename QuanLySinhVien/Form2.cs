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

        public Form2()
        {
            InitializeComponent();
        }

        public void unlockFunction(int c) {
            if (c == 0)
            {
                đăngNhậpToolStripMenuItem.Enabled = false;
                PbanToolStripMenuItem.Enabled = true;
                nvienToolStripMenuItem.Enabled = true;
                cviecToolStripMenuItem1.Enabled = true;
                tạoThôngBáoToolStripMenuItem.Enabled = true;
                đăngXuâtToolStripMenuItem.Enabled = true;
            }
            if(c == 1)
            {
                đăngNhậpToolStripMenuItem.Enabled = false;
                nvienToolStripMenuItem.Enabled = true;
                cviecToolStripMenuItem1.Enabled = true;
                tạoThôngBáoToolStripMenuItem.Enabled = true;
                đăngXuâtToolStripMenuItem.Enabled = true;

            }
            if (c == 2)
            {
                đăngNhậpToolStripMenuItem.Enabled = false;
                cviecToolStripMenuItem1.Enabled = true;
                đăngXuâtToolStripMenuItem.Enabled = true;
            }
        }
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void đăngXuâtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            đăngNhậpToolStripMenuItem.Enabled = true;
            PbanToolStripMenuItem.Enabled = false;
            nvienToolStripMenuItem.Enabled = false;
            cviecToolStripMenuItem1.Enabled = false;
            tạoThôngBáoToolStripMenuItem.Enabled = false;
            đăngXuâtToolStripMenuItem.Enabled = false;
        }
    }
}
