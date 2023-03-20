using System;
using Store;


namespace Mau5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Supply.Manufacturer dealer = new Supply.Manufacturer();

            dealer.Name = "Coca cola";
            dealer.Email = "cocacolap@gmail.com";
            dealer.Name = "(111)791-8074";

            Console.WriteLine("Deadler information");
            Console.WriteLine("\t Name: "+dealer.Name);
            Console.WriteLine("\t Email: "+dealer.Email);
            Console.WriteLine("\t Phone: "+dealer.Phone);

            StoreItem si = new StoreItem();

            si.ItemNo = 613508;
            si.ItemName = "Fanta";
            si.Price = 80.00M;

            Console.WriteLine("Store Inventory");
            Console.WriteLine("\t Item #: " + si.ItemNo);
            Console.WriteLine("\t Item name: " + si.ItemName);
            Console.WriteLine("\t Unit Price: " + si.Price);
        }
    }
}
