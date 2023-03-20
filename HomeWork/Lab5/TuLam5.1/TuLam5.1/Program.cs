using System;

namespace TuLam5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var bk = new Book();
            bk.id = 1;
            bk.price = 10000;
            bk.title = "Dac nhan tam";
            bk.publisher = "Kim dong";

            Console.WriteLine(bk);
        }
    }
}
