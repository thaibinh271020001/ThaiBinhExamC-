using System;

namespace Mau10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> sumNumber = Calculator.Add;

            Func<string, string, string> joinString = Calculator.Join;

            Console.WriteLine(sumNumber(10,30));
            Console.WriteLine(joinString("Ha noi", "-Viet Nam"));
        }
    }
}
