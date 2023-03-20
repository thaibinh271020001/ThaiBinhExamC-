using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Mau7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList inv = new ArrayList();

            inv.Add(new Product("A", 7.8, 3));
            inv.Add(new Product("B", 6.8, 1));
            inv.Add(new Product("C", 8.2, 4));
            inv.Add(new Product("D", 7.2, 2));

            Console.WriteLine("Product list");
            foreach(var i in inv)
            {
                Console.WriteLine(i);
            }
        }
    }
}
