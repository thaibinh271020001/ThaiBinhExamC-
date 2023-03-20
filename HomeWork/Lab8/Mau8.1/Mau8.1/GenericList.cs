using System;
using System.Collections.Generic;
using System.Text;

namespace Mau8._1
{
    class GenericList<T>
    {
        T[] data;
        int position;

        public GenericList(int n)
        {
            data = new T[n];
            position = 0;
        }

        public void Add(T item)
        {
            if (position < data.Length)
            {
                data[position] = item;
                position++;
            }
        }

        public void Remove(T item)
        {
            int index = Array.IndexOf<T>(data,item);

            if(index < position && index > 0)
            {
                for(int i=index; i < position - 1; i++)
                {
                    data[i] = data[i + 1];
                }
                position--;
            }
            else
            {
                Console.WriteLine("\'" + item + "\' not found");
            }
        }

        public void Display()
        {
            for(int i = 0; i < position; i++)
            {
                Console.WriteLine(data[i]);
            }  
        }
    }
}
