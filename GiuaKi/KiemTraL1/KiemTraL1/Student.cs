using System;
using System.Collections.Generic;
using System.Text;

namespace KiemTraL1
{
    class Student:IComparable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Gender { get; set; }
        public int Age { get; set; }
        public int DateOfBirth { get; set; }
        public string Class { get; set; }
        public double Mark1 { get; set; }
        public double Mark2 { get; set; }
        public double Mark3 { get; set; }
        
        public double mark_AVG()
        {
            return (Mark1 + Mark2 + Mark3) / 3;
        }

        public override string ToString()
        {
            return "Id: " + Id + "  " + "Name: " + Name + "  " + "Gender: " + Gender + "  " + "Age: " + Age + 
            "  " + "DateOfBirth: " + DateOfBirth + "  " + "Class: " + Class + "  " + "Mark1: " + Mark1 + "  " + "Mark2: " + Mark2 + "  " + "Mark3: " + Mark3;
        }

        public int CompareTo(Student other)
        {
            return this.mark_AVG().CompareTo(other.mark_AVG());
        }

        

    }
}
