using System;

namespace Bai5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book("This is a program C# indexer", 4);

            b[0] = new Chapters("Chapter 1", "Introduction to C#");
            b[1] = new Chapters("Chapter 2", "Datatype and Variables in C#");
            b[2] = new Chapters("Chapter 3", "Input and Output in Console");
            b[3] = new Chapters("Chapter 4", "Statements condition and loops");

            Console.WriteLine("List of book");
            Console.WriteLine(b.Name);

            for(int i=0; i<4; i++)
            {
                Console.WriteLine(b[i]);
            }
        }
    }
}
