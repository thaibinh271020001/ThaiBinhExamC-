﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mau4._4
{
    class Student : IPerson
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public void Delete(object obj)
        {
            Console.WriteLine("Da xoa doi tuong: " + obj);
        }

        public void Display(object obj)
        {
            Student st = (Student)obj;
            Console.WriteLine("Id: "+st.Id);
            Console.WriteLine("Name: "+st.Name);
            Console.WriteLine("Age: " + st.Age);

        }

        public void Insert(object obj)
        {
            Console.WriteLine("Da Luu doi tuong: " + obj);
        }

        public void Update(object obj)
        {
            Console.WriteLine("Da Cap nhat doi tuong: " + obj);
        }
    }
}
