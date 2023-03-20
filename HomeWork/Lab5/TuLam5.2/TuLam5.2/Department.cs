using System;
using System.Collections.Generic;
using System.Text;

namespace TuLam5._2
{
    class Department
    {
        private string name;
        private Employee[] employees;

        public Department()
        {

        }
        public Department(string name, int n)
        {
            this.name = name;
            employees = new Employee[n];
        }

        public string Name
        {
            get { return name; }
            set
            {
                if(value == null)
                {
                    throw new ArgumentNullException();
                }
                name = value;

            }
        }

        public Employee this[int index]
        {
            get
            {
                if(index < 0 || index > employees.Length - 1)
                    return null;
                return employees[index];
            }

            set
            {
                if(index < 0 || index > employees.Length - 1)
                    throw new ArgumentException();
                employees[index] = value;
            }
        }

        public Employee this[string name]
        {
            get
            {
                foreach(Employee ch in employees)
                {
                    if(ch.Name == name)
                    {
                        return ch;
                    }
                }
                return null;
            }
        }
    }
}
