using System;
using System.Collections.Generic;
using System.Text;

namespace Mau8._2
{
    class MathEx
    {
        public static T Max<T>(T first, params T[] values) where T : IComparable
        {
            T maxium = first;
            foreach(T item in values)
            {
                if(item.CompareTo(maxium) > 0)
                {
                    maxium = item;
                }
            }
            return maxium;
        }

        public static T Min<T>(T first, params T[] values) where T : IComparable
        {
            T minimum = first;
            foreach(T item in values)
            {
                if(item.CompareTo(minimum) < 0)
                {
                    minimum = item;
                }
            }
            return minimum;
        }
    }
}
