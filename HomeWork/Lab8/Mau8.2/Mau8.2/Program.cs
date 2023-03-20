using System;

namespace Mau8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gia tri lon nhat: " +MathEx.Max<int>(2,3,2,3,4,5,6,7,3,2332,4));
            Console.WriteLine("Gia tri nho nhat trong chuoi: " +MathEx.Min<string>("new york", "HN", "dawhdahuda","d"));
        }
    }
}
