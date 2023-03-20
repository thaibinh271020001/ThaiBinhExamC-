

using System;

namespace TuLam4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhan vien: ");

            CongNhan cn1 = new CongNhan("Binh", "hda", 2);
            cn1.Display();

            NhanVienBanHang nvbh1 = new NhanVienBanHang("Long", "hta", 4);
            nvbh1.Display();


        }
    }
}
