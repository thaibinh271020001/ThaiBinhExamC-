using System;
using System.Collections.Generic;
using System.Text;

namespace Mau4._1
{
    class Button:Window
    {
        public Button(int top, int left) : base(top, left)
        {

        }

        public override void DrawWindow()
        {
            Console.WriteLine("Button: {0}, and {1} ", top, left);
        }
    }
}
