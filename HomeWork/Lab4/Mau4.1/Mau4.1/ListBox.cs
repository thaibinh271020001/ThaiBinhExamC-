using System;
using System.Collections.Generic;
using System.Text;

namespace Mau4._1
{
    class ListBox:Window
    {
        protected string content;

        public ListBox(int top, int left, string content) : base(top, left)
        {
            this.content = content;
        }

        public override void DrawWindow()
        {
            base.DrawWindow();
            Console.WriteLine("String list " + content);
        }
    }
}
