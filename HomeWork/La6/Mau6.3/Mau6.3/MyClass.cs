using System;
using System.Collections.Generic;
using System.Text;

namespace Mau6._3
{
    delegate void FunctionToCall();
    class MyClass
    {
        public void nonStaticMethod()
        {
            Console.WriteLine("Non static method");
        }

        public static void staticMethod()
        {
            Console.WriteLine("Static Method");
        }
    }
}
