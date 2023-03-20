using System;

namespace Bai5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thong tin sinh vien");

            Student st = new Student(3, 2);

            st[0] = "Binh";
            st[0, 0] = 9;
            st[0, 1] = 10;

            st[1] = "Long";
            st[1, 0] = 10;
            st[1, 1] = 8;

            st[2] = "Truong";
            st[2, 0] = 9;
            st[2, 1] = 8;

            for(int i = 0; i < 3; i++)
            {
                Console.Write("Ho va ten: ");
                Console.WriteLine(st[i]);
                Console.Write("Diem: ");
                for(int j = 0; j < 2; j++)
                {
                    
                    Console.Write("  " + st[i,j]);
                }

                Console.WriteLine();
            }
        }
    }
}
