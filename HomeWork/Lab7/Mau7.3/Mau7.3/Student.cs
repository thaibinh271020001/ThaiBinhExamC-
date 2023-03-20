using System;
using System.Collections.Generic;
using System.Text;

namespace Mau7._3
{
    class Student:IComparable<Student>
    {
        public string Id{get; set;}
        public string FisrtName{get; set;}
        public string LastName{get; set;}
        public bool Gender{get; set;}
        public double Avg{get; set;}

        public override string ToString()
        {
            return "Id: " + Id + "   " + "Fisrtname: " + FisrtName + "   " + "LastName: " + LastName + "   " + "Gender: " + Gender + "   " + "Avg: " + Avg + "   ";
        }

        public int CompareTo(Student other)
        {
            return this.Avg.CompareTo(other.Avg);
        }
    }
}
