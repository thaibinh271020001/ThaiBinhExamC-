using System;

namespace Mau4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var w = new Window(1, 2);
            var b = new Button(3, 4);
            var l = new ListBox(4,5, "Messi");

            w.DrawWindow();
            b.DrawWindow();
            l.DrawWindow();

            Window[] winArray = new Window[3];
            winArray[0] = new Window(1, 2);
            winArray[1] = new Button(3, 4);
            winArray[2] = new ListBox(5, 6,"String");

            for(int i = 0; i < 3; i++)
            {
                winArray[i].DrawWindow();
            }
        }
    }
}
