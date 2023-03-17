using System;
using System.Collections.Generic;
using System.Collections;

namespace Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student oo = new Student();

            do
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("========================================");
                Console.WriteLine("1.Insert new student");
                Console.WriteLine("2.Display all the student list");
                Console.WriteLine("3.Calculator average mark");
                Console.WriteLine("4.Find by id,name,class");
                Console.WriteLine("5.exit");
                Console.WriteLine("========================================");
                Console.Write("Option: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        oo.Input();
                        break;

                    case 2:
                        oo.DisplayAll();
                        break;
                    case 3:
                        break;
                    case 4:
                        Console.WriteLine("Nhap vao lua chon: ");
                        Console.WriteLine("1.Tim bang id:");
                        Console.WriteLine("2.Tim bang name:");
                        Console.WriteLine("3.Tim bang class:");
                        int chon = Convert.ToInt32(Console.ReadLine());

                        switch (chon)
                        {
                            case 1:
                                oo.FindById();
                                break;
                            case 2:
                                oo.FindByName();
                                break;
                            case 3:
                                oo.FindByClass();
                                break;
                        }
                        break;
                }

                if (choice == 5)
                {
                    break;
                }
            } while (true);
        }
    }
}
