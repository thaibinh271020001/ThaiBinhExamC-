using System;
using System.Collections.Generic;
using System.Text;

namespace Mau8._4
{
    interface ICaluclator<T>
    {
        T Add(T a, T b);
        T Sub(T a, T b);
        T Div(T a, T b);
        T Mul(T a, T b);
    }
}
