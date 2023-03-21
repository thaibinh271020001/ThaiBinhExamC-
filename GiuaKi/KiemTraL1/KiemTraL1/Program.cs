using System;

namespace KiemTraL1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            TestStudent ts = new TestStudent();
            int choice;
            do
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("=============================================");
                Console.WriteLine("1.Input information");
                Console.WriteLine("2.Display all student");
                Console.WriteLine("3.Sorting student asccending by average mark"); 
                Console.WriteLine("4.Search Student by Name");
                Console.WriteLine("5.Delete Student by student ID.");
                Console.WriteLine("6.Exit program.");
                Console.WriteLine("==============================================");
                Console.Write("Option: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ts.Input();
                        break;
                    case 2:
                        ts.Displayall();
                        break;
                    case 3:
                        ts.Sort();
                        break;
                    case 4:
                        ts.FindByName();
                        break;
                    case 5:
                        ts.RemovebyID();
                        break;
                }

                if (choice == 6)
                {
                    break;
                }
            } while (true);

        }
    }
}
