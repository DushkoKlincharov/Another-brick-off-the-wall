using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Another_Brick_Off_The_Wall
{
    public class Scene
    {
        // static variables used for dimensions
        public static readonly int UNIT = 10;
        public static readonly int ROW_BOXES = 52;
        public static readonly int COLUMN_BOXES = 80;
        public static readonly int WIDTH = COLUMN_BOXES * UNIT;
        public static readonly int HEIGHT = ROW_BOXES * UNIT;
       
        // Objects of the scene
        public Ball Ball { get; set; }
        public Slider Slider { get; set; }
        public List<Tile> Tiles { get; set; }
        public Reward Reward { get; set; }

        // Variables used for sending arguments to the objects
        public Level Level { get; set; }
        public PictureBox PictureBox { get; set; }

        // helping variables in the scene
        public bool MoveLeftSlider { get; set; }
        public bool MoveRightSlider { get; set; }

        // constructor of the scene
        public Scene(Level lvl, PictureBox picBox)
        {
            PictureBox = picBox;
            Level = lvl;
            Ball = new Ball(PictureBox, Level.BallSpeed);
            Slider = new Slider(Level.SliderLength);
            Tiles = Level.getTiles();
            Reward = null;
            MoveLeftSlider = MoveRightSlider = false;
        }

        // draw method
        public void Draw(Graphics g)
        {
            Ball.Draw(g);
            Slider.Draw(g);
            foreach (Tile tile in Tiles)
            {
                tile.Draw(g);
            }
            Reward.Draw(g);
        }

        // method for moving slider
        public void MoveSlider()
        {
            if (MoveLeftSlider) Slider.Move(-UNIT);
            if (MoveRightSlider) Slider.Move(UNIT);
        }
        
    }
}
