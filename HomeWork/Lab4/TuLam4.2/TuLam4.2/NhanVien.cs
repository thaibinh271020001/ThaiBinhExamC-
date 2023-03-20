using System;
using System.Collections.Generic;
using System.Text;

namespace TuLam4._2
{
    abstract class NhanVien
    {
        public string name;
        public string addres;

        public NhanVien(string name, string addres)
        {
            this.name = name;
            this.addres = addres;
        }

        public abstract double TinhLuong();
        public abstract void Display();
    }
}
