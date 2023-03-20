
using System;

namespace TuLam6._4
{
    delegate void FuntionToCall(ref int x);
    class Program
    {
        public static void Add2(ref int x)
        {
            x += 2;
        } 
        public static void Add3(ref int x)
        {
            x += 3;
        } 
        static void Main(string[] args)
        {
            FuntionToCall funtionDelegate = Add2;

            funtionDelegate += Add3;
            funtionDelegate += Add2;

            int x = 5;

            funtionDelegate(ref x);

            Console.WriteLine("value: {0}", x);
        }
    }
}
