using System;
using System.Collections.Generic;
using System.Text;

namespace TuLam5._2
{
    class Employee
    {
        public int id;
        public string name;
        public int age;

        public Employee()
        {
            id = 0;
            name = "";
            age = 0;
        }
        public Employee(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;

        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public override string ToString()
        {
            return id + name + age;
        }
    }
}
