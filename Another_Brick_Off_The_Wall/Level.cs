using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Another_Brick_Off_The_Wall
{
    public abstract class Level
    {
        public enum BallSpeeds { SLOW = 6, MEDIUM = 8, FAST = 9 }
        public enum SliderLengths { SMALL = 100, MEDIUM = 125, LARGE = 150 }
        public enum Deltas { EASY = 3, MEDIUM = 4, HARD = 5 }

        public List<Tile> Tiles { get; set; }
        public BallSpeeds BallSpeed { get; set; }
        public SliderLengths SliderLength { get; set; }
        public Deltas Delta;

        public List<Tile> getTiles()
        {
            return Tiles;
        }
        
   }
}
