using System;

namespace Mau4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentUniversity su = new StudentUniversity("Binh", 2001, 9, 8, 8.6, 9.4);
            su.Display();
            Console.WriteLine(su.Average());

        }
    }
}
