using System;
using System.Collections.Generic;
using System.Text;

namespace TuLam6._4
{
    public delegate void IntAction(int a);
    class TestDelegate
    {
        public static void PrintInt(int a)
        {
            Console.WriteLine(a);
        } 
    }
}
