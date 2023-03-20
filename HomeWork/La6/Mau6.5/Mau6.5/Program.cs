using System;

namespace Mau6._5
{
    class Program
    {
        static void Main(string[] args)
        {
            TestOdd objOdd = new TestOdd();

            objOdd.OnOddNumber += new OddNumberFinder(objOdd.ShowOdd);//tao even 

            objOdd.CountOdd();
        }
    }
}
