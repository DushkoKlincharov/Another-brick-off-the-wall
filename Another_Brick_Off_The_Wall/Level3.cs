using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Another_Brick_Off_The_Wall
{
    public class Level3 : Level
    {
        public Level3()
        {
            BallSpeed = BallSpeeds.FAST;
            SliderLength = SliderLengths.SMALL;
            Tiles = makeGrid();
            Delta = Deltas.HARD;
        }

        public List<Tile> makeGrid()
        {
            List<Tile> tiles = new List<Tile>();
            for (int i = 0; i < 5; ++i)
            {

                for (int j = 0; j * Scene.UNIT < Scene.WIDTH; ++j)
                {
                    if ((j == 1 || j == 17 || j == 28 || j == 42 || j == 54 || j == 74))
                    {
                        tiles.Add(new FinkiTile(j * Scene.UNIT, i * Scene.UNIT * 3));
                    }

                    if (j == 6 && (i == 0 || i == 2))
                    {
                        tiles.Add(new FinkiTile(j * Scene.UNIT, i * Scene.UNIT * 3));
                    }

                    if ((j == 37 || j == 61) && i == 3)
                    {
                        tiles.Add(new FinkiTile(j * Scene.UNIT, i * Scene.UNIT * 3));
                    }

                    if ((j == 35 || j == 59) && i == 2)
                    {
                        tiles.Add(new FinkiTile(j * Scene.UNIT, i * Scene.UNIT * 3));
                    }

                    if ((j == 33 || j == 61) && i == 1)
                    {
                        tiles.Add(new FinkiTile(j * Scene.UNIT, i * Scene.UNIT * 3));
                    }

                    if ((j == 63) && (i == 0 || i == 4))
                    {
                        tiles.Add(new FinkiTile(j * Scene.UNIT, i * Scene.UNIT * 3));
                    }
                
                }
            }
            return tiles;
        }
    }
}
