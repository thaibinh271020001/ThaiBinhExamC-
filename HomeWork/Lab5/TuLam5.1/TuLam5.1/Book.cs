using System;
using System.Collections.Generic;
using System.Text;

namespace TuLam5._1
{
    class Book
    {
        public int id;
        public string title;
        public int price;
        public string publisher;

        public Book()
        {

        }

        public Book(int id, string title, int price, string publisher)
        {
            this.id = id;
            this.title = title;
            this.price = price;
            this.publisher = publisher;
        }

        public int ID
        {
            get { return id; }
        }
        public string Title
        {
            get { return title; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }

        }

        public override string ToString()
        {
             
            return "Cuon sach co id = " +id + "gia tien " + price +" ten sach "+title+" Nha xuat ban: "+ publisher ;
        }

    }
}
