using System;
using System.Collections.Generic;
using System.Text;

namespace Bai5._2
{
    class Student
    {
        string[] names;
        double[,] marks;

        public Student(int n, int m)
        {
            names = new string[n];
            marks = new double[n,m];
        }

        public string this[int i]
        {
            get { return names[i]; }
            set { names[i] = value; }
        }

        public double this[int i,int j]
        {
            get { return marks[i,j]; }
            set { marks[i,j] = value; }
        }
    }
}
