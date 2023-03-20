using System;
using System.Collections;
using System.Collections.Generic;
namespace Mau7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>()
            {
                new Student{Id="S10", FisrtName = "Nguyen Thai", LastName = "Ha", Avg = 9.4, Gender = true },
                new Student{Id="S11", FisrtName = "Nguyen Manh", LastName = "Thang", Avg = 6.4, Gender = true },
                new Student{Id="S12", FisrtName = "Nguyen Khac", LastName = "Long", Avg = 3.4, Gender = true },
                new Student{Id="S13", FisrtName = "Doan Duc", LastName = "Manh", Avg = 9, Gender = true },
                new Student{Id="S14", FisrtName = "Luong Manh", LastName = "Bang", Avg = 8, Gender = false },
                new Student{Id="S15", FisrtName = "Bang Thi", LastName = "Cuc", Avg = 6.4, Gender = false },
                new Student{Id="S16", FisrtName = "Dang Thai", LastName = "Binh`", Avg = 8.4, Gender = true },
                new Student{Id="S16", FisrtName = "Ha Manh", LastName = "Khai", Avg = 8.7, Gender = true }
            };

            Console.WriteLine("Danh sach sinh vien");
            foreach (var st in list)
            {
                Console.WriteLine(st);
            }

            double max = list[0].Avg;
            Student stmax = list[0];

            foreach(var st in list)
            {
                if(max < st.Avg)
                {
                    max = st.Avg;
                    stmax = st;
                }
            }

            Console.WriteLine("Sinh vien co diem cao nhat");
            Console.WriteLine(stmax);

            list.Sort();
            Console.WriteLine("\nDanh sach sinh vien co diem trung binh tang dan: ");
            foreach(var st in list)
            {
                Console.WriteLine(st);
            }
        }
    }
}
