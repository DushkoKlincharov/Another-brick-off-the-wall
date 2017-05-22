using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Another_Brick_Off_The_Wall.Properties;
using System.Drawing;

namespace Another_Brick_Off_The_Wall
{
    public class MediumTile : Tile
    {

        public MediumTile(float x, float y)
        {
            X = x;
            Y = y;
            Width = (int)TileLenghts.MEDIUM;
            Image = Resources.MediumTile;
        }

        public override void Draw(Graphics g)
        {
            g.DrawImage(Image, new Rectangle((int)X, (int)Y, Width, HEIGHT));
        }
    }
}
