using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Another_Brick_Off_The_Wall.Properties;

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

        public Slider(Level.SliderLengths sl)
        {
            Width = Convert.ToInt32(sl);
            X = (Scene.WIDTH / 2) - Width / 2;
            Y = Scene.HEIGHT - 4 * Scene.UNIT;

            if (sl == Level.SliderLengths.SMALL) Image = Resources.smallSlider;
            else if (sl == Level.SliderLengths.MEDIUM) Image = Resources.MediumSlider;
            else Image = Resources.BigSlider;
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(Image, new Rectangle((int)X, (int)Y, Width,HEIGHT));
        }

        public void Move(int dx)
        {
            X += dx;
            if (X <= 0) X = 0;
            if (X + Width >= Scene.WIDTH) X = Scene.WIDTH - Width;
        }

        public bool touchReward(Reward rwd)
        {
            return ((rwd.Y + Reward.SIDE > Y) && ((rwd.X > X && rwd.X < X + Width) ||
                (rwd.X + Reward.SIDE > X && rwd.X + Reward.SIDE < X + Width)));
        }

        public void ChangeLength(int dx)
        {
            Width += dx;
        }

    }
}
