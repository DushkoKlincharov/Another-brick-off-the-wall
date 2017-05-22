using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Another_Brick_Off_The_Wall
{
    public class Level2 : Level
    {
        public Level2()
        {
            BallSpeed = BallSpeeds.MEDIUM;
            SliderLength = SliderLengths.MEDIUM;
            Tiles = makeGrid();
        }

        public List<Tile> makeGrid()
        {
            List<Tile> tiles = new List<Tile>();
            for (int i = 0; i < 5; ++i)
            {

                for (int j = 0; j * Scene.UNIT < Scene.WIDTH; ++j)
                {

                    if ((j == 1 || j == 71) && (i == 2))
                    {
                        tiles.Add(new SmallTile(j * Scene.UNIT, i * Scene.UNIT * 3));
                    }

                    if ((j == 9 || j == 63) && (i >= 1 && i <= 3))
                    {
                        tiles.Add(new SmallTile(j * Scene.UNIT, i * Scene.UNIT * 3));
                    }

                    if (j == 17 || j == 53)
                    {
                        tiles.Add(new MediumTile(j * Scene.UNIT, i * Scene.UNIT * 3));
                    }

                    if (j == 27 || j == 40)
                    {
                        tiles.Add(new BigTile(j * Scene.UNIT, i * Scene.UNIT * 3));
                    }
                }
            }
            return tiles;
        }
        
    }
}
