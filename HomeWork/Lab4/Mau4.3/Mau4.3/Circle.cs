using System;
using System.Collections.Generic;
using System.Text;

namespace Mau4._3
{
    class Circle:Shape
    {
        public void InputData()
        {
            Console.WriteLine("Nhap vao ban kinh");
            radius = Convert.ToDouble(Console.ReadLine());
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        public override double Circumference()
        {
            return Math.PI * 2 * radius;
        }
    }
}
