using System;
using System.Collections.Generic;
using System.Text;

namespace Mau4._3
{
    class Rectangle:Shape
    {
        public void InputData()
        {
            Console.WriteLine("Nhap vao chieu dai");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap vao chieu rong");
            width = Convert.ToDouble(Console.ReadLine());
        }

        public override double Area()
        {
            return length * width;
        }
        public override double Circumference()
        {
            return (length + width) * 2;
        }
    }
}
