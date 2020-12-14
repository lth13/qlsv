using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class User
    {
        private static string cnn;
        private static string username;
        private static int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Cnn
        {
            get { return cnn; }
            set { cnn = value; }
        }
    }
}
