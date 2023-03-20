using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Mau8._5
{
    class Flower
    {
        string[] names = { "Hong", "Cuc", "Lan", "Ly", "Mai", "Dao" };
        //tạo phương thức có kiểu trả về là IEnumberable
        public IEnumerable GetFlower()
        {
            for (int i = 0; i < names.Length; i++)
            {
                yield return names[i];
            }
        }
    }

}
