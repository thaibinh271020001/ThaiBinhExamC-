using System;
using System.Collections.Generic;
using System.Text;

namespace Mau10._4
{
    class Film
    {
        public string FilmId { get; set; }
        public string FilmName { get; set; }
        public int Price { get; set; }
        public override string ToString()
        {
            return FilmId + ":" + FilmName + ":" + Price;
        }
    }
}
