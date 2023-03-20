using System;
using System.Collections.Generic;
using System.Text;

namespace TuLam4._1
{
    class SaveingAccount:Account
    {
        public double rate;

        public SaveingAccount(int initialize, double rate) : base(initialize)
        {
            this.rate = rate;
        }

        public double GetInterest()
        {
            return initialize * rate / 100;
        }
    }
}
