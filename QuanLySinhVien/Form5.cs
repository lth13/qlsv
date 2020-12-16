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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            
            if (System.Windows.Forms.Application.OpenForms["Form3"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["Form3"] as Form2).unlockFunction(c);
            }
            frm3.Show();
        }
}
