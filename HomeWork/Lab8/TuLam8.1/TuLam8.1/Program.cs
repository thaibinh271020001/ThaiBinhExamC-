using System;

namespace TuLam8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Test<int> ts = new Test<int>(5);

            ts.Add(1);
            ts.Add(2);
            ts.Add(3);
            ts.Add(4);
            ts.Add(5);

            ts.Display();
        }
    }
}
