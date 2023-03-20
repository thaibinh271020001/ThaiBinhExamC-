using System;
using System.Collections.Generic;
using System.Text;

namespace Mau8._3
{
    public class PersonalIdentification : IPerson
    {
        private string _name;
        private DateTime _dob;

        public PersonalIdentification(string name)
        {
            _name = name;
            _dob = new DateTime(0);
        }

        public virtual string FullName
        { 
            get { return _name; }
            set { _name = value; }
        }
        
        public DateTime DateofBirth
        { 
            get { return _dob; }
            set { _dob = value; }
        }
    }
}
