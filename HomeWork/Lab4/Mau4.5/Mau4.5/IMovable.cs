using System;
using System.Collections.Generic;
using System.Text;

namespace Mau4._5
{
    interface IMovable:ISteerable,IDrivable
    {
        public void Accerlerate();
        public void Brake();
    }
}
