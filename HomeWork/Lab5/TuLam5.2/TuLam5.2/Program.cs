using System;

namespace TuLam5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Department em = new Department("This is Department", 3);

            em[0] = new Employee(1, "Binh", 18);
            em[1] = new Employee(2, "Long", 18);
            em[2] = new Employee(3, "Manh", 18);

            Console.WriteLine(em.Name);
            for(int i=0 ; i<3 ; i++)
            {
                Console.WriteLine(em[i]);
            }
        }
    }
}
