using System;
using System.Collections.Generic;
using System.Text;

namespace TuLam6._5
{
    public delegate void EmDelegate();

    class Company
    {
        List<Employee> listEm = new List<Employee>();

        public event EmDelegate ErrorInput;
        public event EmDelegate Success;

        public void Input(int n)
        {
            for(int i=1; i <= n; i++)
            {
                Employee em = new Employee();
                Console.WriteLine("Nhap cong nhan thu {0}:",i+1);
                Console.WriteLine("Nhao vao id: ");
                em.EmpNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhao vao ten: ");
                em.Name = Console.ReadLine();
                Console.WriteLine("Nhao vao email: ");
                em.Email = Console.ReadLine();
                Console.WriteLine("Nhao vao sdt: ");
                em.Phone = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                bool a = listEm.Contains(em);

                if (a == true)
                {
                    ErrorInput();
                }
                else
                {
                    Success();
                }
                listEm.Add(em);

            }
        }

        /*public void Display()
        {
            foreach(var ele in listEm)
            {
                Console.WriteLine(ele.EmpNo + "\t Name: " + ele.Name + "\t Email: "+ ele.Email + "\t Phone: "+ele.Phone);
            }
        }*/

        public void Error()
        {
            Console.WriteLine("Error");
        }
        public void Succes()
        {
            Console.WriteLine("Succes");
        }
    }
}
