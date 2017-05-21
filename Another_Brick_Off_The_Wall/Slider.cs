using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Another_Brick_Off_The_Wall
{
    public class Slider
    {
        // Slider upper-left position
        public float X { get; set; }
        public float Y { get; set; }

        // The dimensions of the rectangle
        public int Width { get; set; }
        public static readonly int HEIGHT = 2 * Scene.UNIT;

        // Image for the slider 
        public Image Image { get; set; }

        /*public Slider(SliderLenghts)
        {
            X = x;
            Y = y;
            Width = width;
        }*/



    }
}
