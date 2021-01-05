using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class Nvien
    {
        private String HoTen, NgaySinh, GioiTinh, QueQuan,DiaChi, Email, ChucVu;
        private int ID, SoDienThoai;
        public int gsID
        {
            get { return ID; }
            set { ID = value; }
        }
        public int gsSoDienThoai
        {
            get { return SoDienThoai; }
            set { SoDienThoai = value; }
        }
        public string gsHoTen
        {
            get { return HoTen; }
            set { HoTen = value; }
        }
        public string gsNgaySinh
        {
            get { return NgaySinh; }
            set { NgaySinh = value; }
        }
        public string gsGioiTinh
        {
            get { return GioiTinh; }
            set { GioiTinh = value; }
        }
        public string gsQueQuan
        {
            get { return QueQuan; }
            set { QueQuan = value; }
        }
        public string gsDiaChi
        {
            get { return DiaChi; }
            set { DiaChi = value; }
        }
        public string gsEmail
        {
            get { return Email; }
            set { Email = value; }
        }
        public string gsChucVu
        {
            get { return ChucVu; }
            set { ChucVu = value; }
        }
    }
}
