using System;
using System.Collections.Generic;
using System.Text;

namespace Mau7._1
{
    class Product
    {
        public string name;
        public double cost;
        public int onhand;

        public Product(string n, double c, int h)
        {
            this.name = n;
            this.cost = c;
            this.onhand = h;
        }
        public override string ToString()
        {
            return String.Format("{0,-25}Cost: {1,6:C} On hand: {2}", name, cost, onhand);
        }
    }
}
