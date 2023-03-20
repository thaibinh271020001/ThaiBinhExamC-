using System;

namespace Mau4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var cc = new Circle();
            cc.InputData();

            Console.WriteLine("Dien tich la {0}", cc.Area());
            Console.WriteLine("Chu vi la {0}", cc.Circumference());

            var rt = new Rectangle();
            rt.InputData();

            Console.WriteLine("Dien tich la {0}", rt.Area());
            Console.WriteLine("Chu vi la {0}", rt.Circumference());
        }
    }
}
