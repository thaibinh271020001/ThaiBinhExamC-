using System;
using System.Collections.Generic;
using System.Text;

namespace Bai5._1
{
    class Product
    {
        public int id;
        public int Id
        {
            set { id = value;  }
            get { return id; }
        }
        public string name;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int Price { get; set; }
        public int Quantity { get; set; }
        private int discount;
        public int Discount { set { discount = value; } }
        private double total;
        public double Total { get { return Price * Quantity - discount; } }
    

        
    }
}
