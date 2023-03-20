using System;

namespace Mau5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Business.House h = new Business.House();

            h.HoseNo = "D294FF";
            h.Price = 425880;

            Console.WriteLine("House detail");
            Console.WriteLine("\t House No: "+h.HoseNo);
            Console.WriteLine("\t Price: "+h.Price);

            Business.Delership.Car C = new Business.Delership.Car();

            C.CarNo = "A0999";
            C.Price = 38425.50M;
        
            Console.WriteLine("Car detail");
            Console.WriteLine("\t House No: "+C.CarNo);
            Console.WriteLine("\t Price: "+C.Price);
        }
    }
}
