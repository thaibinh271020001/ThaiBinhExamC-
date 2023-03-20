using System;
using System.Collections.Generic;
using System.Text;

namespace TuLam8._1
{
    class Test<T>
    {
        T[] test;
        int position = 0;

        public Test(int item)
        {
            test = new T[item];
        }

        public void Add(T item)
        {
            if(position < test.Length)
            {
                test[position] = item;
                position++;
            }
        }

        public void Display()
        {
            foreach(T ts in test)
            {
                Console.WriteLine(ts);
            }
        }
    }
}
