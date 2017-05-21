using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Another_Brick_Off_The_Wall
{
    abstract class Level
    {
        public enum BallSpeeds { SLOW = 10, MEDIUM = 20, FAST = 30 }
        public enum SliderLengths { SMALL = 30, MEDIUM = 60, LARGE = 90 }

        public BallSpeeds BallSpeed { get; set; }
        public SliderLengths SliderLength { get; set; }
    }
}
