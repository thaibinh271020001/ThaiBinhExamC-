using System;
using System.Collections;
using System.Collections.Generic;

namespace TuLam7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> book = new List<Book>()
            {
                new Book{Id = "S1", Title = "De men" , Author = "Khac long", Publisher = "kim dong", Price = 10000, Year = 2001},
                new Book{Id = "S2", Title = "Ho Bao" , Author = "Bach Tuyet", Publisher = "Thanh nien", Price = 12000, Year = 2002},
                new Book{Id = "S3", Title = "Su Tu" , Author = "Thai Binh", Publisher = "kim dong", Price = 19000, Year = 2003},
                new Book{Id = "S4", Title = "Bo Sat" , Author = "Khac long", Publisher = "Thanh nien", Price = 11000, Year = 2014},
                new Book{Id = "S5", Title = "Duoi nuoc" , Author = "Manh Truong", Publisher = "kim dong", Price = 20000, Year = 2005},
                new Book{Id = "S6", Title = "Tren Khong" , Author = "Bach Tuyet", Publisher = "Thanh nien", Price = 40000, Year = 2006},
                new Book{Id = "S7", Title = "Khung Long" , Author = "Ha Son", Publisher = "kim dong", Price = 20000, Year = 2014},
                new Book{Id = "S8", Title = "Con trung" , Author = "Viet ANh", Publisher = "Thanh nien", Price = 15000, Year = 2014},
                new Book{Id = "S9", Title = "Vi sinh vat" , Author = "Thai Binh", Publisher = "kim dong", Price = 12000, Year = 2007},
                new Book{Id = "S10", Title = "Con trung" , Author = "Nguyen Manh", Publisher = "Thanh nien", Price = 14000, Year = 2008},
            };

            Console.WriteLine("Danh sach sach: ");
            foreach(Book bk in book)
            {
                Console.WriteLine(bk);
            }

            Console.WriteLine("\n Danh sach tang dan theo gia tien");
            /*int max = book[0].Price;
            Book maxPrice = book[0];
            foreach (Book bk in book)
            {
                if (max < bk.Price)
                {
                    max = bk.Price;
                    maxPrice = bk;
                }
            }*/

            book.Sort();
            foreach (Book bk in book)
            {
                Console.WriteLine(bk);
            }

            Console.Write("\nNhap sach co title muon tim: ");
            string tit = Console.ReadLine();
            int count=0;
            foreach(Book bk in book)
            {
                if(bk.Title == tit)
                {
                    Console.WriteLine(bk);
                    count++;
                }
            }

            if(count == 0)
            {
                Console.WriteLine("Title ban nhap khong co trong du lieu");
            }

            Console.WriteLine("\nNhung sach xuat ban 2014: ");
            foreach (Book bk in book)
            {
                if (bk.Year == 2014)
                {
                    Console.WriteLine(bk);
                }
            }

            Console.WriteLine("\nNhung sach khong thuoc nha xuat ban kim dong: ");
            //kim dong
            for(int j = 0; j < book.Count; j++)
            {
                for (int i = 0; i < book.Count; i++)
                {
                    Book bk = book[i];
                    if (bk.Publisher == "kim dong")
                    {
                        book.Remove(bk);
                    }
                }
            }

            foreach (Book bk in book)
            {
                Console.WriteLine(bk);
            }
        }
    }
}
