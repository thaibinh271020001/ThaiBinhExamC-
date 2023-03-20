using System;
using System.Collections.Generic;
using System.Text;

namespace Mau4._3
{
    abstract class Shape
    {
        public double radius;
        public double length;
        public double width;

        public abstract double Area();
        public abstract double Circumference();

    }
}
