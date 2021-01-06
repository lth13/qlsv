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
    public partial class CustomCTCV : UserControl
    {
        public CustomCTCV()
        {
            InitializeComponent();
        }
        private string title;
        [Category("Custom Props")]
        public string Title
        {
            get { return title; }
            set { title = value; lbltencv.Text = value; }
        }
        private string message;
        private string tgian;
        private string ngtao;
        [Category("Custom Props")]
        public string Message
        {
            get { return message; }
            set { message = value; lblndcv.Text = value; }
        }
        [Category("Custom Props")]

        public string Tgian
        {
            get { return tgian; }
            set { tgian = value; lbltgtao.Text = value; }
        }
        [Category("Custom Props")]
        public string Ngtao
        {
            get { return ngtao; }
            set { ngtao = value; lblngtao.Text = value; }
        }
        private string tcv;

        public string Tcv 
        {
            get { return tcv; }
            set { tcv = value; lbltcv.Text = value; }
        }

        private void lblngtao_Click(object sender, EventArgs e)
        {

        }
    }
}
