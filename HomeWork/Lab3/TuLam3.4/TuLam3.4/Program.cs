using System;

namespace TuLam3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chuong trinh lop employ");

            Employee em = new Employee();

            em.Id = 1;
            em.Name = "Binh";
            em.YearOfBirth = 2001;
            em.SalaryLevel = 2.5;
            em.BasicSalary = 10000000.5;

            em.Display();
        }
    }
}
