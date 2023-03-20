using System;
using System.Collections.Generic;
using System.Text;

namespace Bai5._3
{
    class Chapters
    {
        private string name;
        private string content;

        public Chapters()
        {
            name = "";
            content = "";
        }
        public Chapters(string name, string content)
        {
            this.name = name;
            this.content = content;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        public override string ToString()
        {
            return name + "\n" + content;
        }

    }
}
