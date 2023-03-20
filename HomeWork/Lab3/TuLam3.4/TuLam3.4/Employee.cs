using System;
using System.Collections.Generic;
using System.Text;

namespace TuLam3._4
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int YearOfBirth { get; set; }
        public double SalaryLevel { get; set; }
        public double BasicSalary { get; set; }

        public double GetIncome()
        {
            return SalaryLevel * BasicSalary;
        }

        public void Display()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("YearOfBirth: " + YearOfBirth);
            Console.WriteLine("BasicSalary: " + BasicSalary);
            Console.WriteLine(GetIncome());
        }
    }
}
