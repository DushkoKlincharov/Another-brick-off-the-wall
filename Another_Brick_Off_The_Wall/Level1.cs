using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Another_Brick_Off_The_Wall
{
    public class Level1 : Level
    {
        public Level1()
        {
            BallSpeed = BallSpeeds.SLOW;
            SliderLength = SliderLengths.LARGE;
            Tiles = makeGrid();
            Delta = Deltas.EASY;
        }

        public List<Tile> makeGrid()
        {
            List<Tile> tiles = new List<Tile>();
            for (int i = 0; i < 6; ++i)
            {
                if (i % 3 == 0)
                {

                    for (int j = 1; (j + 13) * Scene.UNIT < Scene.WIDTH; j += 13)
                    {
                        tiles.Add(new BigTile(j * Scene.UNIT, i * Scene.UNIT * 3));
                    }
                }
                if (i % 3 == 1)
                {
                    for (int j = 0; (j + 10) * Scene.UNIT <= Scene.WIDTH; j += 10)
                    {
                        tiles.Add(new MediumTile(j * Scene.UNIT, i * Scene.UNIT * 3));
                    }
                }
                if (i % 3 == 2)
                {
                    for (int j = 0; (j + 8) * Scene.UNIT <= Scene.WIDTH; j += 8)
                    {
                        tiles.Add(new SmallTile(j * Scene.UNIT, i * Scene.UNIT * 3));
                    }
                }
            }
            return tiles;
        }
    }
}
