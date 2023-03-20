using System;
using System.Collections.Generic;
using System.Text;

namespace TuLam4._2
{
    class NhanVienBanHang:NhanVien
    {
        public int Soluongbanduoc;

        public NhanVienBanHang(string name, string addres,int Soluongbanduoc) : base(name, addres)
        {
            this.Soluongbanduoc = Soluongbanduoc;
        }

       
        public override double TinhLuong()
        {
            return Soluongbanduoc * 100000;
        }
        public override void Display()
        {
            Console.WriteLine("Name "+ name);
            Console.WriteLine("Address "+ addres);
            Console.WriteLine("Luong "+ TinhLuong());
        }
    }
}
