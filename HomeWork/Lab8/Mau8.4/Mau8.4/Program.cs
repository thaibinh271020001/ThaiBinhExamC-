using System;

namespace Mau8._4
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorInt cal = new CalculatorInt();

            int a = 10, b = 5;

            Console.WriteLine("{0} + {1} = {2}", a,b,cal.Add(a,b));
            Console.WriteLine("{0} - {1} = {2}", a,b,cal.Sub(a,b));
            Console.WriteLine("{0} * {1} = {2}", a,b,cal.Mul(a,b));
            Console.WriteLine("{0} / {1} = {2}", a,b,cal.Div(a,b));
        }
    }
}
