using System;

namespace Bai5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product pr = new Product();
            pr.Id = 1;
            pr.Name = "Binh";
            pr.Price = 20000;
            pr.Quantity = 3;
            pr.Discount = 5000;

            Console.WriteLine("Id: " + pr.Id);
            Console.WriteLine("Name: " + pr.Name);
            Console.WriteLine("Price: " + pr.Price);
            Console.WriteLine("Quantity: " + pr.Quantity);
            Console.WriteLine("Total: " + pr.Total);

            Product pr1 = new Product() { Id = 2, Name = "Long", Price = 30000, Quantity = 2, Discount = 5000 };
            
            Console.WriteLine("Id: " + pr1.Id);
            Console.WriteLine("Name: " + pr1.Name);
            Console.WriteLine("Price: " + pr1.Price);
            Console.WriteLine("Quantity: " + pr1.Quantity);
            Console.WriteLine("Total: " + pr1.Total);
        }
    }
}
