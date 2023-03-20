using System;
using System.Collections;
using System.Collections.Generic;

namespace TuLam7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> car = new List<Car>()
            {
                new Car{Name = "Lamboghini", Color = "Red"},
                new Car{Name = "Volswagen", Color = "Red"},
                new Car{Name = "Audi", Color = "Blue"},
                new Car{Name = "Bugati", Color = "Red"},
                new Car{Name = "Civic", Color = "Red"},
                new Car{Name = "Toyota", Color = "Red"},
                new Car{Name = "Kawasaki", Color = "Blue"},
                new Car{Name = "Ford", Color = "Red"},
                new Car{Name = "Porche", Color = "Red"},
                new Car{Name = "BMW", Color = "Red"},
            };
            Console.WriteLine(car.Count);
            

            for(int j = 0; j < car.Count; j++)
            {
                for (int i = 0; i < car.Count; i++)
                {
                    Car cr = car[i];
                    if (cr.Color == "Red")
                    {
                        car.Remove(cr);
                    }

                }
            }

            foreach(var cr in car)
            {

                Console.WriteLine(cr);
            }
        }
    }
}
