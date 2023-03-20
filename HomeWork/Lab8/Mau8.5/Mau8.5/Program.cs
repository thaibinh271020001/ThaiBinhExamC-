using System;

namespace Mau8._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Department dep = new Department();
            foreach(string item in dep)
            {
                Console.WriteLine(item);
            }

            Flower f = new Flower();
            foreach(string item in f.GetFlower())
            {
                Console.WriteLine(item);
            }
        }
    }
}
