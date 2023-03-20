using System;
using System.Collections.Generic;
using System.Text;

namespace TuLam4._2
{
    class CongNhan : NhanVien
    {
        public int Soluongsanpham;

        public CongNhan(string name, string addres, int Soluongsanpham) : base(name, addres)
        {
            this.Soluongsanpham = Soluongsanpham;
        }


        public override double TinhLuong()
        {
            return Soluongsanpham * 150000;
        }
        public override void Display()
        {
            Console.WriteLine("Name " + name);
            Console.WriteLine("Address " + addres);
            Console.WriteLine("Luong " + TinhLuong());
        }
    }
}
