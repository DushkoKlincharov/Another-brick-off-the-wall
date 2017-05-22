using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Another_Brick_Off_The_Wall
{
    public abstract class Tile
    {
        public enum TileLenghts { SMALL = 80, MEDIUM = 100, BIG = 130, FINKI =50 }

        // Upper-left point of the tile
        public float X { get; set; }
        public float Y { get; set; }

        // Dimensions of the tile
        public int Width { get; set; }
        public static readonly int HEIGHT = 3 * Scene.UNIT;

        public Image Image { get; set; }
        public bool isAlive { get; set; }

        public abstract void Draw(Graphics g);

        public Tile()
        {
            isAlive = true;
        }

    }
}
