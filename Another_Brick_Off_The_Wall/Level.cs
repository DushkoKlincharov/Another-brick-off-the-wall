using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Another_Brick_Off_The_Wall
{
    public abstract class Level
    {
        public enum BallSpeeds { SLOW = 4, MEDIUM = 6, FAST = 8 }
        public enum SliderLengths { SMALL = 100, MEDIUM = 125, LARGE = 150 }

        public List<Tile> Tiles { get; set; }
        public BallSpeeds BallSpeed { get; set; }
        public SliderLengths SliderLength { get; set; }

        public List<Tile> getTiles()
        {
            return Tiles;
        }
        
   }
}
