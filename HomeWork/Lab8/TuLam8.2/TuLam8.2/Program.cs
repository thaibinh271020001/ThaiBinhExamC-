using System;
using System.Collections;
using System.Collections.Generic;

namespace TuLam8._2
{
    class Program
    {
        static void Main(string[] args)
        {

            void Swap<T>(T a,T b)
            {
                Console.WriteLine("Truoc khi hoan vi");
                Console.WriteLine("a = {0} , b = {1}", a, b);

                T tg = a;
                a = b;
                b = tg;

                Console.WriteLine("Sau khi hoan vi");
                Console.WriteLine("a = {0} , b = {1}", a,b);
            }

            Swap<int>(6,5);
        }

        
    }
}
