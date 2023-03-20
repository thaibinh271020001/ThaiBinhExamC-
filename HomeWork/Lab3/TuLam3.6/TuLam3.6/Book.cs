using System;
using System.Collections.Generic;
using System.Text;

namespace TuLam3._6
{
    class Book
    {
        public string author;
        public int pages;
        public string isbn;
        public string title;
        public int currentpage;

        public Book()
        {
            this.currentpage = 1;
        }

        public Book(string author, int pages, string isbn, string title, int currentpage)
        {
            this.author = author;
            this.pages = pages;
            this.isbn = isbn;
            this.title = title;
            this.currentpage = currentpage;
        }
    }
}
