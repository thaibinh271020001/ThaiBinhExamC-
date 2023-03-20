using System;
using System.Collections.Generic;
using System.Text;

namespace Mau4._1
{
    class Window
    {
        protected int top;
        protected int left;

        public Window(int top, int left)
        {
            this.top = top;
            this.left = left;
        }

        public virtual void DrawWindow()
        {
            Console.WriteLine("Window top: {0}, left: {1} ", top,left);
        }
    }
}
