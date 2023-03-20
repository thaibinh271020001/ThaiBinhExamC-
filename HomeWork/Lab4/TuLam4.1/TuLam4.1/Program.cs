using System;

namespace TuLam4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account ac = new Account(200000);
            SaveingAccount sa = new SaveingAccount(200000, 5);
            CheckAccount ca = new CheckAccount(200000,1000);
            double balance = ca.initialize;
            int money1, money2;

            Console.Write("Nhap vao tien can gui: ");
            money1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao tien rut: ");
            money2 = Convert.ToInt32(Console.ReadLine());

            ca.Deposit(money1,ref balance);
            ca.WithDraw(money2,ref balance);
            ca.GetBalance(balance);
        }
    }
}
