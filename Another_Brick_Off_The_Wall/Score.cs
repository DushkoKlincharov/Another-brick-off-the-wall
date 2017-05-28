using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Another_Brick_Off_The_Wall
{
    public class Score
    {
        public string Name { get; set; }
        public int Points { get; set; }

        public Score(string name, int points)
        {
            Name = name;
            Points = points;
        }

        public override string ToString()
        {
            return string.Format("{0},{1}\n", Name, Points);
        }

    }
}
