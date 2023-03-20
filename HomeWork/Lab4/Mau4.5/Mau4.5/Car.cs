using System;
using System.Collections.Generic;
using System.Text;

namespace Mau4._5
{
    class Car : IMovable
    {
        public bool stared = false;

        public void Accerlerate()
        {
            Console.WriteLine("Car accerlerating");
        }

        public void Brake()
        {
            Console.WriteLine("Car braking");
        }

        public void Start()
        {
            Console.WriteLine("Car started");
            stared = true;
        }

        public void Stop()
        {
            Console.WriteLine("Car Stoped");
            stared = false;
        }

        public bool Stared
        {
            get
            {
                return true;
            }
        }

        public void TurnLeft()
        {
            Console.WriteLine("Car turning left");
        }

        public void TurnRight()
        {
            Console.WriteLine("Car turning right");
        }
    }
}
