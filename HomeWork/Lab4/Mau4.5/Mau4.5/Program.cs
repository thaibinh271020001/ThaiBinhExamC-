using System;

namespace Mau4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            Console.WriteLine("Calling myCar.Start()");
            myCar.Start();
            Console.WriteLine("Calling myCar.TurnLeft()");
            myCar.TurnLeft();
            Console.WriteLine("Calling myCar.Accerlerate()");
            myCar.Accerlerate();
        }
    }
}
