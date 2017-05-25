using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Another_Brick_Off_The_Wall.Properties;
using System.Drawing;

namespace Another_Brick_Off_The_Wall
{
    public class SmallTile : Tile
    {

        public SmallTile(float x, float y)
        {
            X = x;
            Y = y;
            Width = (int)TileLenghts.SMALL;
            Image = Resources.SmallTile;
        }

        public override void Draw(Graphics g)
        {
            g.DrawImage(Image, new Rectangle((int)X, (int)Y, Width, HEIGHT));
        }

        public override int getPoints(Level lvl)
        {
            if (lvl is Level1) return 110;
            else return 125;
        }
    }
}
