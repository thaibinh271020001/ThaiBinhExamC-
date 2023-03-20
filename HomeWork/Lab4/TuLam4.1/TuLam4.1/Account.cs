using System;
using System.Collections.Generic;
using System.Text;

namespace TuLam4._1
{
    class Account
    {
        public double initialize;
        public Account(double initialize)
        {
            this.initialize = initialize;
        }

        public virtual void Deposit(int money1,ref double balance)
        {

            Console.WriteLine("Day la nap tien");
        }
        public virtual void WithDraw(int money2,ref double balance)
        {

            Console.WriteLine("Day la rut tien");
        }
        public virtual void GetBalance(double balance)
        {
            Console.WriteLine("Day la kiem tra so tien");
        }
        
        
    }
}
