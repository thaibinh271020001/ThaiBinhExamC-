using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Mau8._5
{
    class Department: IEnumerable
    {
        string[] names = { "Finance", "Human Resource", "Information Teachnology", "Maketing"};

        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < names.Length; i++)
            {
                yield return names[i];
            }
        }
    }
}
