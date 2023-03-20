using System;
using System.Collections.Generic;
using System.Text;

namespace Mau4._5
{
    interface IDrivable
    {
        public void Start();
        public void Stop();
        public bool Stared
        {
            get;
        }
    }
}
