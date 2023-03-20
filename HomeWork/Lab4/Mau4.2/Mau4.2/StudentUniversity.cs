﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mau4._2
{
    class StudentUniversity:StudentCollege
    {
        protected double score4;

        public StudentUniversity(string name, int year, double score1, double score2, double score3, double score4) : base(name, year, score1, score2, score3)
        {
            this.score4 = score4;
        }

        public override double Average()
        {
            return (score1 + score2 + score3 + score4) / 4;
        }
        public new void Display()
        {
            base.Display();
            Console.WriteLine("Score4: {0}", score4);
        }
    }
}
