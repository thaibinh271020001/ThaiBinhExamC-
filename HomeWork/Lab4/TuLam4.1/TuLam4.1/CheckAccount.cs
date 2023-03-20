using System;
using System.Collections.Generic;
using System.Text;

namespace TuLam4._1
{
    class CheckAccount:Account
    {
        public double feeTransfer;
        
        public CheckAccount(int initialize, double feeTransfer) : base(initialize)
        {
            this.feeTransfer = feeTransfer;
            
        }

        public override void Deposit(int money1,ref double balance)
        {
            Console.WriteLine("So tien nap vao la: " +money1);
            Console.WriteLine("So tien hien tai: {0}", money1 + balance - feeTransfer);
            balance = money1 + balance - feeTransfer;
        }
        public override void WithDraw(int money2,ref double balance)
        {
            Console.WriteLine("So tien rut vao la: " + money2);
            Console.WriteLine("So tien hien tai: {0}", balance - money2 - feeTransfer);
            balance = balance - money2 - feeTransfer;
        }

        public override void GetBalance(double balance)
        {
            Console.WriteLine("Day la so tien hien tai: " + balance);
        }
    }
}
