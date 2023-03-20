using System;

namespace TuLam6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            IntAction inac = TestDelegate.PrintInt;
            IntAction act = TestDelegate.PrintInt;

            inac(5);
            act(42);

            int[] arr = { 1, 2, 3, 4, 5 };

            Perform(act, arr);
        }

        public static void Perform(IntAction act, int[] arr)
        {
            foreach(var element in arr)
            {
                act(element);
            }
        }
    }
}
