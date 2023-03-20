using System;
using System.Collections.Generic;
using System.Text;

namespace Bai5._3
{
    class Book
    {
        private string name;
        private Chapters[] chapters;

        public Book()
        {

        }
        public Book(string name, int n)
        {
            this.name = name;
            chapters = new Chapters[n];
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException();
                name = value;
            }
        }

        public Chapters this[int index]
        {
            get
            {
                if (index < 0 || index > chapters.Length - 1)
                    return null;
                return chapters[index];
            }
            set
            {
                if (index < 0 || index > chapters.Length - 1)
                    throw new ArgumentException();
                chapters[index] = value;
            }
        }

        public Chapters this[string name]
        {
            get
            {
                foreach(Chapters ch in chapters)
                {
                    if(ch.Name == name)
                    {
                        return ch;
                    }
                }
                return null;
            }
        }
    }
}
