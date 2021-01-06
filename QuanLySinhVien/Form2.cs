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
                cáNhânToolStripMenuItem.Visible = true;
                thốngKêToolStripMenuItem.Visible = true;
            }
            if(c == 1)
            {
                đăngNhậpToolStripMenuItem.Enabled = false;
                nvienToolStripMenuItem.Enabled = true;
                cviecToolStripMenuItem1.Enabled = true;
                tạoThôngBáoToolStripMenuItem.Enabled = true;
                đăngXuâtToolStripMenuItem.Enabled = true;
                cáNhânToolStripMenuItem.Visible = true;
                thốngKêToolStripMenuItem.Visible = false;
            }
            if (c == 2)
            {
                đăngNhậpToolStripMenuItem.Enabled = false;
                cviecToolStripMenuItem1.Enabled = true;
                đăngXuâtToolStripMenuItem.Enabled = true;
                cáNhânToolStripMenuItem.Visible = true;
                thốngKêToolStripMenuItem.Visible = false;
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
            cáNhânToolStripMenuItem.Visible = false;
            FormPhongBan frm4 = new FormPhongBan();
            frm4.TopLevel = false;
            this.Controls.Add(frm4);
            frm4.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm4.Dock = DockStyle.Fill;
            frm4.BringToFront();
            frm4.Show();
        }

        private void PbanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.TopLevel = false;
            this.Controls.Add(frm4);
            frm4.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm4.Dock = DockStyle.Fill;
            frm4.BringToFront();
            frm4.Show();
        }

        private void cáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.TopLevel = false;
            this.Controls.Add(frm3);
            frm3.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm3.Dock = DockStyle.Fill;
            frm3.BringToFront();
            frm3.Show();
        }

        private void nvienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.TopLevel = false;
            this.Controls.Add(frm5);
            frm5.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm5.Dock = DockStyle.Fill;
            frm5.BringToFront();
            frm5.Show();
        }

        private void tạoThôngBáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.TopLevel = false;
            this.Controls.Add(frm7);
            frm7.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm7.Dock = DockStyle.Fill;
            frm7.BringToFront();
            frm7.Show();
        }

        private void cviecToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.TopLevel = false;
            this.Controls.Add(frm8);
            frm8.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm8.Dock = DockStyle.Fill;
            frm8.BringToFront();
            frm8.Show();
        }

        private void xemThôngBáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 frm8 = new Form11();
            frm8.TopLevel = false;
            this.Controls.Add(frm8);
            frm8.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm8.Dock = DockStyle.Fill;
            frm8.BringToFront();
            frm8.Show();

        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 frm13 = new Form13();
            frm13.TopLevel = false;
            this.Controls.Add(frm13);
            frm13.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm13.Dock = DockStyle.Fill;
            frm13.BringToFront();
            frm13.Show();
        }
    }
}
