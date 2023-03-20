using System;
using System.Collections.Generic;
using System.Text;

namespace TuLam6._2
{
    class Student
    {
        public int id;
        public string name;
        public double theorymark;
        public double labmark;

        public int Id
        {
            get { return id;}
            set {id = value;}
        }
        public string Name
        {
            get { return name;}
            set { name = value;}
        }
        public double Theorymark
        {
            get { return theorymark; }
            set { theorymark = value;}
        }
        public double Labmark
        {
            get { return labmark; }
            set { labmark = value;}
        }

        
    }
}
