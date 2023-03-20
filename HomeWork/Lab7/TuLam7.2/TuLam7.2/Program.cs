using System;
using System.Collections;

namespace TuLam7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable dayInWeek = new Hashtable();

            dayInWeek.Add(2, "Monday");
            dayInWeek.Add(3, "Tuesday");
            dayInWeek.Add(4, "Wednesday");
            dayInWeek.Add(5, "Thursday");
            dayInWeek.Add(6, "Friday");
            dayInWeek.Add(7, "Saturday");
            dayInWeek.Add(8, "Sunday");

            while (true)
            {
                Console.Write("Nhap vao ngay muon tim: ");
                string findDay = Console.ReadLine();

                if (findDay == "Tuesday")
                {
                    foreach (DictionaryEntry fw in dayInWeek)
                    {
                        if (fw.Value == "Tuesday")
                        {
                            Console.WriteLine("Ton tai key {0} co gia tri {1}", fw.Key, fw.Value);
                        }
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Ko thay ngay Tueday hoac nhap sai vui long nhap lai!");
                }
            }

            Console.WriteLine();
            foreach(DictionaryEntry fw in dayInWeek)
            {
                Console.WriteLine(fw.Key + "   " + fw.Value);
            }
        }
    }
}
