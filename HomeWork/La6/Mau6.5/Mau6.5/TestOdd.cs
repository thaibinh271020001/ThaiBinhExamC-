using System;
using System.Collections.Generic;
using System.Text;

namespace Mau6._5
{
    public delegate void OddNumberFinder(int num);
    class TestOdd
    {
        public event OddNumberFinder OnOddNumber;

        public void CountOdd()
        {
            int odd=1;
            for(odd = 1; odd < 50; odd+=2)
            {
                OnOddNumber(odd);
            }
        }

        public void ShowOdd(int odd)
        {
            Console.WriteLine(odd);
            Console.WriteLine("Event fired");
        }
    }
}
