using System;
using System.Collections.Generic;
using System.Text;

namespace Mau8._3
{
    public class Employee<T> where T : PersonalIdentification
    {
        private T info;

        public Employee()
        {

        }

        public Employee(T record)
        {
            info = record;
        }

        public T Identification
        {
            get { return info; }
            set { info = value; }
        }
    }
}
