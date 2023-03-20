using System;

namespace Mau6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass t = new MyClass();

            FunctionToCall functionDeledate = t.nonStaticMethod;

            functionDeledate += MyClass.staticMethod;
            functionDeledate += t.nonStaticMethod;
            functionDeledate += MyClass.staticMethod;

            functionDeledate();
        }


    }
}


/*Action,
predicate,func,linq,*//* -> advance*/