using System;

namespace TuLam8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductEnumerable pe = new ProductEnumerable();

            foreach (string p in pe)
            {
                Console.WriteLine(p);
            }
        }
    }
}
