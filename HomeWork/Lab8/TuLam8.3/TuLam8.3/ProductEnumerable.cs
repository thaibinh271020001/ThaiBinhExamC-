using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TuLam8._3
{
    class ProductEnumerable:IEnumerable
    {
        string[] Product = { "chelsea", "arsenal", "mancity", "manunited","tottenham", "liverpool"};

        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i< Product.Length; i++)
            {
                yield return Product[i];
            }
        }
    }
}
