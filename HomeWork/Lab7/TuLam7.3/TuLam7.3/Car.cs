using System;
using System.Collections.Generic;
using System.Text;

namespace TuLam7._3
{
    class Car
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return Name + "    " + Color;
        }
    }
}
