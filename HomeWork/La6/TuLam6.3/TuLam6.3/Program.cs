using System;

namespace TuLam6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Lecture tt = new Lecture();

            
            int a = 0;
            do
            {
                try
                {
                    Console.WriteLine("Nhap vao luong giang vien: ");
                    tt.Salary = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Nhap vao tien thuong: ");
                    tt.Bonus = Convert.ToDouble(Console.ReadLine());
                    if (tt.Salary < 60000 || tt.Bonus < 0 || tt.Bonus > 10000)
                    {
                        throw new AmountException();
                    }
                    else
                    {
                        a++;
                    }

                }
                catch (AmountException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }while(a==0);
        }
    }
}
