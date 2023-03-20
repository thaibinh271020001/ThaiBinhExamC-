using System;

namespace Mau8._1
{
    class Program
    {
        static void Main(string[] args)
        {
             GenericList<string> students = new GenericList<string>(10);

            students.Add("Thinh");
            students.Add("Dung");
            students.Add("Hai");

            Console.WriteLine("Noi dung collection");
            students.Display();

            students.Remove("Dung");
            students.Display();
        }
    }
}
