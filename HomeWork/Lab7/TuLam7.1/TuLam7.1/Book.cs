using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace TuLam7._1
{
    class Book : IComparable<Book>
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }

        public int CompareTo(Book other)
        {
            return this.Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return "Id: " + Id + "   " + "Title: " + Title + "   " + "Author: " + Author + "   " + "Publisher: " + Publisher + "   " + "Year: " + Year + "   " + "Price: " + Price;
        }
    }
}
