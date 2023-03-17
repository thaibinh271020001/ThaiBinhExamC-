using System;
using System.Collections.Generic;
using System.Text;

namespace Exam2
{
    interface IStudent
    {
        public int StudID { get; set; }
        public string StudName { get; set; }
        public string StudGender { get; set; }
        public int StudAge { get; set; }
        public string StudClass { get; set; }
        public float StudAvgMark { get; set; }

        public void Print()
        {
            Console.WriteLine("Id: " + StudID + "\tName: " + StudName + "\tGender: " + StudGender + "\tAge: " + StudAge + "\tClass: " + StudClass + "\tStudAvgMark: " + StudAvgMark);
        }


    }
}
