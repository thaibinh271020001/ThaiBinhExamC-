using System;
using System.Collections.Generic;
using System.Text;

namespace Mau4._2
{
    abstract class Student
    {
        protected string name;
        protected int year;

        public Student(string name, int year)
        {
            this.name = name;
            this.year = year;
        }

        public void Display()
        {
            Console.WriteLine("Your name: {0}", name);
            Console.WriteLine("Your year born: {0}", year);
        }

        public abstract double Average();
    }
}
