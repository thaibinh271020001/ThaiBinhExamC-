using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Exam2
{
    class Student : IStudent
    {
        List<Student> listStudent = new List<Student>();
        Hashtable newHash = new Hashtable();
        public int StudID { get; set; }
        public string StudName { get; set; }
        public string StudGender { get; set; }
        public int StudAge { get; set; }
        public string StudClass { get; set; }
        public float StudAvgMark { get; set; }

        public override string ToString()
        {
            return "Id: " + StudID + "\tName: " + StudName + "\tGender: " + StudGender + "\tAge: " + StudAge + "\tClass: " + StudClass + "\tStudAvgMark: " + StudAvgMark;
        }
        int[] MarkList = new int[3];

        public int this[int index]
        {
            get
            {
                return MarkList[index];
            }
            set
            {
                if (index < 0 || index > MarkList.Length - 1)
                    throw new ArgumentOutOfRangeException();
                MarkList[index] = value;
            }
        }

        public double CalAvg()
        {
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                sum += MarkList[i];
            }
            StudAvgMark = sum;
            return StudAvgMark;
        }

        public void Input()
        {
            Console.WriteLine("1.Insert new student");
            Student st = new Student();

            Console.Write("Input student ID\t:");
            st.StudID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input student name\t:");
            st.StudName = Console.ReadLine();
            Console.Write("Input student gender\t:");
            st.StudGender = Console.ReadLine();
            Console.Write("Input student age\t:");
            st.StudAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input student class\t:");
            st.StudClass = Console.ReadLine();
            Console.WriteLine("Input student mark:");
            Console.Write("\tInput mark 1: ");
            st[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("\tInput mark 2: ");
            st[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("\tInput mark : ");
            st[2] = Convert.ToInt32(Console.ReadLine());
            Console.Write(st[2]);


            newHash.Add(st.StudID, st.StudName);

            listStudent.Add(st);
        }

        public void DisplayAll()
        {
            foreach (DictionaryEntry fw in newHash)
            {
                    Console.WriteLine("Key: " + fw.Key + "   Values: " + fw.Value);

                
            }
            foreach (var i in listStudent)
            {
                Console.WriteLine(i);
            }
        }

        public void Calculator()
        {

        }

        public void FindById()
        {
            Console.Write("Nhap vao id muon tim sinh vien: ");
            int FindById = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < listStudent.Count; i++)
            {
                Student st = listStudent[i];
                if (st.StudID == FindById)
                {
                    Console.WriteLine(st);
                }
            }
        }

        public void FindByName()
        {
            Console.Write("Nhap vao ten muon tim sinh vien: ");
            string FindByName = Console.ReadLine();

            for (int i = 0; i < listStudent.Count; i++)
            {
                Student st = listStudent[i];
                if (st.StudName == FindByName)
                {
                    Console.WriteLine(st);
                }
            }
        }

        public void FindByClass()
        {
            Console.Write("Nhap vao class muon tim sinh vien: ");
            string FindByClass = Console.ReadLine();

            for (int i = 0; i < listStudent.Count; i++)
            {
                Student st = listStudent[i];
                if (st.StudClass == FindByClass)
                {
                    Console.WriteLine(st);
                }
            }
        }
    }
}
