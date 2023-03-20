using System;
using System.Collections.Generic;
using System.Text;

namespace Mau10._3
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }
        public string City { get; set; }
        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}", EmpId, EmpName, Salary,City);
        }
    }
}
