using System;
using System.Collections;
using System.Collections.Generic;

namespace Mau10._3
{
    class Program
    {
        public delegate bool EmpDelegate(Employee emp);
        static void Main(string[] args)
        {
            // phần khởi tạo dữ liệu
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee
            {
                EmpId = 1,
                EmpName = "Hoa",
                Salary =
            10000,
                City = "Hanoi"
            });
            employees.Add(new Employee
            {
                EmpId = 2,
                EmpName = "Cuong",
                Salary =
            20000,
                City = "Hanam"
            });
            employees.Add(new Employee
            {
                EmpId = 3,
                EmpName = "Hieu",
                Salary =
            30000,
                City = "Hanoi"
            });
            Console.WriteLine("Loc theo City:");
            foreach (Employee emp in Filter(employees, emp => emp.City ==
            "Hanoi"))
            {
                Console.WriteLine(emp.ToString());
            }
            Console.WriteLine("\nLoc theo Salary:");
            foreach (Employee emp in Filter(employees, emp => emp.Salary >=
            20000))
            {
                Console.WriteLine(emp.ToString());
            }
        }
        public static IEnumerable<Employee> Filter(IEnumerable<Employee>
        employees, EmpDelegate check)
        {
            foreach (Employee emp in employees)
            {
                if (check(emp) == true)
                    yield return emp;
            }
        }

    }
}
